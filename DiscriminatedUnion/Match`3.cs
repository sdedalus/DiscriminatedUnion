namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// A three item match.
	/// </summary>
	/// <typeparam name="T3">The type of the 3.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	/// <seealso cref="DiscriminatedUnion.MatchBase{TReturn}" />
	/// <seealso cref="DiscriminatedUnion.IWith{T3, T2, T1, TReturn}" />
	/// <seealso cref="DiscriminatedUnion.IWith{T2, T1, TReturn}" />
	/// <seealso cref="DiscriminatedUnion.IWith{T1, TReturn}" />
	public class Match<T3, T2, T1, TReturn> :
		MatchBase<TReturn>,
		IWith<T3, T2, T1, TReturn>,
		IWith<T2, T1, TReturn>,
		IWith<T1, TReturn>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Match{T3, T2, T1, TReturn}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Match(ITypedContainer value) : base(value)
		{
		}
	}
}