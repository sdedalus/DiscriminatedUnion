namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// The Base interface of our match type.  These are the functions you should implement for a match to work.
	/// </summary>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	public interface IMatchIng<TReturn>
	{
		Unit SetReturnIfMatch<T>(Func<T, TReturn> func);

		Unit SetReturnIfMatch<T>(Func<T, bool> condition, Func<T, TReturn> func);
	}

	//public interface IMatchIng<T, TReturn>
	//{
	//	Unit SetReturnIfMatch(Func<T, TReturn> func);

	//	Unit SetReturnIfMatch(Func<T, bool> condition, Func<T, TReturn> func);
	//}
}