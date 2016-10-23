namespace DiscriminatedUnion
{
	/// <summary>
	/// The extension methods that check the second type bind to this interface.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface IWith<T1, T2, TReturn> : IElse<TReturn>
	{
	}
}