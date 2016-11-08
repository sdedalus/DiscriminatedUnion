using AutoMapper;
using DiscriminatedUnion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionAutoMap
{
	public class FromUnionConverter<T1, TDestination> : ITypeConverter<Union<T1>, TDestination>
	{
		public TDestination Convert(Union<T1> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v)).Else(() => default(TDestination));
		}
	}
}