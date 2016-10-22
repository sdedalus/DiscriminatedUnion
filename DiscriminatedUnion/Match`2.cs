namespace DiscriminatedUnion
{
	using System;

	public class Match<T2, T1, TReturn> :
		MatchBase<TReturn>,
		IWith<T2, T1, TReturn>,
		IWith<T1, TReturn>
	{
		public Match(Tuple<Type, object> value) : base(value)
		{
		}
	}
}