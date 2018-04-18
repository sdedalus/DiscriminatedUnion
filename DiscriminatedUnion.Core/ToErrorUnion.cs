namespace DiscriminatedUnion
{
	using System;
	/// <summary>
	/// Nice ways to work with a Union type.
	/// </summary>
	public static partial class Union
	{
		public static Union<T, TErr1> ToErrorUnion<T, TErr1>(this Func<T> factory)
		where TErr1 : Exception
		{
			try
			{
				return new Union<T, TErr1>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1>(ex); }
		}
		public static Union<T, TErr1,TErr2> ToErrorUnion<T, TErr1,TErr2>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3> ToErrorUnion<T, TErr1,TErr2,TErr3>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
			where TErr10 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
			catch ( TErr10 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
			where TErr10 : Exception
			where TErr11 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr10 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
			catch ( TErr11 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
			where TErr10 : Exception
			where TErr11 : Exception
			where TErr12 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr10 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr11 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
			catch ( TErr12 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
			where TErr10 : Exception
			where TErr11 : Exception
			where TErr12 : Exception
			where TErr13 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr10 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr11 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr12 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
			catch ( TErr13 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
			where TErr10 : Exception
			where TErr11 : Exception
			where TErr12 : Exception
			where TErr13 : Exception
			where TErr14 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr10 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr11 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr12 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr13 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
			catch ( TErr14 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14>(ex); }
		}
		public static Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15> ToErrorUnion<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(this Func<T> factory)
		where TErr1 : Exception
			where TErr2 : Exception
			where TErr3 : Exception
			where TErr4 : Exception
			where TErr5 : Exception
			where TErr6 : Exception
			where TErr7 : Exception
			where TErr8 : Exception
			where TErr9 : Exception
			where TErr10 : Exception
			where TErr11 : Exception
			where TErr12 : Exception
			where TErr13 : Exception
			where TErr14 : Exception
			where TErr15 : Exception
		{
			try
			{
				return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(factory());
			}
			catch ( TErr1 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr2 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr3 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr4 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr5 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr6 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr7 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr8 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr9 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr10 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr11 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr12 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr13 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr14 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
			catch ( TErr15 ex) { return new Union<T, TErr1,TErr2,TErr3,TErr4,TErr5,TErr6,TErr7,TErr8,TErr9,TErr10,TErr11,TErr12,TErr13,TErr14,TErr15>(ex); }
		}
	}
}