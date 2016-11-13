using DiscriminatedUnion;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DistributedUnionTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void InheritedFunctionalityTest()
		{
			var x = Option<String>.Some("Test");

			Assert.AreEqual("It's Test!", x.Match<String>()
				.Case(c => c == "Test", v => "It's Test!")
				.Case(v => "It's Not Test!")
				.Else(() => "It's None!"));
		}

		[TestMethod]
		public void TypedContainerTest()
		{
			ITypeContainer x = new TypedContainer<string>("Testing");

			var y = x.ToContainedType<object>();
		}

		[TestMethod]
		public void InheritedFunctionalityTestNone()
		{
			Option<String> x = (string)null;

			Assert.AreEqual("It's None!", x.Match<String>()
				.Case(c => c == "Test", v => "It's Test!")
				.Case(v => "It's Not Test!")
				.Else(() => "It's None!"));
		}

		[TestMethod]
		public void UnionTest3()
		{
			Union<string, int> x = "Test";

			string value = x.Match<string>()
				.Case(a => a)
				.Case(b => b.ToString())
				.Else(() => "Nothing");

			Assert.AreEqual("Test", value);
		}

		[TestMethod]
		public void UnionTestShortcut()
		{
			Union<string, int> x = 10;

			string value = x.Match<string>()
				.Else(() => "Nothing");

			Assert.AreEqual("Nothing", value);
		}

		[TestMethod]
		public void UnionTest4()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.Case(a => a)
				.Case(b => b.ToString())
				.Else(() => "Nothing");

			Assert.AreEqual("100", value);
		}

		[TestMethod]
		public void UnionTest5()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.Case(v => v)
				.Case(c => c == 100, v => "Keeping It 100.")
				.Case(v => "Tea?")
				.Else(() => "Nothing");

			Assert.AreEqual("Keeping It 100.", value);
		}

		[TestMethod]
		public void UnionTest5Depth()
		{
			var x = new Union<string, Union<string, Union<string>>>(new Union<string, Union<string>>(new Union<string>("Test")));

			string value = x.Match<string>()
				.Case(v => v)
				.Case(v => v
					.Match<string>()
						.Case(b => "Not This")
						.Case(c => c.Match<string>()
						   .Case(d => d) // this is the match
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
				.Case(v => v)
				.Case(c => c == 100, v => "Keeping It 100.")
				.Case(v => "Tea?")
				.Else(() => "Nothing");

			Assert.AreEqual("Keeping It 100.", value);
		}

		[TestMethod]
		public void UnionTest7()
		{
			string value = AOrB(false)
				.Match<string>()
				.Case(a => a)
				.Case(b => b == 100 ? "Keeping It 100." : "Tea?")
				.Else(() => "Nothing");

			Assert.AreEqual("test", value);
		}

		[TestMethod]
		public void UnionTest8()
		{
			var x = Union.ToErrorUnion<int, UnauthorizedAccessException>(() => AOrError(false));
			string value = x
				.Match<string>()
				.Case(a => a.ToString())
				.Case(b => "test")
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
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest4_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4> x = new ItemType4();

			Assert.AreEqual("value4", x.Match<string>()
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest5_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5> x = new ItemType5();

			Assert.AreEqual("value5", x.Match<string>()
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest6_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6> x = new ItemType6();

			Assert.AreEqual("value6", x.Match<string>()
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest7_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7> x = new ItemType7();

			Assert.AreEqual("value7", x.Match<string>()
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest8_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7, ItemType8> x = new ItemType8();

			Assert.AreEqual("value8", x.Match<string>()
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Case(item => item.Value)
				.Else(() => "Nothing"));
		}

		[TestMethod]
		public void MatchTest()
		{
			var testValue = "Testing";

			Assert.AreEqual(100, testValue.Match<int>()
				.Case(t => t == "Testing", v => 100)
				.Case(v => 0)
				.Else(() => -1));
		}

		[TestMethod]
		public void MatchTest2()
		{
			string testValue = null;

			Assert.AreEqual(-1, testValue.Match<int>()
				.Case(t => t == "Testing", v => 100)
				.Else(() => -1));
		}

		[TestMethod]
		public void TestBaseToUnion()
		{
			// use this if you have an instance of one of a many sub classes and you want to handle each case differently.
			TestTypeBase myBase = new ItemType7();

			var union = Union.ToUnionOfSubTypes<TestTypeBase, ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7>(myBase);
			Assert.AreEqual(7, union.Match<int>()
				.Case(c => 1)
				.Case(c => 2)
				.Case(c => 3)
				.Case(c => 4)
				.Case(c => 5)
				.Case(c => 6)
				.Case(c => 7)
				.Else(() => -1));
		}

		[TestMethod]
		public void TestStateMAchine()
		{
			var progressState = Union
				.CreateMatch<StateOne, StateTwo, StateThree, Union<StateOne, StateTwo, StateThree>>(c => c
				.Case(v => new StateTwo())
				.Case(v => new StateThree())
				.Case(v => new StateOne())
				.Else(() => null));

			var one = new StateOne();

			var two = progressState(one);

			Assert.IsTrue(two.Is<StateTwo>());

			var three = progressState(two);

			Assert.IsTrue(three.Is<StateThree>());

			var oneAgain = progressState(three);

			Assert.IsTrue(oneAgain.Is<StateOne>());
		}

		public class TestTypeBase
		{
			public string Value { get; }

			public TestTypeBase(string value)
			{
				this.Value = value;
			}
		}

		public class StateOne : TestTypeBase
		{
			public StateOne() : base("StateOne")
			{
			}
		}

		public class StateTwo : TestTypeBase
		{
			public StateTwo() : base("StateTwo")
			{
			}
		}

		public class StateThree : TestTypeBase
		{
			public StateThree() : base("StateThree")
			{
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

		public struct None
		{
		}

		/// <summary>
		/// This isn't intended to be a serious implementation of Option this is here to test inheriting from a Union
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <seealso cref="DiscriminatedUnion.Union{T, DistributedUnionTests.UnitTest1.None}" />
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
}