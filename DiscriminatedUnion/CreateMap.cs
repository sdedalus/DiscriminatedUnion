namespace DiscriminatedUnion
{
	using System;
	/// <summary>
	/// Nice ways to work with a Union type.
	/// </summary>
	public static partial class Union
	{
		public static Func<Union<TSub1>, TReturn> CreateMap<TSub1, TReturn>(Func<ICase<TSub1, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2>, TReturn> CreateMap<TSub1,TSub2, TReturn>(Func<ICase<TSub1,TSub2, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3>, TReturn> CreateMap<TSub1,TSub2,TSub3, TReturn>(Func<ICase<TSub1,TSub2,TSub3, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15> v) => map(v.Match<TReturn>()));
		}
		public static Func<Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15,TSub16>, TReturn> CreateMap<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15,TSub16, TReturn>(Func<ICase<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15,TSub16, TReturn>, TReturn> map)
		{
			return Fun((Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15,TSub16> v) => map(v.Match<TReturn>()));
		}
	}
}