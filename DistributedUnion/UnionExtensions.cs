namespace DiscriminatedUnion
{
	using System;

	public static partial class UnionExtensions
	{
		public static T Return<T>(this Unit unit, T value) => value;

		public static Union<T, Err> ToErrorUnion<T, Err>(this Func<T> factory)
			where Err : SystemException
		{
			try
			{
				return new Union<T, Err>(factory());
			}
			catch (Err ex)
			{
				return new Union<T, Err>(ex);
			}
		}

		public static Union<T, Err1, Err2> ToErrorUnion<T, Err1, Err2>(this Func<T> factory)
		where Err1 : SystemException
		where Err2 : SystemException
		{
			try
			{
				return new Union<T, Err1, Err2>(factory());
			}
			catch (Err1 ex)
			{
				return new Union<T, Err1, Err2>(ex);
			}
			catch (Err2 ex)
			{
				return new Union<T, Err1, Err2>(ex);
			}
		}

		public static Union<T, SystemException> ToErrorUnion<T>(this Func<T> factory)
		{
			try
			{
				return new Union<T, SystemException>(factory());
			}
			catch (SystemException ex)
			{
				return new Union<T, SystemException>(ex);
			}
		}
	}
}