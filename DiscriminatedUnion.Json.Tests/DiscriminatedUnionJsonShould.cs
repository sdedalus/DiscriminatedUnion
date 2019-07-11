using DiscriminatedUnion;
using DiscriminatedUnion.Json;
using static DiscriminatedUnion.Discriminator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DiscriminatedUnion.Json.Tests
{
	[TestClass]
	public class DiscriminatedUnionJsonShould
	{
		[TestMethod]
		public void Test1()
		{
			Union<One, Two> testUnion = new Two() { MyProperty = 1, MyProperty2 = 2 };
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverterDynamic<Union<One, Two>>());

			Union<One, Two> testUnionReturn = JsonConvert.DeserializeObject<Union<One, Two>>(json, new UnionJsonConverterDynamic<Union<One, Two>>());

			Assert.IsTrue(testUnionReturn.Is<Two>());
		}

		[TestMethod]
		public void Test2()
		{
			Union<One, Two> testUnion = new Two() { MyProperty = 1, MyProperty2 = 2 };
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverterKeyed<Union<One, Two>>());

			Union<One, Two> testUnionReturn = JsonConvert.DeserializeObject<Union<One, Two>>(json, new UnionJsonConverterKeyed<Union<One, Two>>());

			Assert.IsTrue(testUnionReturn.Is<Two>());
		}

		[TestMethod]
		public void Test3()
		{
			Union<Address, Email> testUnion = Tag<Email>("Test@test.com");
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverterKeyed<Union<Address, Email>>());

			Union<Address, Email> testUnionReturn = JsonConvert.DeserializeObject<Union<Address, Email>>(json, new UnionJsonConverterKeyed<Union<Address, Email>>());

			Assert.IsTrue(testUnionReturn.Is<Email>());
		}
	}

	public class Email : Tag<Email, string>
	{
	}

	public class Address
	{
		public string Address1 { get; set; }
		public string Address2 { get; set; }
	}
	
	public class One
	{
		public string MyProperty { get; set; }
		
		public string MyProperty2 { get; set; }
	}
	
	public class Two
	{
		public int MyProperty { get; set; }
		
		public int MyProperty2 { get; set; }
	}
}