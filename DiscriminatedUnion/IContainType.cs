namespace DiscriminatedUnion
{
	public interface IContainType<T> : ITypedContainer
	{
		T ContainedValue { get; }
	}
}