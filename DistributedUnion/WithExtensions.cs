namespace DiscriminatedUnion
{
	using System;

	public static class WithExtensions
	{
		public static IElse<TReturn> With<T1, TReturn>(
			this IWith<T1, TReturn> with,
			Func<T1, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IElse<TReturn>)with);

		public static IWith<T1, TReturn> With<T2, T1, TReturn>(
			this IWith<T2, T1, TReturn> with,
			Func<T2, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T1, TReturn>)with);

		public static IWith<T2, T1, TReturn> With<T3, T2, T1, TReturn>(
			this IWith<T3, T2, T1, TReturn> with,
			Func<T3, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T2, T1, TReturn>)with);

		public static IWith<T3, T2, T1, TReturn> With<T4, T3, T2, T1, TReturn>(
			this IWith<T4, T3, T2, T1, TReturn> with,
			Func<T4, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T3, T2, T1, TReturn>)with);

		public static IWith<T4, T3, T2, T1, TReturn> With<T5, T4, T3, T2, T1, TReturn>(
			this IWith<T5, T4, T3, T2, T1, TReturn> with,
			Func<T5, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T4, T3, T2, T1, TReturn>)with);

		public static IWith<T5, T4, T3, T2, T1, TReturn> With<T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T6, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T5, T4, T3, T2, T1, TReturn>)with);

		public static IWith<T6, T5, T4, T3, T2, T1, TReturn> With<T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T7, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T6, T5, T4, T3, T2, T1, TReturn>)with);

		public static IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> With<T8, T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T7, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T7, T6, T5, T4, T3, T2, T1, TReturn>)with);

		public static IWith<T1, TReturn> With<T1, TReturn>(
			this IWith<T1, TReturn> with,
			Func<T1, bool> condition,
			Func<T1, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T2, T1, TReturn> With<T2, T1, TReturn>(
			this IWith<T2, T1, TReturn> with,
			Func<T2, bool> condition,
			Func<T2, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T3, T2, T1, TReturn> With<T3, T2, T1, TReturn>(
			this IWith<T3, T2, T1, TReturn> with,
			Func<T3, bool> condition,
			Func<T3, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T4, T3, T2, T1, TReturn> With<T4, T3, T2, T1, TReturn>(
			this IWith<T4, T3, T2, T1, TReturn> with,
			Func<T4, bool> condition, Func<T4, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T5, T4, T3, T2, T1, TReturn> With<T5, T4, T3, T2, T1, TReturn>(
			this IWith<T5, T4, T3, T2, T1, TReturn> with,
			Func<T5, bool> condition, Func<T5, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T6, T5, T4, T3, T2, T1, TReturn> With<T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T6, bool> condition, Func<T6, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> With<T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T7, bool> condition, Func<T7, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		public static IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> With<T8, T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T8, bool> condition, Func<T8, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);
	}
}