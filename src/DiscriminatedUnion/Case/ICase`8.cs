using System;

namespace DiscriminatedUnion
{
	/// <summary>
	/// The extension methods that check the eighth type bind to this interface.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <typeparam name="T3">The type of the 3.</typeparam>
	/// <typeparam name="T4">The type of the 4.</typeparam>
	/// <typeparam name="T5">The type of the 5.</typeparam>
	/// <typeparam name="T6">The type of the 6.</typeparam>
	/// <typeparam name="T7">The type of the 7.</typeparam>
	/// <typeparam name="T8">The type of the 8.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface ICase<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> : IDefault<TReturn>
	{
		/// <summary>
		/// Cases the specified function.
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T7, T6, T5, T4, T3, T2, T1, TReturn> Case(Func<T8, TReturn> func);

		/// <summary>
		/// Cases the specified condition.
		/// </summary>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T8, T7, T6, T5, T4, T3, T2, T1, TReturn> Case(Func<T8, bool> condition, Func<T8, TReturn> func);
	}
}