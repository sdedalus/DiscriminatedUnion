namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Avoids Boxing at the cost of one time object creation;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="DiscriminatedUnion.ITypeContainer" />
	/// <seealso cref="DiscriminatedUnion.IValueContainer{T}" />
	public class TypedContainer<T> : ITypeContainer, IValueContainer<T>
	{
		/// <summary>
		/// Gets the type of the contained.
		/// </summary>
		/// <value>
		/// The type of the contained.
		/// </value>
		public Type ContainedValueType { get; }

		/// <summary>
		/// Gets the contained value.
		/// </summary>
		/// <value>
		/// The contained value.
		/// </value>
		public T ContainedValue { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TypedContainer{T}"/> class.
		/// </summary>
		/// <param name="contained">The contained.</param>
		public TypedContainer(T contained)
		{
			this.ContainedValueType = typeof(T);
			this.ContainedValue = contained;
		}

		public IValueContainer<T1> ToContainedType<T1>()
		{
			return this as IValueContainer<T1>;
		}

		public object ValueAsObject => ContainedValue;
	}
}