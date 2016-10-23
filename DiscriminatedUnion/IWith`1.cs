namespace DiscriminatedUnion
{
	/// <summary>
	/// The extension methods that check the first type bind to this interface.
	/// </summary>
	/// <typeparam name="T1">Type one.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface IWith<T1, TReturn> : IElse<TReturn>
	{
	}
}