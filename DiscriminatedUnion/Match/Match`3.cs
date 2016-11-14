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
	/// <seealso cref="DiscriminatedUnion.ICase{T3, T2, T1, TReturn}" />
	/// <seealso cref="DiscriminatedUnion.ICase{T2, T1, TReturn}" />
	/// <seealso cref="DiscriminatedUnion.ICase{T1, TReturn}" />
	public class Match<T3, T2, T1, TReturn> :
		Match<T2, T1, TReturn>,
		ICase<T3, T2, T1, TReturn>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Match{T3, T2, T1, TReturn}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Match(ITypeContainer value) : base(value)
		{
		}

		/// <summary>
		/// Cases the specified function.
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T2, T1, TReturn> ICase<T3, T2, T1, TReturn>.Case(Func<T3, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		/// <summary>
		/// Cases the specified condition.
		/// </summary>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T3, T2, T1, TReturn> ICase<T3, T2, T1, TReturn>.Case(Func<T3, bool> condition, Func<T3, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}
}