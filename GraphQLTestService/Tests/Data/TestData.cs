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
        .Returns(@"{ ""data"": { ""person"": { ""id"": 1, ""name"": ""Ivan"", ""city"": ""Moscow"", ""birthDate"": ""1980-05-10"", ""doc"": { ""number"": 400, ""type"": ""PASSPORT"" } } }");
    }
  }
}
