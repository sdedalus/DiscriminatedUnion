namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Avoids Boxing at the cost of one time object creation;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="DiscriminatedUnion.ITypedContainer" />
	/// <seealso cref="DiscriminatedUnion.IContainType{T}" />
	public class TypedContainer<T> : ITypedContainer, IContainType<T>
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

		public IContainType<T1> ToContainedType<T1>()
		{
			return this as IContainType<T1>;
		}
	}
}