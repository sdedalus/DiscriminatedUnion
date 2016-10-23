namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Nice ways to work with a Union type.
	/// </summary>
	public static partial class UnionExtensions
	{
		/// <summary>
		/// Returns the specified value.  This is silly but cleans up the code.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="unit">The unit.</param>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static T Return<T>(this Unit unit, T value) => value;

		/// <summary>
		/// To the error union.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Err">The type of the rr.</typeparam>
		/// <param name="factory">The factory.</param>
		/// <returns></returns>
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

		/// <summary>
		/// To the error union.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="Err1">The type of the RR1.</typeparam>
		/// <typeparam name="Err2">The type of the RR2.</typeparam>
		/// <param name="factory">The factory.</param>
		/// <returns></returns>
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

		/// <summary>
		/// To the error union.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="factory">The factory.</param>
		/// <returns></returns>
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