namespace DiscriminatedUnion
{
	/// <summary>
	/// The extension methods that check the sixth type bind to this interface.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="T3">The type of the 3.</typeparam>
	/// <typeparam name="T4">The type of the 4.</typeparam>
	/// <typeparam name="T5">The type of the 5.</typeparam>
	/// <typeparam name="T6">The type of the 6.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface IWith<T1, T2, T3, T4, T5, T6, TReturn> : IElse<TReturn>
	{
	}
}