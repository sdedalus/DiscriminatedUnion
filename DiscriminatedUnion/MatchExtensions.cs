﻿using System;

namespace DiscriminatedUnion
{
	/// <summary>
	/// Extensions to match against primitive types.
	/// </summary>
	public static class MatchExtensions
	{
		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<T1, TReturn> Match<T1, TReturn>(T1 value) =>
			new Match<T1, TReturn>(new TypedContainer<T1>(value));

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<string, TReturn> Match<TReturn>(this string value) =>
			Match<string, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<int, TReturn> Match<TReturn>(this int value) =>
			Match<int, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<double, TReturn> Match<TReturn>(this double value) =>
			Match<double, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<decimal, TReturn> Match<TReturn>(this decimal value) =>
			Match<decimal, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<float, TReturn> Match<TReturn>(this float value) =>
			Match<float, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">if set to <c>true</c> [value].</param>
		/// <returns></returns>
		public static ICase<bool, TReturn> Match<TReturn>(this bool value) =>
			Match<bool, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<Byte, TReturn> Match<TReturn>(this Byte value) =>
			Match<Byte, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<DateTime, TReturn> Match<TReturn>(this DateTime value) =>
			Match<DateTime, TReturn>(value);

		/// <summary>
		/// Matches the specified value.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static ICase<char, TReturn> Match<TReturn>(this char value) =>
			Match<char, TReturn>(value);
	}
}