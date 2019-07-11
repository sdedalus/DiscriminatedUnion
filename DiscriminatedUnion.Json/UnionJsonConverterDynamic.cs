using DiscriminatedUnion;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace DiscriminatedUnion.Json
{
	/// <summary>
	/// Converts to and from Union and JSON strings.
	/// </summary>
	/// <typeparam name="TDestination">The type of the destination.</typeparam>
	/// <seealso cref="Newtonsoft.Json.JsonConverter" />
	public class UnionJsonConverterDynamic<TDestination> : JsonConverter
	{
		/// <summary>
		/// Writes the JSON representation of the object.
		/// </summary>
		/// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
		/// <param name="value">The value.</param>
		/// <param name="serializer">The calling serializer.</param>
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var union = value as UnionBase;

			Type destUnionType = union.GetType();

			serializer.Serialize(writer, union.ValueContainer.ValueAsObject, union.ValueContainer.ContainedValueType);
		}

		/// <summary>
		/// Reads the JSON representation of the object.
		/// </summary>
		/// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
		/// <param name="objectType">Type of the object.</param>
		/// <param name="existingValue">The existing value of object being read.</param>
		/// <param name="serializer">The calling serializer.</param>
		/// <returns>
		/// The object value.
		/// </returns>
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var destArgs = objectType.GenericTypeArguments;

			JObject value = serializer.Deserialize<JObject>(reader);

			var duck = destArgs.Select(arg => new { Type = arg, score = DuckScore(arg.GetRuntimeProperties().ToArray(), value) }).ToList();
			var maxScore = duck.Max(c => c.score);

			var bestMatch = duck.First(c => c.score == maxScore);

			var contained = value.ToObject(bestMatch.Type);

			return Create(bestMatch.Type, contained);
		}

		/// <summary>
		/// Creates the specified contained type.
		/// </summary>
		/// <param name="containedType">Type of the contained.</param>
		/// <param name="contained">The contained.</param>
		/// <returns></returns>
		private TDestination Create(Type containedType, object contained)
		{
			Type classType = typeof(Container<>);
			Type[] typeParams = new Type[] { containedType };
			Type constructedType = classType.MakeGenericType(typeParams);

			ITypeContainer container = (ITypeContainer)Activator.CreateInstance(constructedType, contained);

			return (TDestination)Activator.CreateInstance(typeof(TDestination), container);
		}

		/// <summary>
		/// Scores the Ducks.
		/// </summary>
		/// <param name="props">The props.</param>
		/// <param name="jObj">The j object.</param>
		/// <returns></returns>
		private int DuckScore(PropertyInfo[] props, JObject jObj)
		{
			var nameScore = props.Select(prop => jObj[prop.Name] != null ? 10 : 0).Aggregate((v, a) => v + a);

			var typeScore = props.Select(prop => jObj[prop.Name].Type == ToJTokenType(prop.PropertyType) ? 1 : 0).Aggregate((v, a) => v + a);

			return nameScore + typeScore;
		}

		/// <summary>
		/// To the type of the j token.
		/// </summary>
		/// <param name="aType">a type.</param>
		/// <returns></returns>
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

			if (aType.IsArray || typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(aType.GetTypeInfo()))
			{
				return JTokenType.Array;
			}

			return JTokenType.Object;
		}

		/// <summary>
		/// Determines whether this instance can convert the specified object type.
		/// </summary>
		/// <param name="objectType">Type of the object.</param>
		/// <returns>
		/// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
		/// </returns>
		public override bool CanConvert(Type objectType)
		{
			return typeof(UnionBase).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
		}
	}
}