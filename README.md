# DiscriminatedUnion
Implementation of Discriminated Union and Pattern Matching in C#.

```csharp
string outputValue = x.Match<String>()
						.Case(c => c == "Test", v => "It's Test!")
						.Case(v => "It's Not Test!")
						.Else(() => "It's None!")
```
or 
```csharp
var x = new Union<string, int>(100);

// the type annotations below are optional and only added for clerity.
string value = x.Match<string>()
	.Case((string v) => v)
	.Case((int c) => c == 100, (int v) => "Keeping It 100.")
	.Case((int v) => "Tea?")
	.Else(() => "Nothing");

Assert.AreEqual("Keeping It 100.", value);
```
