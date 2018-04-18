
using DiscriminatedUnion;
using AutoMapper;
namespace DiscriminatedUnion.AutoMap
{
	public class FromUnionConverter<T1, TDestination> : ITypeConverter<Union<T1>, TDestination>
	{
		public TDestination Convert(Union<T1> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2, TDestination> : ITypeConverter<Union<T1,T2>, TDestination>
	{
		public TDestination Convert(Union<T1,T2> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3, TDestination> : ITypeConverter<Union<T1,T2,T3>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4, TDestination> : ITypeConverter<Union<T1,T2,T3,T4>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7> source, TDestination destination, ResolutionContext context)
		{
			return source.Match<TDestination>()
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


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8> source, TDestination destination, ResolutionContext context)
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


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9> source, TDestination destination, ResolutionContext context)
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
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> source, TDestination destination, ResolutionContext context)
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
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> source, TDestination destination, ResolutionContext context)
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
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> source, TDestination destination, ResolutionContext context)
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
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> source, TDestination destination, ResolutionContext context)
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
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> source, TDestination destination, ResolutionContext context)
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
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Case(v => Mapper.Map<TDestination>(v))
				.Default(() => default(TDestination));
		}
	}


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> source, TDestination destination, ResolutionContext context)
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


	public class FromUnionConverter<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TDestination> : ITypeConverter<Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>, TDestination>
	{
		public TDestination Convert(Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> source, TDestination destination, ResolutionContext context)
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