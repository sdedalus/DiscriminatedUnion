﻿using System;

namespace DiscriminatedUnion
{
	/// <summary>
	/// This interface and it's contained type are used to avoid the use of object and boxing operations.
	/// </summary>
	public interface ITypeContainer
	{
		/// <summary>
		/// Gets the type of the contained value.
		/// </summary>
		/// <value>
		/// The type of the contained.
		/// </value>
		Type ContainedValueType { get; }

		IValueContainer<T> ToContainedType<T>();

		/// <summary>
		/// Gets the value as object.
		/// [Warning] May trigger boxing conditions.  use sparingly.
		/// </summary>
		/// <value>
		/// The value as object.
		/// </value>
		object ValueAsObject { get; }
	}
}