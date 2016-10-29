namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Three Item Union.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="T3">The type of the 3.</typeparam>
	/// <seealso cref="DiscriminatedUnion.IUnion" />
	public class Union<T1, T2, T3> : IUnion
	{
		/// <summary>
		/// The value
		/// </summary>
		private readonly ITypeContainer Value;

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T1 value)
		{
			this.Value = new TypedContainer<T1>(value);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T2 value)
		{
			this.Value = new TypedContainer<T2>(value);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T3 value)
		{
			this.Value = new TypedContainer<T3>(value);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T1"/> to <see cref="Union{T1, T2, T3}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3>(T1 item)
		{
			return new Union<T1, T2, T3>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T2"/> to <see cref="Union{T1, T2, T3}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3>(T2 item)
		{
			return new Union<T1, T2, T3>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T3"/> to <see cref="Union{T1, T2, T3}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3>(T3 item)
		{
			return new Union<T1, T2, T3>(item);
		}

		public ICase<T1, T2, T3, TReturn> Match<TReturn>() => new Match<T1, T2, T3, TReturn>(Value);
	}
}