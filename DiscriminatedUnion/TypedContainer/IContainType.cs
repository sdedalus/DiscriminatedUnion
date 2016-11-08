namespace DiscriminatedUnion
{
	public interface IValueContainer<T> : ITypeContainer
	{
		T ContainedValue { get; }
	}
}