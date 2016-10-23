namespace DiscriminatedUnion
{
	using System;

	public class TypedContainer<T> : ITypedContainer
	{
		public Type ContainedType { get; }
		public T ContainedValue { get; }

		public TypedContainer(T contained)
		{
			this.ContainedType = typeof(T);
			this.ContainedValue = contained;
		}
	}
}