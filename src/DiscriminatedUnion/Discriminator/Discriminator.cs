using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminatedUnion
{
	public static class Discriminator
	{
		public static TTag Tag<TTag, T>(T value) where TTag : Tag<TTag, T>
		{
			var disc = (TTag)Activator.CreateInstance(typeof(TTag), value);
			if (disc.Validate(value))
			{
				return disc;
			}

			throw new ArgumentException("Value did not pass validation.");
		}

		public static TTag Tag<TTag>(string value) where TTag : Tag<TTag, string>
		{
			return Tag<TTag, string>(value);
		}

		public static TTag Tag<TTag>(int value) where TTag : Tag<TTag, int>
		{
			return Tag<TTag, int>(value);
		}

		public static TTag Tag<TTag>(long value) where TTag : Tag<TTag, long>
		{
			return Tag<TTag, long>(value);
		}

		public static TTag Tag<TTag>(DateTime value) where TTag : Tag<TTag, DateTime>
		{
			return Tag<TTag, DateTime>(value);
		}

		public static TTag Tag<TTag>(DateTimeOffset value) where TTag : Tag<TTag, DateTimeOffset>
		{
			return Tag<TTag, DateTimeOffset>(value);
		}

		public static TTag Tag<TTag>(float value) where TTag : Tag<TTag, float>
		{
			return Tag<TTag, float>(value);
		}

		public static TTag Tag<TTag>(decimal value) where TTag : Tag<TTag, decimal>
		{
			return Tag<TTag, decimal>(value);
		}

		public static TTag Tag<TTag>(Int16 value) where TTag : Tag<TTag, Int16>
		{
			return Tag<TTag, Int16>(value);
		}

		public static TTag Tag<TTag>(object value) where TTag : Tag<TTag, object>
		{
			return Tag<TTag, object>(value);
		}

		public static TTag Tag<TTag>(sbyte value) where TTag : Tag<TTag, sbyte>
		{
			return Tag<TTag, sbyte>(value);
		}

		public static TTag Tag<TTag>(TimeSpan value) where TTag : Tag<TTag, TimeSpan>
		{
			return Tag<TTag, TimeSpan>(value);
		}

		public static TTag Tag<TTag>(uint value) where TTag : Tag<TTag, uint>
		{
			return Tag<TTag, uint>(value);
		}

		public static TTag Tag<TTag>(ulong value) where TTag : Tag<TTag, ulong>
		{
			return Tag<TTag, ulong>(value);
		}

		public static TTag Tag<TTag>(ushort value) where TTag : Tag<TTag, ushort>
		{
			return Tag<TTag, ushort>(value);
		}

		public static TTag Tag<TTag>(Uri value) where TTag : Tag<TTag, object>
		{
			return Tag<TTag, object>(value);
		}
	}
}