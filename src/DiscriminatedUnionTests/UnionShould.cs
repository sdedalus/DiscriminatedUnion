using System;
using DiscriminatedUnion;
using DiscriminatedUnion.Option;
using Xunit;

namespace DiscriminatedUnionTests
{
	public class UnionShould
	{
		[Fact]
		public void InheritedFunctionalityTest()
		{
			var x = Option<string>.Some("Test");

			Assert.Equal("It's Test!", x.Match<string>()
				.Case(c => c == "Test", v => "It's Test!")
				.Case(v => "It's Not Test!")
				.Default(() => "It's None!"));
		}

		[Fact]
		public void TypedContainerTest()
		{
			ITypeContainer x = new TypedContainer<string>("Testing");

			var y = x.ToContainedType<object>();
		}
		
		[Fact]
		public void UnionToStringShouldReturnContainedValueToString()
		{
			Union<string, int> x = "Test";
			Assert.Equal("Test", x.ToString());
		}

		[Fact]
		public void InheritedFunctionalityTestNone()
		{
			string value = null;
			// ReSharper disable once ExpressionIsAlwaysNull
			Option<string> x = value;

			Assert.Equal("It's None!", x.Match<string>()
				.Case(c => c == "Test", v => "It's Test!")
				.Case(v => "It's Not Test!")
				.Default(() => "It's None!"));
		}

		[Fact]
		public void UnionTest3()
		{
			Union<string, int> x = "Test";

			string value = x.Match<string>()
				.Case(a => a)
				.Case(b => b.ToString())
				.Default(() => "Nothing");

			Assert.Equal("Test", value);
		}


		[Fact]
		public void MatchWithoutType()
		{
			Union<string, int> x = "Test";

			var value = x.Match()
				.Case(a => a)
				.Case(b => b.ToString())
				.Default(() => "Nothing");

			if(value.Is<string>(out var s))
			{
				Assert.Equal(s, "Test");
			}
			else
			{
				Assert.True(false);
			}
			
		}

		[Fact]
		public void UnionTestModern()
		{
			Union<string, int> x = "Test";
			string value = string.Empty;
			switch (x)
			{
				case var a when a.Is<string>(out var s):
					value = s;
					break;
				case var a when a.Is<int>(out var i):
					value = i.ToString();
					break;
			}
			Assert.Equal("Test", value);
		}

		[Fact]
		public void UnionTestShortcut()
		{
			Union<string, int> x = 10;

			string value = x.Match<string>()
				.Default(() => "Nothing");

			Assert.Equal("Nothing", value);
		}

		[Fact]
		public void UnionTest4()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.Case(a => a)
				.Case(b => b.ToString())
				.Default(() => "Nothing");

			Assert.Equal("100", value);
		}

		[Fact]
		public void UnionTest5()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.Case(v => v)
				.Case(c => c == 100, v => "Keeping It 100.")
				.Case(v => "Tea?")
				.Default(() => "Nothing");

			Assert.Equal("Keeping It 100.", value);
		}

		[Fact]
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
						   .Default(() => "Not This"))
						.Default(() => "Not This"))
				.Default(() => "Not This");

			Assert.Equal("Test", value);
		}

		[Fact]
		public void UnionTest6()
		{
			string value = AOrB(true)
				.Match<string>()
				.Case(v => v)
				.Case(c => c == 100, v => "Keeping It 100.")
				.Case(v => "Tea?")
				.Default(() => "Nothing");

			Assert.Equal("Keeping It 100.", value);
		}

		[Fact]
		public void UnionTest7()
		{
			string value = AOrB(false)
				.Match<string>()
				.Case(a => a)
				.Case(b => b == 100 ? "Keeping It 100." : "Tea?")
				.Default(() => "Nothing");

			Assert.Equal("test", value);
		}

		[Fact]
		public void UnionTest8()
		{
			var x = Union.ToErrorUnion<int, UnauthorizedAccessException>(() => AOrError(false));
			string value = x
				.Match<string>()
				.Case(a => a.ToString())
				.Case(b => "test")
				.Default(() => "Nothing");

			Assert.Equal("test", value);
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

		[Fact]
		public void UnionTest3_1()
		{
			Union<ItemType1, ItemType2, ItemType3> x = new ItemType3();

			Assert.Equal("value3", x.Match<string>()
				.Case(item => (string)item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[Fact]
		public void UnionTest4_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4> x = new ItemType4();

			Assert.Equal("value4", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[Fact]
		public void UnionTest5_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5> x = Discriminator.Tag<ItemType5>("value15");

			Assert.Equal("value15", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[Fact]
		public void UnionTest6_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6> x = new ItemType6();

			Assert.Equal("value6", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[Fact]
		public void UnionTest7_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7> x = Discriminator.Tag<ItemType7>("value7");

			Assert.Equal("value7", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[Fact]
		public void UnionTest8_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7, ItemType8> x = new ItemType8();

			Assert.Equal("value8", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[Fact]
		public void MatchTest()
		{
			var testValue = "Testing";

			Assert.Equal(100, testValue.Match<int>()
				.Case(t => t == "Testing", v => 100)
				.Case(v => 0)
				.Default(() => -1));
		}

		[Fact]
		public void MatchTest2()
		{
			string testValue = null;

			Assert.Equal(-1, testValue.Match<int>()
				.Case(t => t == "Testing", v => 100)
				.Default(() => -1));
		}
		
		[Fact]
		public void TestStateMachine()
		{
			var progressState = Union
				.CreateMap<StateOne, StateTwo, StateThree, Union<StateOne, StateTwo, StateThree>>(c => c
				.Case(v => new StateTwo())
				.Case(v => new StateThree())
				.Case(v => new StateOne())
				.Default(() => null));

			var one = new StateOne();

			var two = progressState(one);

			Assert.True(two.Is<StateTwo>());

			var three = progressState(two);

			Assert.True(three.Is<StateThree>());

			var oneAgain = progressState(three);

			Assert.True(oneAgain.Is<StateOne>());
		}
		
		public class StateOne : Tag<StateOne, string>
		{
			public StateOne(string value = "StateOne") : base(value)
			{
			}
		}

		public class StateTwo : Tag<StateTwo, string>
		{
			public StateTwo(string value = "StateTwo") : base(value)
			{
			}
		}

		public class StateThree : Tag<StateThree, string>
		{
			public StateThree(string value = "StateThree") : base(value)
			{
			}
		}

		public class ItemType1 : Tag<ItemType1, string>
		{
			public ItemType1(string value = "value1") : base(value)
			{
			}
		}

		public class ItemType2 : Tag<ItemType2, string>
		{
			public ItemType2(string value = "value2") : base(value)
			{
			}
		}

		public class ItemType3 : Tag<ItemType3, string>
		{
			public ItemType3(string value = "value3") : base(value)
			{
			}
		}

		public class ItemType4 : Tag<ItemType4, string>
		{
			public ItemType4(string value = "value4") : base(value)
			{
			}
		}

		public class ItemType5 : Tag<ItemType5, string>
		{
			public ItemType5(string value = "value5") : base(value)
			{
			}
		}

		public class ItemType6 : Tag<ItemType6, string>
		{
			public ItemType6(string value = "value6") : base(value)
			{
			}
		}

		public class ItemType7 : Tag<ItemType7, string>
		{
			public ItemType7(string value = "value7") : base(value)
			{
			}
		}

		public class ItemType8 : Tag<ItemType8, string>
		{
			public ItemType8(string value = "value8") : base(value)
			{
			}
		}
	}
}