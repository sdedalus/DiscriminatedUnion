using System;

namespace DiscriminatedUnion
{
	/// <summary>
	/// This Marks a class as a Union type. This is here as a extension method target
	/// </summary>
	public class UnionBase : IUnion
	{
		/// <summary>
		/// The value
		/// </summary>
		protected readonly ITypeContainer Value;

		/// <summary>
		/// Initializes a new instance of the <see cref="UnionBase"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		protected UnionBase(ITypeContainer value)
		{
			this.Value = value;
		}

		/// <summary>
		/// Gets the value container.
		/// </summary>
		/// <value>
		/// The value container.
		/// </value>
		public ITypeContainer ValueContainer => Value;

		/// <summary>
		/// Determines whether [is].
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>
		///   <c>true</c> if [is]; otherwise, <c>false</c>.
		/// </returns>
		public bool Is<T>() => typeof(T) == Value.ContainedValueType;

		public bool Is<T>(out T ret)
		{
			var isType = typeof(T) == Value.ContainedValueType;
			
			ret = isType ? ((IValueContainer<T>) Value).ContainedValue : default(T);
			return isType;

		}

		/// <summary>
		/// Determines whether [is] [the specified proposed type].
		/// </summary>
		/// <param name="proposedType">Type of the proposed.</param>
		/// <returns>
		///   <c>true</c> if [is] [the specified proposed type]; otherwise, <c>false</c>.
		/// </returns>
		public bool Is(Type proposedType) => proposedType == Value.ContainedValueType;
	}
}