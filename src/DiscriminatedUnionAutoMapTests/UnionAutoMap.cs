using AutoMapper;
using DiscriminatedUnion;
using Xunit;
using UnionAutoMap;

namespace DiscriminatedUnionAutoMapTests
{
	
	public class UnionAutoMap
	{
		public UnionAutoMap()
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

		[Fact]
		public void MapLeftOneToUnionRightOneRightTwo()
		{
			LeftOne left = new LeftOne() { MyProperty = "test", MyProperty2 = "Test" };
			var right = Mapper.Map<LeftOne, Union<RightOne, RightTwo>>(left);

			Assert.True(right.Is<RightOne>());

			Assert.Equal("testTest", right.Match<string>()
				.Case(v => v.MyProperty + v.MyProperty2)
				.Case(v => v.MyProperty.ToString() + v.MyProperty2.ToString())
				.Default(() => ""));
		}

		[Fact]
		public void MapLeftTwoToUnionRightOneRightTwo()
		{
			LeftTwo left = new LeftTwo() { MyProperty = 1, MyProperty2 = 1 };
			var right = Mapper.Map<LeftTwo, Union<RightOne, RightTwo>>(left);

			Assert.True(right.Is<RightTwo>());

			Assert.Equal(2, right.Match<int>()
				.Case(v => -1)
				.Case(v => v.MyProperty + v.MyProperty2)
				.Default(() => -1));
		}

		[Fact]
		public void MapLeftOneInUnionLeftOneLeftTwoToRightOne()
		{
			Union<LeftOne, LeftTwo> left = new LeftOne() { MyProperty = "test", MyProperty2 = "Test" };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, RightOne>(left);

			Assert.IsAssignableFrom<RightOne>(right);

			Assert.Equal("testTest", right.MyProperty + right.MyProperty2);
		}

		[Fact]
		public void MapLeftTwoInUnionLeftOneLeftTwoToRightOne()
		{
			Union<LeftOne, LeftTwo> left = new LeftTwo() { MyProperty = 1, MyProperty2 = 1 };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, RightTwo>(left);

			Assert.IsAssignableFrom<RightTwo>(right);

			Assert.Equal(2, right.MyProperty + right.MyProperty2);
		}

		[Fact]
		public void MapLeftTwoInUnionLeftOneLeftTwoToUnionRightOneRightTwo()
		{
			Union<LeftOne, LeftTwo> left = new LeftTwo() { MyProperty = 1, MyProperty2 = 1 };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, Union<RightOne, RightTwo>>(left);

			Assert.True(right.Is<RightTwo>());

			Assert.Equal(2, right.Match<int>()
				.Case(v => -1)
				.Case(v => v.MyProperty + v.MyProperty2)
				.Default(() => -1));
		}

		[Fact]
		public void MapLeftOneInUnionLeftOneLeftTwoToUnionRightOneRightTwo()
		{
			Union<LeftOne, LeftTwo> left = new LeftOne() { MyProperty = "test", MyProperty2 = "Test" };
			var right = Mapper.Map<Union<LeftOne, LeftTwo>, Union<RightOne, RightTwo>>(left);

			Assert.True(right.Is<RightOne>());

			Assert.Equal("testTest", right.Match<string>()
				.Case(v => v.MyProperty + v.MyProperty2)
				.Case(v => v.MyProperty.ToString() + v.MyProperty2.ToString())
				.Default(() => ""));
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