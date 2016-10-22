namespace DiscriminatedUnion
{
	using System;

	public interface IMatchIng<TReturn>
	{
		Unit SetReturnIfMatch<T>(Func<T, TReturn> func);

		Unit SetReturnIfMatch<T>(Func<T, bool> condition, Func<T, TReturn> func);
	}
}