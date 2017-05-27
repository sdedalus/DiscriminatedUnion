namespace DiscriminatedUnion
{
	/// <summary>
	/// Two Item Union.
	/// </summary>
	/// <typeparam name="T1">The type of the 1.</typeparam>
	/// <typeparam name="T2">The type of the 2.</typeparam>
	/// <seealso cref="DiscriminatedUnion.UnionBase" />
	public class Union<T1, T2> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{
		}

		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1, T2>(T1 item)
		{
			return new Union<T1, T2>(item);
		}

		public static implicit operator Union<T1, T2>(T2 item)
		{
			return new Union<T1, T2>(item);
		}

		public ICase<T1, T2, TReturn> Match<TReturn>() => new Match<T1, T2, TReturn>(Value);
	}
}