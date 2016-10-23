namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// These are the functions that manage the matching by calling into the base type.
	/// </summary>
	public static class WithExtensions
	{
		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IElse<TReturn> Case<T1, TReturn>(
			this IWith<T1, TReturn> with,
			Func<T1, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IElse<TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T1, TReturn> Case<T2, T1, TReturn>(
			this IWith<T2, T1, TReturn> with,
			Func<T2, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T1, TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T2, T1, TReturn> Case<T3, T2, T1, TReturn>(
			this IWith<T3, T2, T1, TReturn> with,
			Func<T3, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T2, T1, TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T3, T2, T1, TReturn> Case<T4, T3, T2, T1, TReturn>(
			this IWith<T4, T3, T2, T1, TReturn> with,
			Func<T4, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T3, T2, T1, TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T4, T3, T2, T1, TReturn> Case<T5, T4, T3, T2, T1, TReturn>(
			this IWith<T5, T4, T3, T2, T1, TReturn> with,
			Func<T5, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T4, T3, T2, T1, TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T6">The type of the 6.</typeparam>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T5, T4, T3, T2, T1, TReturn> Case<T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T6, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T5, T4, T3, T2, T1, TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T7">The type of the 7.</typeparam>
		/// <typeparam name="T6">The type of the 6.</typeparam>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T6, T5, T4, T3, T2, T1, TReturn> Case<T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T7, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T6, T5, T4, T3, T2, T1, TReturn>)with);

		/// <summary>
		/// Withes the specified function.
		/// </summary>
		/// <typeparam name="T8">The type of the 8.</typeparam>
		/// <typeparam name="T7">The type of the 7.</typeparam>
		/// <typeparam name="T6">The type of the 6.</typeparam>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> Case<T8, T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T7, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(func).Return((IWith<T7, T6, T5, T4, T3, T2, T1, TReturn>)with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T1, TReturn> Case<T1, TReturn>(
			this IWith<T1, TReturn> with,
			Func<T1, bool> condition,
			Func<T1, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T2, T1, TReturn> Case<T2, T1, TReturn>(
			this IWith<T2, T1, TReturn> with,
			Func<T2, bool> condition,
			Func<T2, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T3, T2, T1, TReturn> Case<T3, T2, T1, TReturn>(
			this IWith<T3, T2, T1, TReturn> with,
			Func<T3, bool> condition,
			Func<T3, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T4, T3, T2, T1, TReturn> Case<T4, T3, T2, T1, TReturn>(
			this IWith<T4, T3, T2, T1, TReturn> with,
			Func<T4, bool> condition, Func<T4, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T5, T4, T3, T2, T1, TReturn> Case<T5, T4, T3, T2, T1, TReturn>(
			this IWith<T5, T4, T3, T2, T1, TReturn> with,
			Func<T5, bool> condition, Func<T5, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T6">The type of the 6.</typeparam>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T6, T5, T4, T3, T2, T1, TReturn> Case<T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T6, bool> condition, Func<T6, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T7">The type of the 7.</typeparam>
		/// <typeparam name="T6">The type of the 6.</typeparam>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> Case<T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T7, bool> condition, Func<T7, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);

		/// <summary>
		/// Withes the specified condition.
		/// </summary>
		/// <typeparam name="T8">The type of the 8.</typeparam>
		/// <typeparam name="T7">The type of the 7.</typeparam>
		/// <typeparam name="T6">The type of the 6.</typeparam>
		/// <typeparam name="T5">The type of the 5.</typeparam>
		/// <typeparam name="T4">The type of the 4.</typeparam>
		/// <typeparam name="T3">The type of the 3.</typeparam>
		/// <typeparam name="T2">The type of the 2.</typeparam>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="with">The with.</param>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		public static IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> Case<T8, T7, T6, T5, T4, T3, T2, T1, TReturn>(
			this IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> with,
			Func<T8, bool> condition, Func<T8, TReturn> func)
			=> ((IMatchIng<TReturn>)with)
			.SetReturnIfMatch(condition, func).Return(with);
	}
}