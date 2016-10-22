using System;

namespace DiscriminatedUnion
{
	public static class MatchExtensions
	{
		public static IWith<T1, TReturn> Match<T1, TReturn>(this T1 value) =>
			new Match<T1, TReturn>(Tuple.Create<Type, object>(typeof(T1), value));

		public static IWith<string, TReturn> Match<TReturn>(this string value) =>
			new Match<string, TReturn>(Tuple.Create<Type, object>(typeof(string), value));

		public static IWith<int, TReturn> Match<TReturn>(this int value) =>
			new Match<int, TReturn>(Tuple.Create<Type, object>(typeof(int), value));

		public static IWith<double, TReturn> Match<TReturn>(this double value) =>
			new Match<double, TReturn>(Tuple.Create<Type, object>(typeof(double), value));

		public static IWith<decimal, TReturn> Match<TReturn>(this decimal value) =>
			new Match<decimal, TReturn>(Tuple.Create<Type, object>(typeof(decimal), value));

		public static IWith<float, TReturn> Match<TReturn>(this float value) =>
			new Match<float, TReturn>(Tuple.Create<Type, object>(typeof(float), value));
	}
}