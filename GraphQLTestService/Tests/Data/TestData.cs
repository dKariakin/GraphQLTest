using System.Collections.Generic;
using NUnit.Framework;

namespace Tests.Data
{
  internal sealed class TestData
  {
    internal static IEnumerable<TestCaseData> PersonDataJson()
    {
      yield return new TestCaseData("{ person { name } }")
        .Returns(@"{ ""data"": { ""person"": { ""name"": ""Ivan"" } }");
      yield return new TestCaseData("{ person { id, name, city, birthDate, doc { number, type } } }")
        .Returns(@"{ ""data"": { ""person"": { ""name"": ""Ivan"" } }");
    }
  }
}
