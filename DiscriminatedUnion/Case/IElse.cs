namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// This Matches Everything Else
	/// </summary>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface IElse<TReturn>
	{
		/// <summary>
		/// This Matches Everything Else
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		TReturn Else(Func<TReturn> func);
	}
}