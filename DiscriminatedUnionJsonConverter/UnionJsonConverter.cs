using DiscriminatedUnion;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminatedUnionJsonConverter
{
	public class UnionJsonConverter<TDestination> : JsonConverter
		where TDestination : UnionBase
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var union = value as UnionBase;

			Type destUnionType = union.GetType();

			serializer.Serialize(writer, union.ValueContainer.ValueAsObject, union.ValueContainer.ContainedValueType);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var destArgs = objectType.GenericTypeArguments;

			JObject value = serializer.Deserialize<JObject>(reader);

			var duck = destArgs.Select(arg => new { Type = arg, score = DuckScore(arg.GetProperties(), value) }).ToList();
			var maxScore = duck.Max(c => c.score);

			var bestMatch = duck.First(c => c.score == maxScore);

			var contained = value.ToObject(bestMatch.Type);

			return Create(bestMatch.Type, contained);
		}

		private TDestination Create(Type containedType, object contained)
		{
			Type classType = typeof(TypedContainer<>);
			Type[] typeParams = new Type[] { containedType };
			Type constructedType = classType.MakeGenericType(typeParams);

			ITypeContainer container = (ITypeContainer)Activator.CreateInstance(constructedType, contained);

			return (TDestination)Activator.CreateInstance(typeof(TDestination), container);
		}

		private int DuckScore(PropertyInfo[] props, JObject jObj)
		{
			var nameScore = props.Select(prop => jObj[prop.Name] != null ? 10 : 0).Aggregate((v, a) => v + a);

			var typeScore = props.Select(prop => jObj[prop.Name].Type == ToJTokenType(prop.PropertyType) ? 1 : 0).Aggregate((v, a) => v + a);

			return nameScore + typeScore;
		}

		public JTokenType ToJTokenType(Type aType)
		{
			if (aType == typeof(bool))
			{
				return JTokenType.Boolean;
			}

			if (aType == typeof(DateTime))
			{
				return JTokenType.Date;
			}

			if (aType == typeof(float))
			{
				return JTokenType.Float;
			}

			if (aType == typeof(Guid))
			{
				return JTokenType.Guid;
			}

			if (aType == typeof(int))
			{
				return JTokenType.Integer;
			}

			if (aType == typeof(string))
			{
				return JTokenType.String;
			}

			if (aType == typeof(TimeSpan))
			{
				return JTokenType.TimeSpan;
			}

			if (aType == typeof(Uri))
			{
				return JTokenType.Uri;
			}

			if (aType.IsArray || typeof(IEnumerable).IsAssignableFrom(aType))
			{
				return JTokenType.Array;
			}

			return JTokenType.Object;
		}

		public override bool CanConvert(Type objectType)
		{
			return typeof(UnionBase).IsAssignableFrom(objectType);
		}
	}
}