﻿namespace DiscriminatedUnion
{
//T1 
	public class Union<T1> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1>(T1 item)
		{
			return new Union<T1>(item);
		}
		
		public ICase<T1, TReturn> Match<TReturn>() => new Match<T1, TReturn>(Value);

		public ICase<T1, Union<T1>> Match() => new Match<T1, Union<T1>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2 
	public class Union<T1,T2> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2>(T1 item)
		{
			return new Union<T1,T2>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2>(T2 item)
		{
			return new Union<T1,T2>(item);
		}
		
		public ICase<T1,T2, TReturn> Match<TReturn>() => new Match<T1,T2, TReturn>(Value);

		public ICase<T1,T2, Union<T1,T2>> Match() => new Match<T1,T2, Union<T1,T2>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3 
	public class Union<T1,T2,T3> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3>(T1 item)
		{
			return new Union<T1,T2,T3>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3>(T2 item)
		{
			return new Union<T1,T2,T3>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3>(T3 item)
		{
			return new Union<T1,T2,T3>(item);
		}
		
		public ICase<T1,T2,T3, TReturn> Match<TReturn>() => new Match<T1,T2,T3, TReturn>(Value);

		public ICase<T1,T2,T3, Union<T1,T2,T3>> Match() => new Match<T1,T2,T3, Union<T1,T2,T3>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4 
	public class Union<T1,T2,T3,T4> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4>(T1 item)
		{
			return new Union<T1,T2,T3,T4>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4>(T2 item)
		{
			return new Union<T1,T2,T3,T4>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4>(T3 item)
		{
			return new Union<T1,T2,T3,T4>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4>(T4 item)
		{
			return new Union<T1,T2,T3,T4>(item);
		}
		
		public ICase<T1,T2,T3,T4, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4, TReturn>(Value);

		public ICase<T1,T2,T3,T4, Union<T1,T2,T3,T4>> Match() => new Match<T1,T2,T3,T4, Union<T1,T2,T3,T4>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5 
	public class Union<T1,T2,T3,T4,T5> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5, Union<T1,T2,T3,T4,T5>> Match() => new Match<T1,T2,T3,T4,T5, Union<T1,T2,T3,T4,T5>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6 
	public class Union<T1,T2,T3,T4,T5,T6> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6, Union<T1,T2,T3,T4,T5,T6>> Match() => new Match<T1,T2,T3,T4,T5,T6, Union<T1,T2,T3,T4,T5,T6>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7 
	public class Union<T1,T2,T3,T4,T5,T6,T7> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7, Union<T1,T2,T3,T4,T5,T6,T7>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7, Union<T1,T2,T3,T4,T5,T6,T7>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8, Union<T1,T2,T3,T4,T5,T6,T7,T8>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8, Union<T1,T2,T3,T4,T5,T6,T7,T8>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9,T10 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public Union(T11 value) : base(new TypedContainer<T11>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(T11 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T11 value) : base(new TypedContainer<T11>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T11 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public Union(T12 value) : base(new TypedContainer<T12>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(T12 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T11 value) : base(new TypedContainer<T11>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T11 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T12 value) : base(new TypedContainer<T12>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T12 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public Union(T13 value) : base(new TypedContainer<T13>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(T13 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T11 value) : base(new TypedContainer<T11>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T11 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T12 value) : base(new TypedContainer<T12>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T12 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T13 value) : base(new TypedContainer<T13>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T13 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public Union(T14 value) : base(new TypedContainer<T14>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(T14 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


//T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15 
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}

		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T11 value) : base(new TypedContainer<T11>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T11 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T12 value) : base(new TypedContainer<T12>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T12 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T13 value) : base(new TypedContainer<T13>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T13 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T14 value) : base(new TypedContainer<T14>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T14 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public Union(T15 value) : base(new TypedContainer<T15>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(T15 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}


// T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16
	public class Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> : UnionBase
	{
		public Union(ITypeContainer value) : base(value)
		{ 
		}
		
		public Union(T1 value) : base(new TypedContainer<T1>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T1 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T2 value) : base(new TypedContainer<T2>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T2 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T3 value) : base(new TypedContainer<T3>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T3 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T4 value) : base(new TypedContainer<T4>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T4 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T5 value) : base(new TypedContainer<T5>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T5 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T6 value) : base(new TypedContainer<T6>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T6 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T7 value) : base(new TypedContainer<T7>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T7 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T8 value) : base(new TypedContainer<T8>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T8 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T9 value) : base(new TypedContainer<T9>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T9 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T10 value) : base(new TypedContainer<T10>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T10 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T11 value) : base(new TypedContainer<T11>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T11 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T12 value) : base(new TypedContainer<T12>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T12 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T13 value) : base(new TypedContainer<T13>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T13 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T14 value) : base(new TypedContainer<T14>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T14 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T15 value) : base(new TypedContainer<T15>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T15 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public Union(T16 value) : base(new TypedContainer<T16>(value))
		{
		}

		public static implicit operator Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(T16 item)
		{
			return new Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(item);
		}
		
		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TReturn> Match<TReturn>() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TReturn>(Value);

		public ICase<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>> Match() => new Match<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, Union<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>>(Value);

		public override string ToString()
		{
			return base.ToString();
		}
	}

}