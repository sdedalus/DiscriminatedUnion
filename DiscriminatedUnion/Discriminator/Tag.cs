using System;

namespace DiscriminatedUnion
{
	/// <summary>
	///
	/// </summary>
	/// <typeparam name="TTag">The type of the tag.</typeparam>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	public abstract class Tag<TTag, T1> : TagBase where TTag : Tag<TTag, T1>
	{
		/// <summary>
		/// The value
		/// </summary>
		private readonly T1 value;

		public T1 Value
		{
			get
			{
				return value;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Tag{TTag, T1}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		protected Tag(T1 value)
		{
			this.value = value;
		}

		/// <summary>
		/// Validates the specified input value.
		/// </summary>
		/// <param name="inputValue">The input value.</param>
		/// <returns></returns>
		public override bool Validate(object inputValue) => this.Validate((T1)value);

		/// <summary>
		/// Validates the specified input value.
		/// </summary>
		/// <param name="inputValue">The input value.</param>
		/// <returns></returns>
		public bool Validate(T1 inputValue) => true;

		/// <summary>
		/// Performs an implicit conversion from <see cref="Tag{TTag, T1}"/> to <see cref="T1"/>.
		/// </summary>
		/// <param name="v">The v.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator T1(Tag<TTag, T1> v)
		{
			return v.value;
		}

		/// <summary>
		/// Implements the operator ==.
		/// </summary>
		/// <param name="a">a.</param>
		/// <param name="b">The b.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator ==(Tag<TTag, T1> a, Tag<TTag, T1> b)
		{
			if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
			{
				return true;
			}

			if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
			{
				return false;
			}

			return a.value.Equals(b.value);
		}

		/// <summary>
		/// Implements the operator !=.
		/// </summary>
		/// <param name="a">a.</param>
		/// <param name="b">The b.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator !=(Tag<TTag, T1> a, Tag<TTag, T1> b)
		{
			return !(a == b);
		}

		/// <summary>
		/// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
		/// <returns>
		///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj)
		{
			var discriminator = (Tag<TTag, T1>)obj;
			T1 v;

			if (discriminator != null)
			{
				v = discriminator.value;
			}

			v = (T1)obj;

			return v.Equals(this.value);
		}

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return this.value.ToString();
		}

		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}
	}
}