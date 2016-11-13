namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// One Item Union.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <seealso cref="DiscriminatedUnion.UnionBase" />
	public class Union<T1> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T1"/> to <see cref="Union{T1}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1>(T1 item)
		{
			return new Union<T1>(item);
		}

		/// <summary>
		/// Matches this instance.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <returns></returns>
		public ICase<T1, TReturn> Match<TReturn>() => new Match<T1, TReturn>(value);
	}
}