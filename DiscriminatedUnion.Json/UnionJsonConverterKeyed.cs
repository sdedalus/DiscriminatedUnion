using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Reflection;

namespace DiscriminatedUnion.Json
{
	/// <summary>
	/// Converts to and from Union and JSON strings.
	/// </summary>
	/// <typeparam name="TDestination">The type of the destination.</typeparam>
	/// <seealso cref="Newtonsoft.Json.JsonConverter" />
	public class UnionJsonConverterKeyed<TDestination> : JsonConverter
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

			Type destUnionType = typeof(TDestination);

			var KeyIndex = destUnionType
				.GenericTypeArguments
				.Select((ty, i) => new { type = ty, index = i })
				.First(v => v.type == union.ValueContainer.ContainedValueType);

			JToken t = JToken.FromObject(union.ValueContainer.ValueAsObject);

			JObject o = (JObject)t;
			o.AddFirst(new JProperty("_typeKey", KeyIndex.index));
			o.WriteTo(writer);
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
			var destArgs = objectType.GenericTypeArguments.Select((ty, i) => new { type = ty, index = i });

			JObject value = serializer.Deserialize<JObject>(reader);

			var innerType = destArgs.First(c => c.index == value["_typeKey"].Value<int>());

			var contained = value.ToObject(innerType.type);

			return Create(innerType.type, contained);
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