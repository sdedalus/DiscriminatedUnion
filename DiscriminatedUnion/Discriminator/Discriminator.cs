using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminatedUnion
{
	public static class Discriminator
	{
		public static TTag Tag<TTag, T>(T value) where TTag : Tag<TTag, T>, new()
		{
			var disc = new TTag() { Value = value };//(TTag)Activator.CreateInstance(typeof(TTag), value);
			if (disc.Validate(value))
			{
				return disc;
			}

			throw new ArgumentException("Value did not pass validation.");
		}

		public static TTag Tag<TTag>(string value) where TTag : Tag<TTag, string>, new()
		{
			return Tag<TTag, string>(value);
		}

		public static TTag Tag<TTag>(int value) where TTag : Tag<TTag, int>, new()
		{
			return Tag<TTag, int>(value);
		}

		public static TTag Tag<TTag>(long value) where TTag : Tag<TTag, long>, new()
		{
			return Tag<TTag, long>(value);
		}

		public static TTag Tag<TTag>(DateTime value) where TTag : Tag<TTag, DateTime>, new()
		{
			return Tag<TTag, DateTime>(value);
		}

		public static TTag Tag<TTag>(DateTimeOffset value) where TTag : Tag<TTag, DateTimeOffset>, new()
		{
			return Tag<TTag, DateTimeOffset>(value);
		}

		public static TTag Tag<TTag>(float value) where TTag : Tag<TTag, float>, new()
		{
			return Tag<TTag, float>(value);
		}

		public static TTag Tag<TTag>(decimal value) where TTag : Tag<TTag, decimal>, new()
		{
			return Tag<TTag, decimal>(value);
		}

		public static TTag Tag<TTag>(short value) where TTag : Tag<TTag, short>, new()
		{
			return Tag<TTag, short>(value);
		}

		public static TTag Tag<TTag>(object value) where TTag : Tag<TTag, object>, new()
		{
			return Tag<TTag, object>(value);
		}

		public static TTag Tag<TTag>(sbyte value) where TTag : Tag<TTag, sbyte>, new()
		{
			return Tag<TTag, sbyte>(value);
		}

		public static TTag Tag<TTag>(TimeSpan value) where TTag : Tag<TTag, TimeSpan>, new()
		{
			return Tag<TTag, TimeSpan>(value);
		}

		public static TTag Tag<TTag>(uint value) where TTag : Tag<TTag, uint>, new()
		{
			return Tag<TTag, uint>(value);
		}

		public static TTag Tag<TTag>(ulong value) where TTag : Tag<TTag, ulong>, new()
		{
			return Tag<TTag, ulong>(value);
		}

		public static TTag Tag<TTag>(ushort value) where TTag : Tag<TTag, ushort>, new()
		{
			return Tag<TTag, ushort>(value);
		}

		public static TTag Tag<TTag>(Uri value) where TTag : Tag<TTag, object>, new()
		{
			return Tag<TTag, object>(value);
		}
	}
}