using System;
using DiscriminatedUnion;
using static DiscriminatedUnion.Discriminator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiscriminatedUnionTests
{
	[TestClass]
	public class UnionShould
	{
		[TestMethod]
		public void InheritedFunctionalityTest()
		{
			var x = Option<string>.Some("Test");

			Assert.AreEqual("It's Test!", x.Match<string>()
				.Case(c => c == "Test", v => "It's Test!")
				.Case(v => "It's Not Test!")
				.Default(() => "It's None!"));
		}

#if NETSTANDARD3_0
		[TestMethod]
		public void TypedContainerTest()
		{
			ITypeContainer x = (Container<string>)"Testing";

			var y = x.ToContainedType<object>();
		}
#endif
        [TestMethod]
		public void UnionToStringShouldReturnContainedValueToString()
		{
			Union<string, int> x = "Test";
			Assert.AreEqual("Test", x.ToString());
		}

        [TestMethod]
		public void InheritedFunctionalityTestNone()
		{
			string value = null;
			// ReSharper disable once ExpressionIsAlwaysNull
			Option<string> x = value;

			Assert.AreEqual("It's None!", x.Match<string>()
				.Case(c => c == "Test", v => "It's Test!")
				.Case(v => "It's Not Test!")
				.Default(() => "It's None!"));
		}

		[TestMethod]
		public void UnionTest3()
		{
			Union<string, int> x = "Test";

			string value = x.Match<string>()
				.Case(a => a)
				.Case(b => b.ToString())
				.Default(() => "Nothing");

			Assert.AreEqual("Test", value);
		}


		[TestMethod]
		public void MatchWithoutType()
		{
			Union<string, int> x = "Test";

			var value = x.Match()
				.Case(a => a)
				.Case(b => b.ToString())
				.Default(() => "Nothing");

			if(value.Is<string>(out var s))
			{
				Assert.AreEqual(s, "Test");
			}
			else
			{
				Assert.Fail();
			}
			
		}

		[TestMethod]
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
			Assert.AreEqual("Test", value);
		}
#if NETSTANDARD3_0
        [TestMethod]
        public void UnionTestModern2()
        {
            Union<string, int> x = "Test";
            string value = x
            switch
            {
                ( var s, _) => s,
                (_, var i) => i.ToString()
                    
            }
            Assert.AreEqual("Test", value);
        }
#endif
        [TestMethod]
		public void UnionTestShortcut()
		{
			Union<string, int> x = 10;

			string value = x.Match<string>()
				.Default(() => "Nothing");

			Assert.AreEqual("Nothing", value);
		}

		[TestMethod]
		public void UnionTest4()
		{
			var x = new Union<string, int>(100);

			string value = x.Match<string>()
				.Case(a => a)
				.Case(b => b.ToString())
				.Default(() => "Nothing");

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
				.Default(() => "Nothing");

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
						   .Default(() => "Not This"))
						.Default(() => "Not This"))
				.Default(() => "Not This");

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
				.Default(() => "Nothing");

			Assert.AreEqual("Keeping It 100.", value);
		}

		[TestMethod]
		public void UnionTest7()
		{
			string value = AOrB(false)
				.Match<string>()
				.Case(a => a)
				.Case(b => b == 100 ? "Keeping It 100." : "Tea?")
				.Default(() => "Nothing");

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
				.Default(() => "Nothing");

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
			Union<ItemType1, ItemType2, ItemType3> x = Tag<ItemType3>("value3");

			Assert.AreEqual("value3", x.Match<string>()
				.Case(item => (string)item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTreeTest()
		{

		}

		[TestMethod]
		public void UnionTest4_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4> x = Tag<ItemType4>("value4");

			Assert.AreEqual("value4", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest5_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5> x = Tag<ItemType5>("value15");

			Assert.AreEqual("value15", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest6_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6> x = Tag<ItemType6>("value6");

			Assert.AreEqual("value6", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest7_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7> x = Tag<ItemType7>("value7");

			Assert.AreEqual("value7", x.Match<string>()
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Case(item => item)
				.Default(() => "Nothing"));
		}

		[TestMethod]
		public void UnionTest8_1()
		{
			Union<ItemType1, ItemType2, ItemType3, ItemType4, ItemType5, ItemType6, ItemType7, ItemType8> x = Tag<ItemType8>("value8");

			Assert.AreEqual("value8", x.Match<string>()
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

		[TestMethod]
		public void MatchTest()
		{
			var testValue = "Testing";

			Assert.AreEqual(100, testValue.Match<int>()
				.Case(t => t == "Testing", v => 100)
				.Case(v => 0)
				.Default(() => -1));
		}

		[TestMethod]
		public void MatchTest2()
		{
			string testValue = null;

			Assert.AreEqual(-1, testValue.Match<int>()
				.Case(t => t == "Testing", v => 100)
				.Default(() => -1));
		}
		
		[TestMethod]
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

			Assert.IsTrue(two.Is<StateTwo>());

			var three = progressState(two);

			Assert.IsTrue(three.Is<StateThree>());

			var oneAgain = progressState(three);

			Assert.IsTrue(oneAgain.Is<StateOne>());
		}

#if NETSTANDARD3_0
		////[TestMethod]
		////public void TestWeird()
		////{
		////	Weird x = 100;
		////}
#endif

		public class Weird : Union<Union<int, string>>
		{
			public Weird(Union<int, string> value) : base(value){}

			public static explicit operator Weird(Union<int, string> v)
			{
				throw new NotImplementedException();
			}
		}

		public class StateOne : Tag<StateOne, string>
		{
		}

		public class StateTwo : Tag<StateTwo, string>
		{
		}

		public class StateThree : Tag<StateThree, string>
		{
		}

		public class ItemType1 : Tag<ItemType1, string>
		{
		}

		public class ItemType2 : Tag<ItemType2, string>
		{
		}

		public class ItemType3 : Tag<ItemType3, string>
		{
		}

		public class ItemType4 : Tag<ItemType4, string>
		{
		}

		public class ItemType5 : Tag<ItemType5, string>
		{
		}

		public class ItemType6 : Tag<ItemType6, string>
		{
		}

		public class ItemType7 : Tag<ItemType7, string>
		{
		}

		public class ItemType8 : Tag<ItemType8, string>
		{
		}
	}
}