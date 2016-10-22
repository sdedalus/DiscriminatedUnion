namespace DiscriminatedUnion
{
	using System;

	public class MatchBase<TReturn> : IMatchIng<TReturn>, IElse<TReturn>
	{
		internal TReturn returnValue;
		internal readonly Tuple<Type, object> value;
		private bool matched = false;

		public MatchBase(Tuple<Type, object> value)
		{
			this.value = value;
		}

		TReturn IElse<TReturn>.Else(Func<TReturn> func)
		{
			return matched ? returnValue : func();
		}

		Unit IMatchIng<TReturn>.SetReturnIfMatch<T>(Func<T, TReturn> func)
		{
			if (!matched && value.Item1 == typeof(T))
			{
				returnValue = func((T)value.Item2);
				matched = true;
			}

			return Unit.Default;
		}

		Unit IMatchIng<TReturn>.SetReturnIfMatch<T>(Func<T, bool> condition, Func<T, TReturn> func)
		{
			if (!matched && value.Item1 == typeof(T) && condition((T)value.Item2))
			{
				returnValue = func((T)value.Item2);
				matched = true;
			}

			return Unit.Default;
		}
	}
}