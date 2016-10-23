namespace DiscriminatedUnion
{
	using System;

	/// <summary>
	/// Two Item Union.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <seealso cref="DiscriminatedUnion.IUnion" />
	public class Union<T1, T2> : IUnion
	{
		private readonly ITypedContainer Value;

		public Union(T1 value)
		{
			this.Value = new TypedContainer<T1>(value);
		}

		public Union(T2 value)
		{
			this.Value = new TypedContainer<T2>(value);
		}

		public static implicit operator Union<T1, T2>(T1 item)
		{
			return new Union<T1, T2>(item);
		}

		public static implicit operator Union<T1, T2>(T2 item)
		{
			return new Union<T1, T2>(item);
		}

		public IWith<T1, T2, TReturn> Match<TReturn>() => new Match<T1, T2, TReturn>(Value);
	}
}