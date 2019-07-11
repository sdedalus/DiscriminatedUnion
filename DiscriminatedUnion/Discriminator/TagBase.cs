using System;

namespace DiscriminatedUnion
{
	public abstract class TagBase
	{
		public abstract bool Validate(object inputValue);
	}
}