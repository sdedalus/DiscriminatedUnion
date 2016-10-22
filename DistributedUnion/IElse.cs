namespace DiscriminatedUnion
{
	using System;

	public interface IElse<TReturn>
	{
		TReturn Else(Func<TReturn> func);
	}
}