using AutoMapper;
using DiscriminatedUnion;
using System;

namespace UnionAutoMap
{
	/// <summary>
	///
	/// </summary>
	/// <typeparam name="TUnionSource">The type of the union source.</typeparam>
	/// <typeparam name="TUnionDest">The type of the union dest.</typeparam>
	/// <seealso cref="AutoMapper.ITypeConverter{TUnionSource, TUnionDest}" />
	public class FromUnionToUnionConverter<TUnionSource, TUnionDest> : ITypeConverter<TUnionSource, TUnionDest>
		where TUnionSource : UnionBase
		where TUnionDest : UnionBase
	{
		/// <summary>
		/// Performs conversion from source to destination type
		/// </summary>
		/// <param name="source">Source object</param>
		/// <param name="destination">Destination object</param>
		/// <param name="context">Resolution context</param>
		/// <returns>
		/// Destination object
		/// </returns>
		/// <exception cref="System.Exception"></exception>
		public TUnionDest Convert(TUnionSource source, TUnionDest destination, ResolutionContext context)
		{
			Type sourceUnionType = typeof(TUnionSource);
			Type destUnionType = typeof(TUnionDest);

			var destArgs = destUnionType.GenericTypeArguments;

			foreach (var arg in destArgs)
			{
				var typeMap = Mapper.Configuration.FindTypeMapFor(source.ValueContainer.ContainedValueType, arg);
				if (typeMap != null)
				{
					var tmpValue = Mapper.Map(source.ValueContainer.ValueAsObject, source.ValueContainer.ContainedValueType, arg);
					return (TUnionDest)Mapper.Map(tmpValue, arg, destUnionType);
				}
			}

			throw new Exception();
		}
	}
}