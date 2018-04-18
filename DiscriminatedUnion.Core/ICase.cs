
using System;
namespace DiscriminatedUnion
{	public interface ICase<out T1, TReturn> : IDefault<TReturn>
	{
		IDefault<TReturn> Case(Func<T1, TReturn> func);

		ICase<T1, TReturn> Case(Func<T1, bool> condition, Func<T1, TReturn> func);
	}

	public interface ICase<out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T1,TReturn> Case(Func<T2, TReturn> func);

		ICase<T2,T1, TReturn> Case(Func<T2, bool> condition, Func<T2, TReturn> func);
	}

	public interface ICase<out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T2,T1,TReturn> Case(Func<T3, TReturn> func);

		ICase<T3,T2,T1, TReturn> Case(Func<T3, bool> condition, Func<T3, TReturn> func);
	}

	public interface ICase<out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T3,T2,T1,TReturn> Case(Func<T4, TReturn> func);

		ICase<T4,T3,T2,T1, TReturn> Case(Func<T4, bool> condition, Func<T4, TReturn> func);
	}

	public interface ICase<out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T4,T3,T2,T1,TReturn> Case(Func<T5, TReturn> func);

		ICase<T5,T4,T3,T2,T1, TReturn> Case(Func<T5, bool> condition, Func<T5, TReturn> func);
	}

	public interface ICase<out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T5,T4,T3,T2,T1,TReturn> Case(Func<T6, TReturn> func);

		ICase<T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T6, bool> condition, Func<T6, TReturn> func);
	}

	public interface ICase<out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T7, TReturn> func);

		ICase<T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T7, bool> condition, Func<T7, TReturn> func);
	}

	public interface ICase<out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T8, TReturn> func);

		ICase<T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T8, bool> condition, Func<T8, TReturn> func);
	}

	public interface ICase<out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T9, TReturn> func);

		ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T9, bool> condition, Func<T9, TReturn> func);
	}

	public interface ICase<out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T10, TReturn> func);

		ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T10, bool> condition, Func<T10, TReturn> func);
	}

	public interface ICase<out T11,out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T11, TReturn> func);

		ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T11, bool> condition, Func<T11, TReturn> func);
	}

	public interface ICase<out T12,out T11,out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T12, TReturn> func);

		ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T12, bool> condition, Func<T12, TReturn> func);
	}

	public interface ICase<out T13,out T12,out T11,out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T13, TReturn> func);

		ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T13, bool> condition, Func<T13, TReturn> func);
	}

	public interface ICase<out T14,out T13,out T12,out T11,out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T14, TReturn> func);

		ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T14, bool> condition, Func<T14, TReturn> func);
	}

	public interface ICase<out T15,out T14,out T13,out T12,out T11,out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T15, TReturn> func);

		ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T15, bool> condition, Func<T15, TReturn> func);
	}

	public interface ICase<out T16,out T15,out T14,out T13,out T12,out T11,out T10,out T9,out T8,out T7,out T6,out T5,out T4,out T3,out T2,out T1, TReturn> : IDefault<TReturn>
	{
		ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> Case(Func<T16, TReturn> func);

		ICase<T16,T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> Case(Func<T16, bool> condition, Func<T16, TReturn> func);
	}

}