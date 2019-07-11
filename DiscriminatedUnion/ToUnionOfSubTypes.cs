namespace DiscriminatedUnion
{
	using System;
	/// <summary>
	/// Nice ways to work with a Union type.
	/// </summary>
	public static partial class Union
	{
		public static Union<TSub1, TBase> ToUnionOfSubTypes<TBase, TSub1>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
			where TSub10 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(c => c.GetType() == typeof(TSub10), v => (TSub10)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
			where TSub10 : TBase
			where TSub11 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(c => c.GetType() == typeof(TSub10), v => (TSub10)v)
				.Case(c => c.GetType() == typeof(TSub11), v => (TSub11)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
			where TSub10 : TBase
			where TSub11 : TBase
			where TSub12 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(c => c.GetType() == typeof(TSub10), v => (TSub10)v)
				.Case(c => c.GetType() == typeof(TSub11), v => (TSub11)v)
				.Case(c => c.GetType() == typeof(TSub12), v => (TSub12)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
			where TSub10 : TBase
			where TSub11 : TBase
			where TSub12 : TBase
			where TSub13 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(c => c.GetType() == typeof(TSub10), v => (TSub10)v)
				.Case(c => c.GetType() == typeof(TSub11), v => (TSub11)v)
				.Case(c => c.GetType() == typeof(TSub12), v => (TSub12)v)
				.Case(c => c.GetType() == typeof(TSub13), v => (TSub13)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
			where TSub10 : TBase
			where TSub11 : TBase
			where TSub12 : TBase
			where TSub13 : TBase
			where TSub14 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(c => c.GetType() == typeof(TSub10), v => (TSub10)v)
				.Case(c => c.GetType() == typeof(TSub11), v => (TSub11)v)
				.Case(c => c.GetType() == typeof(TSub12), v => (TSub12)v)
				.Case(c => c.GetType() == typeof(TSub13), v => (TSub13)v)
				.Case(c => c.GetType() == typeof(TSub14), v => (TSub14)v)
				.Case(v => v)
				.Default(() => null);
		}
		public static Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15, TBase> ToUnionOfSubTypes<TBase, TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
			where TSub8 : TBase
			where TSub9 : TBase
			where TSub10 : TBase
			where TSub11 : TBase
			where TSub12 : TBase
			where TSub13 : TBase
			where TSub14 : TBase
			where TSub15 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1,TSub2,TSub3,TSub4,TSub5,TSub6,TSub7,TSub8,TSub9,TSub10,TSub11,TSub12,TSub13,TSub14,TSub15, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(c => c.GetType() == typeof(TSub7), v => (TSub7)v)
				.Case(c => c.GetType() == typeof(TSub8), v => (TSub8)v)
				.Case(c => c.GetType() == typeof(TSub9), v => (TSub9)v)
				.Case(c => c.GetType() == typeof(TSub10), v => (TSub10)v)
				.Case(c => c.GetType() == typeof(TSub11), v => (TSub11)v)
				.Case(c => c.GetType() == typeof(TSub12), v => (TSub12)v)
				.Case(c => c.GetType() == typeof(TSub13), v => (TSub13)v)
				.Case(c => c.GetType() == typeof(TSub14), v => (TSub14)v)
				.Case(c => c.GetType() == typeof(TSub15), v => (TSub15)v)
				.Case(v => v)
				.Default(() => null);
		}
	}
}