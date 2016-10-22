namespace DiscriminatedUnion
{
	using System;

	public class Union<T1, T2> : IUnion
	{
		private readonly Tuple<Type, object> Value;

		public Union(T1 value)
		{
			this.Value = Tuple.Create(typeof(T1), (object)value);
		}

		public Union(T2 value)
		{
			this.Value = Tuple.Create(typeof(T2), (object)value);
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