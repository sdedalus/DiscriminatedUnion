using AutoMapper;
using DiscriminatedUnion;

namespace UnionAutoMap
{
	/// <summary>
	/// Performs conversion from source to destination type
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="TDestination">The type of the destination.</typeparam>
	/// <seealso cref="AutoMapper.ITypeConverter{DiscriminatedUnion.Union{T1, T2}, TDestination}" />
	public class FromUnionConverter<T1, T2, TDestination> : ITypeConverter<Union<T1, T2>, TDestination>
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
		public TDestination Convert(Union<T1, T2> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}
}