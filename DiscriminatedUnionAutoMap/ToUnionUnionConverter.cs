using AutoMapper;
using DiscriminatedUnion;
using System;
using System.Linq;

namespace UnionAutoMap
{
	/// <summary>
	/// converts from a TSource to a to a Union
	/// </summary>
	/// <typeparam name="TSource">The type of the source.</typeparam>
	/// <typeparam name="TTypeDest">The type of the type dest.</typeparam>
	/// <typeparam name="TUnionDest">The type of the union dest.</typeparam>
	/// <seealso cref="AutoMapper.ITypeConverter{TSource, TUnionDest}" />
	public class ToUnionConverter<TSource, TTypeDest, TUnionDest> : ITypeConverter<TSource, TUnionDest> where TUnionDest : UnionBase
	{
		public TUnionDest Convert(TSource source, TUnionDest destination, ResolutionContext context)
		{
			// ToDo: Find a way to avoid reflection here. It's roughly 100x slower than most other operations.
			Type unionType = typeof(TUnionDest);
			if (unionType.GenericTypeArguments.Contains(typeof(TTypeDest)))
			{
				TTypeDest value = Mapper.Map<TTypeDest>(source);
				return (TUnionDest)Activator.CreateInstance(unionType, value);
			}

			throw new InvalidCastException("Destination Union type must contain the Destination type.");
		}
	}
}