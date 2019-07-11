namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// This is the base class for all of the matches.
	/// </summary>
	/// <typeparam name="TReturn">The type of the return.</typeparam>
	/// <seealso cref="DiscriminatedUnion.IMatchIng{TReturn}" />
	/// <seealso cref="IDefault{TReturn}" />
	public class MatchBase<TReturn> : IMatchIng<TReturn>, IDefault<TReturn>
	{
		/// <summary>
		/// The return value
		/// </summary>
		internal TReturn returnValue;

		/// <summary>
		/// The value
		/// </summary>
		internal readonly ITypeContainer value;

		/// <summary>
		/// The matched
		/// </summary>
		private bool matched = false;

		/// <summary>
		/// Initializes a new instance of the <see cref="MatchBase{TReturn}"/> class.
		/// </summary>
		/// <param name="value">The value.</param>
		public MatchBase(ITypeContainer value)
		{
			this.value = value;
		}

		/// <summary>
		/// This Matches Everything Default
		/// </summary>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		TReturn IDefault<TReturn>.Default(Func<TReturn> func)
		{
			return matched ? returnValue : func();
		}

		/// <summary>
		/// Sets the return if match.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		Unit IMatchIng<TReturn>.SetReturnIfMatch<T>(Func<T, TReturn> func)
		{
			if (!matched && value.ContainedValueType == typeof(T))
			{
				returnValue = func(value.ToContainedType<T>().ContainedValue);
				matched = true;
			}

			return Unit.Default;
		}

		/// <summary>
		/// Sets the return if match.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="condition">The condition.</param>
		/// <param name="func">The function.</param>
		/// <returns></returns>
		Unit IMatchIng<TReturn>.SetReturnIfMatch<T>(Func<T, bool> condition, Func<T, TReturn> func)
		{
			if (!matched && value.ContainedValueType == typeof(T) && condition(((Container<T>)value).ContainedValue))
			{
				returnValue = func(value.ToContainedType<T>().ContainedValue);
				matched = true;
			}

			return Unit.Default;
		}
	}
}