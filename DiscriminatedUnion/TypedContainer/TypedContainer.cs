﻿namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Avoids Boxing at the cost of one time object creation;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="DiscriminatedUnion.ITypeContainer" />
	/// <seealso cref="DiscriminatedUnion.IValueContainer{T}" />
	public struct Container<T> : ITypeContainer, IValueContainer<T>
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
		/// Initializes a new instance of the <see cref="Container{T}"/> class.
		/// </summary>
		/// <param name="contained">The contained.</param>
		public Container(T contained)
		{
			this.ContainedValueType = typeof(T);
			this.ContainedValue = contained;
		}

		public static implicit operator Container<T>(T value)
		{
			return new Container<T>(value);
		}

		public static explicit operator T(Container<T> value)
		{
			return value.ContainedValue;
		}

		/// <summary>
		/// To the type of the contained value.
		/// </summary>
		/// <typeparam name="T1">The type of the 1.</typeparam>
		/// <returns></returns>
		public IValueContainer<T1> ToContainedType<T1>() => this as IValueContainer<T1>;

		/// <summary>
		/// Gets the value as object.
		/// [Warning] May trigger boxing conditions.  use sparingly.
		/// </summary>
		/// <value>
		/// The value as object.
		/// </value>
		public object ValueAsObject => ContainedValue;

		public override string ToString() => ContainedValue.ToString();
	}
}