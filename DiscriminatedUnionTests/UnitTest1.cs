using DiscriminatedUnion;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DistributedUnionTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void UnionTest3()
		{
			Union<string, int> x = "Test";

			string value = x.Match<string>()
				.With(a => a)
				.With(b => b.ToString())
				.Else(() => "Nothing");

			Assert.AreEqual("Test", value);
		}

		[TestMethod]
		public void UnionTest4()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.With(a => a)
				.With(b => b.ToString())
				.Else(() => "Nothing");

			Assert.AreEqual("100", value);
		}

		[TestMethod]
		public void UnionTest5()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.With(v => v)
				.With(c => c == 100, v => "Keeping It 100.")
				.With(v => "Tea?")
				.Else(() => "Nothing");

			Assert.AreEqual("Keeping It 100.", value);
		}

		[TestMethod]
		public void UnionTest5Depth()
		{
			var x = new Union<string, Union<string, Union<string>>>(new Union<string, Union<string>>(new Union<string>("Test")));

			string value = x.Match<string>()
				.With(v => v)
				.With(v => v
					.Match<string>()
						.With(b => "Not This")
						.With(c => c.Match<string>()
						   .With(d => d) // this is the match
						   .Else(() => "Not This"))
						.Else(() => "Not This"))
				.Else(() => "Not This");

			Assert.AreEqual("Test", value);
		}

		[TestMethod]
		public void UnionTest6()
		{
			string value = AOrB(true)
				.Match<string>()
				.With(v => v)
				.With(c => c == 100, v => "Keeping It 100.")
				.With(v => "Tea?")
				.Else(() => "Nothing");

			Assert.AreEqual("Keeping It 100.", value);
		}

		[TestMethod]
		public void UnionTest7()
		{
			string value = AOrB(false)
				.Match<string>()
				.With(a => a)
				.With(b => b == 100 ? "Keeping It 100." : "Tea?")
				.Else(() => "Nothing");

			Assert.AreEqual("test", value);
		}

		[TestMethod]
		public void UnionTest8()
		{
			var x = UnionExtensions.ToErrorUnion<int, UnauthorizedAccessException>(() => AOrError(false));
			string value = x
				.Match<string>()
				.With(a => a.ToString())
				.With(b => "test")
				.Else(() => "Nothing");

			Assert.AreEqual("test", value);
		}

		private Union<string, int> AOrB(bool isA)
		{
			if (isA)
			{
				return 100;
			}
			else
			{
				return "test";
			}
		}

		private int AOrError(bool isA)
		{
			if (isA)
			{
				return 100;
			}
			else
			{
				throw new System.UnauthorizedAccessException();
			}
		}

		[TestMethod]
		public void UnionTest3_1()
		{
			Union<ItemType1, ItemType2, ItemType3> x = new ItemType3();

			Assert.AreEqual("value3", x.Match<string>()
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest4_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4> x = new ItemType4();

			Assert.AreEqual("value4", x.Match<string>()
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest5_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5> x = new ItemType5();

			Assert.AreEqual("value5", x.Match<string>()
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest6_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6> x = new ItemType6();

			Assert.AreEqual("value6", x.Match<string>()
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest7_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7> x = new ItemType7();

			Assert.AreEqual("value7", x.Match<string>()
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest8_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7, ItemType8> x = new ItemType8();

			Assert.AreEqual("value8", x.Match<string>()
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.With(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void MatchTest()
		{
			var testValue = "Testing";

			Assert.AreEqual(100, testValue.Match<int>()
				.With(t => t == "Testing", v => 100)
				.With(v => 0)
				.Else(() => -1));
		}

		public class TestTypeBase
		{
			public string Value { get; }

			public TestTypeBase(string value)
			{
				this.Value = value;
			}
		}

		public class ItemType1 : TestTypeBase
		{
			public ItemType1() : base("value1")
			{
			}
		}

		public class ItemType2 : TestTypeBase
		{
			public ItemType2() : base("value2")
			{
			}
		}

		public class ItemType3 : TestTypeBase
		{
			public ItemType3() : base("value3")
			{
			}
		}

		public class ItemType4 : TestTypeBase
		{
			public ItemType4() : base("value4")
			{
			}
		}

		public class ItemType5 : TestTypeBase
		{
			public ItemType5() : base("value5")
			{
			}
		}

		public class ItemType6 : TestTypeBase
		{
			public ItemType6() : base("value6")
			{
			}
		}

		public class ItemType7 : TestTypeBase
		{
			public ItemType7() : base("value7")
			{
			}
		}

		public class ItemType8 : TestTypeBase
		{
			public ItemType8() : base("value8")
			{
			}
		}
	}
}