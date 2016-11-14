namespace DiscriminatedUnion
{
	/// <summary>
	/// Value Container Interface
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="DiscriminatedUnion.ITypeContainer" />
	public interface IValueContainer<T> : ITypeContainer
	{
		T ContainedValue { get; }
	}
}