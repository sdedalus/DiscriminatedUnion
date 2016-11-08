namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// A single item match.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	/// <seealso cref="DiscriminatedUnion.MatchBase{TReturn}" />
	/// <seealso cref="DiscriminatedUnion.ICase{T1, TReturn}" />
	public class Match<T1, TReturn> :
		MatchBase<TReturn>, IMatchIng<TReturn>,
		ICase<T1, TReturn>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Match{T1, TReturn}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Match(ITypeContainer value) : base(value)
		{
		}

		IElse<TReturn> ICase<T1, TReturn>.Case(Func<T1, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T1, TReturn> ICase<T1, TReturn>.Case(Func<T1, bool> condition, Func<T1, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}
}