namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// This Matches Everything Default
	/// </summary>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface IDefault<TReturn>
	{
		/// <summary>
		/// This Matches Everything Default
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		TReturn Default(Func<TReturn> func);
	}
}