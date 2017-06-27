using DiscriminatedUnion;
using DiscriminatedUnionJsonConverter;
using Xunit;
using Newtonsoft.Json;
using static DiscriminatedUnion.Discriminator;

namespace DiscriminatedUnionJsonConverterTests
{
	
	public class UnionJsonConverterShould
	{
		[Fact]
		public void Test1()
		{
			Union<One, Two> testUnion = new Two() { MyProperty = 1, MyProperty2 = 2 };
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverterDynamic<Union<One, Two>>());

			Union<One, Two> testUnionReturn = JsonConvert.DeserializeObject<Union<One, Two>>(json, new UnionJsonConverterDynamic<Union<One, Two>>());

			Assert.True(testUnionReturn.Is<Two>());
		}

		[Fact]
		public void Test2()
		{
			Union<One, Two> testUnion = new Two() { MyProperty = 1, MyProperty2 = 2 };
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverterKeyed<Union<One, Two>>());

			Union<One, Two> testUnionReturn = JsonConvert.DeserializeObject<Union<One, Two>>(json, new UnionJsonConverterKeyed<Union<One, Two>>());

			Assert.True(testUnionReturn.Is<Two>());
		}

		[Fact]
		public void Test3()
		{
			Union<Address, Email> testUnion = new Email("Test@test.com");
			string json = JsonConvert.SerializeObject(testUnion, Formatting.Indented, new UnionJsonConverterKeyed<Union<Address, Email>>());

			Union<Address, Email> testUnionReturn = JsonConvert.DeserializeObject<Union<Address, Email>>(json, new UnionJsonConverterKeyed<Union<Address, Email>>());

			Assert.True(testUnionReturn.Is<Email>());
		}
	}

	public class Email : Tag<Email, string>
	{
		public Email(string value) : base(value)
		{
		}
	}

	public class Address
	{
		public string Address1 { get; set; }
		public string Address2 { get; set; }
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