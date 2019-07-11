using System;
namespace DiscriminatedUnion
{
	public class Match<T1, TReturn> : MatchBase<TReturn>
		, ICase<T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		IDefault<TReturn> ICase<T1, TReturn>.Case(Func<T1, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T1, TReturn> ICase<T1, TReturn>.Case(Func<T1, bool> condition, Func<T1, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T2,T1, TReturn> : Match<T1,TReturn>
		, ICase<T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T1,TReturn> ICase<T2,T1, TReturn>.Case(Func<T2, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T2,T1, TReturn> ICase<T2,T1, TReturn>.Case(Func<T2, bool> condition, Func<T2, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T3,T2,T1, TReturn> : Match<T2,T1,TReturn>
		, ICase<T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T2,T1,TReturn> ICase<T3,T2,T1, TReturn>.Case(Func<T3, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T3,T2,T1, TReturn> ICase<T3,T2,T1, TReturn>.Case(Func<T3, bool> condition, Func<T3, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T4,T3,T2,T1, TReturn> : Match<T3,T2,T1,TReturn>
		, ICase<T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T3,T2,T1,TReturn> ICase<T4,T3,T2,T1, TReturn>.Case(Func<T4, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T4,T3,T2,T1, TReturn> ICase<T4,T3,T2,T1, TReturn>.Case(Func<T4, bool> condition, Func<T4, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T5,T4,T3,T2,T1, TReturn> : Match<T4,T3,T2,T1,TReturn>
		, ICase<T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T4,T3,T2,T1,TReturn> ICase<T5,T4,T3,T2,T1, TReturn>.Case(Func<T5, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T5,T4,T3,T2,T1, TReturn> ICase<T5,T4,T3,T2,T1, TReturn>.Case(Func<T5, bool> condition, Func<T5, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T6,T5,T4,T3,T2,T1, TReturn> : Match<T5,T4,T3,T2,T1,TReturn>
		, ICase<T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T5,T4,T3,T2,T1,TReturn> ICase<T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T6, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T6,T5,T4,T3,T2,T1, TReturn> ICase<T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T6, bool> condition, Func<T6, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T6,T5,T4,T3,T2,T1,TReturn> ICase<T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T7, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T7, bool> condition, Func<T7, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T8, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T8, bool> condition, Func<T8, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T9, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T9, bool> condition, Func<T9, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T10, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T10, bool> condition, Func<T10, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T11, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T11, bool> condition, Func<T11, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T12, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T12, bool> condition, Func<T12, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T13, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T13, bool> condition, Func<T13, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T14, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T14, bool> condition, Func<T14, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T15, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T15, bool> condition, Func<T15, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

	public class Match<T16,T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> : Match<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn>
		, ICase<T16,T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>
	{
		public Match(ITypeContainer value) : base(value)
		{
		}

		ICase<T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1,TReturn> ICase<T16,T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T16, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(func).Return(this);
		}

		ICase<T16,T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn> ICase<T16,T15,T14,T13,T12,T11,T10,T9,T8,T7,T6,T5,T4,T3,T2,T1, TReturn>.Case(Func<T16, bool> condition, Func<T16, TReturn> func)
		{
			return ((IMatchIng<TReturn>)this).SetReturnIfMatch(condition, func).Return(this);
		}
	}

}