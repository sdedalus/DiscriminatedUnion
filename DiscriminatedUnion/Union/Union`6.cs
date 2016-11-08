﻿namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Six Item Union.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="T3">The type of the 3.</typeparam>
	/// <typeparam name="T4">The type of the 4.</typeparam>
	/// <typeparam name="T5">The type of the 5.</typeparam>
	/// <typeparam name="T6">The type of the 6.</typeparam>
	/// <seealso cref="DiscriminatedUnion.UnionBase" />
	public class Union<T1, T2, T3, T4, T5, T6> : UnionBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3, T4, T5, T6}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3, T4, T5, T6}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3, T4, T5, T6}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3, T4, T5, T6}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3, T4, T5, T6}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Union{T1, T2, T3, T4, T5, T6}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T1"/> to <see cref="Union{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T1 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T2"/> to <see cref="Union{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T2 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T3"/> to <see cref="Union{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T3 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T4"/> to <see cref="Union{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T4 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T5"/> to <see cref="Union{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T5 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6>(item);
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T6"/> to <see cref="Union{T1, T2, T3, T4, T5, T6}"/>.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Union<T1, T2, T3, T4, T5, T6>(T6 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6>(item);
		}

		/// <summary>
		/// Matches this instance.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <returns></returns>
		public ICase<T1, T2, T3, T4, T5, T6, TReturn> Match<TReturn>() => new Match<T1, T2, T3, T4, T5, T6, TReturn>(value);
	}
}