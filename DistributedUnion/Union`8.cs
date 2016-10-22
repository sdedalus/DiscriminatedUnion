namespace DiscriminatedUnion
{
	using System;

	public class Union<T1, T2, T3, T4, T5, T6, T7, T8> : IUnion
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

		public Union(T3 value)
		{
			this.Value = Tuple.Create(typeof(T3), (object)value);
		}

		public Union(T4 value)
		{
			this.Value = Tuple.Create(typeof(T4), (object)value);
		}

		public Union(T5 value)
		{
			this.Value = Tuple.Create(typeof(T5), (object)value);
		}

		public Union(T6 value)
		{
			this.Value = Tuple.Create(typeof(T6), (object)value);
		}

		public Union(T7 value)
		{
			this.Value = Tuple.Create(typeof(T7), (object)value);
		}

		public Union(T8 value)
		{
			this.Value = Tuple.Create(typeof(T8), (object)value);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T2 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T3 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T4 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T5 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T6 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T7 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8>(T8 item)
		{
			return new Union<T1, T2, T3, T4, T5, T6, T7, T8>(item);
		}

		public IWith<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> Match<TReturn>() => new Match<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(Value);
	}
}