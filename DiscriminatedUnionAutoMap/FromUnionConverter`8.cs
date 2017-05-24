﻿using AutoMapper;
using DiscriminatedUnion;

namespace UnionAutoMap
{
	/// <summary>
	/// Performs conversion from source to destination type
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="T3">The type of the 3.</typeparam>
	/// <typeparam name="T4">The type of the 4.</typeparam>
	/// <typeparam name="T5">The type of the 5.</typeparam>
	/// <typeparam name="T6">The type of the 6.</typeparam>
	/// <typeparam name="T7">The type of the 7.</typeparam>
	/// <typeparam name="T8">The type of the 8.</typeparam>
	/// <typeparam name="TDestination">The type of the destination.</typeparam>
	/// <seealso cref="AutoMapper.ITypeConverter{DiscriminatedUnion.Union{T1, T2, T3, T4, T5, T6, T7, T8}, TDestination}" />
	public class FromUnionConverter<T1, T2, T3, T4, T5, T6, T7, T8, TDestination> : ITypeConverter<Union<T1, T2, T3, T4, T5, T6, T7, T8>, TDestination>
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
		public TDestination Convert(Union<T1, T2, T3, T4, T5, T6, T7, T8> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}
}