using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminatedUnion.Option
{
	public struct None
	{
	}

	/// <summary>
	/// Option is a special case of Union.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Option<T> : Union<T>
	{
		public static Option<TSome> Some<TSome>(TSome value) => new Option<TSome>(value);

		public static Option<TSome> None<TSome>() => new Option<TSome>();

		public Option(T value) : base(value)
		{
		}

		/// <summary>
		/// Performs an implicit conversion from <see cref="T1" /> to <see cref="Union{T1}" />.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Option<T>(T item)
		{
			return item == null ? new Option<T>() : new Option<T>(item);
		}

		public Option() : base(new TypedContainer<None>(new None()))
		{
		}
	}
}