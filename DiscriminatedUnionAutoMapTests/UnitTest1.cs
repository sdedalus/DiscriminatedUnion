using AutoMapper;
using DiscriminatedUnion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnionAutoMap;

namespace DiscriminatedUnionAutoMapTests
{
	[TestClass]
	public class UnitTest1
	{
		public UnitTest1()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<LeftOne, RightOne>();
				cfg.CreateMap<LeftTwo, RightTwo>();
				cfg.CreateMap<Union<LeftOne, LeftTwo>, RightOne>().ConvertUsing(new FromUnionConverter<LeftOne, LeftTwo, RightOne>());
				cfg.CreateMap<Union<LeftOne, LeftTwo>, RightTwo>().ConvertUsing(new FromUnionConverter<LeftOne, LeftTwo, RightTwo>());
				cfg.CreateMap<LeftOne, Union<RightOne, RightTwo>>().ConvertUsing(new ToUnionConverter<LeftOne, Union<RightOne, RightTwo>>());
				cfg.CreateMap<LeftTwo, Union<RightOne, RightTwo>>().ConvertUsing(new ToUnionConverter<LeftTwo, Union<RightOne, RightTwo>>());
				cfg.CreateMap<Union<LeftOne, LeftTwo>, Union<RightOne, RightTwo>>().ConvertUsing(new FromUnionToUnionConverter<Union<LeftOne, LeftTwo>, Union<RightOne, RightTwo>>());
			});
		}

		[TestMethod]
		public void MapLeftOneToUnionRightOneRightTwo()
		{
			LeftOne left = new LeftOne() { MyProperty = "test", MyProperty2 = "Test" };
			var right = Mapper.Map<LeftOne, Union<RightOne, RightTwo>>(left);

			Assert.IsTrue(right.Is<RightOne>());

			Assert.AreEqual("testTest", right.Match<string>()
				.Case(v => v.MyProperty + v.MyProperty2)
				.Case(v => v.MyProperty.ToString() + v.MyProperty2.ToString())
				.Else(() => ""));
		}

		[TestMethod]
		public void MapLeftTwoToUnionRightOneRightTwo()
		{
			LeftTwo left = new LeftTwo() { MyProperty = 1, MyProperty2 = 1 };
			var right = Mapper.Map<LeftTwo, Union<RightOne, RightTwo>>(left);

			Assert.IsTrue(right.Is<RightTwo>());

			Assert.AreEqual(2, right.Match<int>()
				.Case(v => -1)
				.Case(v => v.MyProperty + v.MyProperty2)
				.Else(() => -1));
		}

		[TestMethod]
		public void MapLeftOneInUnionLeftOneLeftTwoToRightOne()
		{
			Union<LeftOne, LeftTwo> left = new LeftOne() { MyProperty = "test", MyProperty2 = "Test" };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, RightOne>(left);

			Assert.IsInstanceOfType(right, typeof(RightOne));

			Assert.AreEqual("testTest", right.MyProperty + right.MyProperty2);
		}

		[TestMethod]
		public void MapLeftTwoInUnionLeftOneLeftTwoToRightOne()
		{
			Union<LeftOne, LeftTwo> left = new LeftTwo() { MyProperty = 1, MyProperty2 = 1 };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, RightTwo>(left);

			Assert.IsInstanceOfType(right, typeof(RightTwo));

			Assert.AreEqual(2, right.MyProperty + right.MyProperty2);
		}

		[TestMethod]
		public void MapLeftTwoInUnionLeftOneLeftTwoToUnionRightOneRightTwo()
		{
			Union<LeftOne, LeftTwo> left = new LeftTwo() { MyProperty = 1, MyProperty2 = 1 };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, Union<RightOne, RightTwo>>(left);

			Assert.IsTrue(right.Is<RightTwo>());

			Assert.AreEqual(2, right.Match<int>()
				.Case(v => -1)
				.Case(v => v.MyProperty + v.MyProperty2)
				.Else(() => -1));
		}

		[TestMethod]
		public void MapLeftOneInUnionLeftOneLeftTwoToUnionRightOneRightTwo()
		{
			Union<LeftOne, LeftTwo> left = new LeftOne() { MyProperty = "test", MyProperty2 = "Test" };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, Union<RightOne, RightTwo>>(left);

			Assert.IsTrue(right.Is<RightOne>());

			Assert.AreEqual("testTest", right.Match<string>()
				.Case(v => v.MyProperty + v.MyProperty2)
				.Case(v => v.MyProperty.ToString() + v.MyProperty2.ToString())
				.Else(() => ""));
		}
	}

	public class LeftOne
	{
		public string MyProperty { get; set; }
		public string MyProperty2 { get; set; }
	}

	public class LeftTwo
	{
		public int MyProperty { get; set; }
		public int MyProperty2 { get; set; }
	}

	public class RightOne
	{
		public string MyProperty { get; set; }
		public string MyProperty2 { get; set; }
	}

	public class RightTwo
	{
		public int MyProperty { get; set; }
		public int MyProperty2 { get; set; }
	}
}