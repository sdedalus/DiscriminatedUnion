namespace DiscriminatedUnion
{
	using System;

	public class Match<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> :
		MatchBase<TReturn>,
		IWith<T8, T7, T6, T5, T4, T3, T2, T1, TReturn>,
		IWith<T7, T6, T5, T4, T3, T2, T1, TReturn>,
		IWith<T6, T5, T4, T3, T2, T1, TReturn>,
		IWith<T5, T4, T3, T2, T1, TReturn>,
		IWith<T4, T3, T2, T1, TReturn>,
		IWith<T3, T2, T1, TReturn>,
		IWith<T2, T1, TReturn>,
		IWith<T1, TReturn>
	{
		public Match(Tuple<Type, object> value) : base(value)
		{
		}
	}
}