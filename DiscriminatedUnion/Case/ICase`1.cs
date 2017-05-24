using System;

namespace DiscriminatedUnion
{
	/// <summary>
	/// The extension methods that check the first type bind to this interface.
	/// </summary>
	/// <typeparam name="T1">Type one.</typeparam>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface ICase<T1, TReturn> : IDefault<TReturn>
	{
		/// <summary>
		/// Cases the specified function.
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		IDefault<TReturn> Case(Func<T1, TReturn> func);

		/// <summary>
		/// Cases the specified condition.
		/// </summary>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		ICase<T1, TReturn> Case(Func<T1, bool> condition, Func<T1, TReturn> func);
	}
}