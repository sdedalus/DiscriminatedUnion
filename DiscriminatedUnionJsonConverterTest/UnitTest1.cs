using DiscriminatedUnion;
using DiscriminatedUnionJsonConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;

namespace DiscriminatedUnionJsonConverterTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Union<One, Two> testUnion = new Two() { MyProperty = 1, MyProperty2 = 2 };
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverter<Union<One, Two>>());

			Union<One, Two> testUnionReturn = JsonConvert.DeserializeObject<Union<One, Two>>(json, new UnionJsonConverter<Union<One, Two>>());

			Assert.IsTrue(testUnionReturn.Is<Two>());
		}
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