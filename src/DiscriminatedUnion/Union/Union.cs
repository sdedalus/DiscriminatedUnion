namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Nice ways to work with a Union type.
	/// </summary>
	public static partial class Union
	{
		/// <summary>
		/// Returns the specified value.  This is silly but cleans up the code.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="unit">The unit.</param>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static T Return<T>(this Unit unit, T value) => value;

		/// <summary>
		/// To the error union.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Err">The type of the rr.</typeparam>
		/// <param name="factory">The factory.</param>
		/// <returns></returns>
		public static Union<T, Err> ToErrorUnion<T, Err>(this Func<T> factory)
			where Err : SystemException
		{
			try
			{
				return new Union<T, Err>(factory());
			}
			catch (Err ex)
			{
				return new Union<T, Err>(ex);
			}
		}

		/// <summary>
		/// To the error union.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Err1">The type of the RR1.</typeparam>
		/// <typeparam name="Err2">The type of the RR2.</typeparam>
		/// <param name="factory">The factory.</param>
		/// <returns></returns>
		public static Union<T, Err1, Err2> ToErrorUnion<T, Err1, Err2>(this Func<T> factory)
		where Err1 : SystemException
		where Err2 : SystemException
		{
			try
			{
				return new Union<T, Err1, Err2>(factory());
			}
			catch (Err1 ex)
			{
				return new Union<T, Err1, Err2>(ex);
			}
			catch (Err2 ex)
			{
				return new Union<T, Err1, Err2>(ex);
			}
		}

		/// <summary>
		/// To the error union.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="factory">The factory.</param>
		/// <returns></returns>
		public static Union<T, SystemException> ToErrorUnion<T>(this Func<T> factory)
		{
			try
			{
				return new Union<T, SystemException>(factory());
			}
			catch (SystemException ex)
			{
				return new Union<T, SystemException>(ex);
			}
		}

		public static Union<TSub1, TBase> ToUnionOfSubTypes<TBase, TSub1>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(v => v)
				.Default(() => null);
		}

		public static Union<TSub1, TSub2, TBase> ToUnionOfSubTypes<TBase, TSub1, TSub2>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TSub2, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(v => v)
				.Default(() => null);
		}

		public static Union<TSub1, TSub2, TSub3, TBase> ToUnionOfSubTypes<TBase, TSub1, TSub2, TSub3>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TSub2, TSub3, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(v => v)
				.Default(() => null);
		}

		public static Union<TSub1, TSub2, TSub3, TSub4, TBase> ToUnionOfSubTypes<TBase, TSub1, TSub2, TSub3, TSub4>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TSub2, TSub3, TSub4, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(v => v)
				.Default(() => null);
		}

		public static Union<TSub1, TSub2, TSub3, TSub4, TSub5, TBase> ToUnionOfSubTypes<TBase, TSub1, TSub2, TSub3, TSub4, TSub5>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TSub2, TSub3, TSub4, TSub5, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(v => v)
				.Default(() => null);
		}

		public static Union<TSub1, TSub2, TSub3, TSub4, TSub5, TSub6, TBase> ToUnionOfSubTypes<TBase, TSub1, TSub2, TSub3, TSub4, TSub5, TSub6>(this TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TSub2, TSub3, TSub4, TSub5, TSub6, TBase>>(baseClass)
				.Case(c => c.GetType() == typeof(TSub1), v => (TSub1)v)
				.Case(c => c.GetType() == typeof(TSub2), v => (TSub2)v)
				.Case(c => c.GetType() == typeof(TSub3), v => (TSub3)v)
				.Case(c => c.GetType() == typeof(TSub4), v => (TSub4)v)
				.Case(c => c.GetType() == typeof(TSub5), v => (TSub5)v)
				.Case(c => c.GetType() == typeof(TSub6), v => (TSub6)v)
				.Case(v => v)
				.Default(() => null);
		}

		public static Union<TSub1, TSub2, TSub3, TSub4, TSub5, TSub6, TSub7, TBase> ToUnionOfSubTypes<TBase, TSub1, TSub2, TSub3, TSub4, TSub5, TSub6, TSub7>(TBase baseClass)
			where TBase : class
			where TSub1 : TBase
			where TSub2 : TBase
			where TSub3 : TBase
			where TSub4 : TBase
			where TSub5 : TBase
			where TSub6 : TBase
			where TSub7 : TBase
		{
			return MatchExtensions.Match<TBase, Union<TSub1, TSub2, TSub3, TSub4, TSub5, TSub6, TSub7, TBase>>(baseClass)
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

		public static Func<Union<T1>, TReturn> CreateMap<T1, TReturn>(Func<ICase<T1, TReturn>, TReturn> map)
		{
			return Fun((Union<T1> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2>, TReturn> CreateMap<T1, T2, TReturn>(Func<ICase<T1, T2, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2, T3>, TReturn> CreateMap<T1, T2, T3, TReturn>(Func<ICase<T1, T2, T3, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2, T3> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2, T3, T4>, TReturn> CreateMap<T1, T2, T3, T4, TReturn>(Func<ICase<T1, T2, T3, T4, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2, T3, T4> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2, T3, T4, T5>, TReturn> CreateMap<T1, T2, T3, T4, T5, TReturn>(Func<ICase<T1, T2, T3, T4, T5, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2, T3, T4, T5> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2, T3, T4, T5, T6>, TReturn> CreateMap<T1, T2, T3, T4, T5, T6, TReturn>(Func<ICase<T1, T2, T3, T4, T5, T6, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2, T3, T4, T5, T6> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2, T3, T4, T5, T6, T7>, TReturn> CreateMap<T1, T2, T3, T4, T5, T6, T7, TReturn>(Func<ICase<T1, T2, T3, T4, T5, T6, T7, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2, T3, T4, T5, T6, T7> v) => map(v.Match<TReturn>()));
		}

		public static Func<Union<T1, T2, T3, T4, T5, T6, T7, T8>, TReturn> CreateMap<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(Func<ICase<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>, TReturn> map)
		{
			return Fun((Union<T1, T2, T3, T4, T5, T6, T7, T8> v) => map(v.Match<TReturn>()));
		}

		private static Func<TSource, TDestination> Fun<TSource, TDestination>(Func<TSource, TDestination> fun)
		{
			return fun;
		}
	}
}