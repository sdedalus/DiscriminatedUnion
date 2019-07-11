namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Nice ways to work with a Union type.
	/// </summary>
	public static partial class Union
	{
		private static Func<TSource, TDestination> Fun<TSource, TDestination>(Func<TSource, TDestination> fun)
		{
			return fun;
		}
	}
}