namespace DiscriminatedUnion
{
	using System;

	public class Union<T1> : IUnion
	{
		private readonly Tuple<Type, object> Value;

		public Union(T1 value)
		{
			this.Value = Tuple.Create(typeof(T1), (object)value);
		}

		public static implicit operator Union<T1>(T1 item)
		{
			return new Union<T1>(item);
		}

		public IWith<T1, TReturn> Match<TReturn>() => new Match<T1, TReturn>(Value);
	}
}