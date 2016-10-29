﻿using System;

namespace DiscriminatedUnion
{
	/// <summary>
	/// The extension methods that check the second type bind to this interface.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface ICase<T2, T1, TReturn> : IElse<TReturn>
	{
		/// <summary>
		/// Cases the specified function.
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T1, TReturn> Case(Func<T2, TReturn> func);

		/// <summary>
		/// Cases the specified condition.
		/// </summary>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T2, T1, TReturn> Case(Func<T2, bool> condition, Func<T2, TReturn> func);
	}
}