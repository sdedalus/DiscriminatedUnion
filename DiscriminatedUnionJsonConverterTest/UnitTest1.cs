using DiscriminatedUnion;
using DiscriminatedUnionJsonConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

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

	/// <summary>
	/// Test object 1.
	/// </summary>
	public class One
	{
		/// <summary>
		/// Gets or sets my property.
		/// </summary>
		/// <value>
		/// My property.
		/// </value>
		public string MyProperty { get; set; }

		/// <summary>
		/// Gets or sets my property2.
		/// </summary>
		/// <value>
		/// My property2.
		/// </value>
		public string MyProperty2 { get; set; }
	}

	/// <summary>
	/// Test object 2.
	/// </summary>
	public class Two
	{
		/// <summary>
		/// Gets or sets my property.
		/// </summary>
		/// <value>
		/// My property.
		/// </value>
		public int MyProperty { get; set; }

		/// <summary>
		/// Gets or sets my property2.
		/// </summary>
		/// <value>
		/// My property2.
		/// </value>
		public int MyProperty2 { get; set; }
	}
}