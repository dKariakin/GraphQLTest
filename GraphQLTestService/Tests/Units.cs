using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts.BasicTypes;
using Contracts.Schemas;
using FluentAssertions;
using NUnit.Framework;
using Tools;

namespace Tests
{
  [TestFixture]
  [Parallelizable]
  public class Units
  {
    private readonly QueryExecutor executor;

    public Units()
    {
      executor = new QueryExecutor();
    }

    [Test]
    public void TestPeopleList()
    {
      List<Person> people = new List<Person>()
      {
        Generator.GetDefaultPerson(1, "Ivan"),
        Generator.GetDefaultPerson(2, "Vika"),
        Generator.GetDefaultPerson(3, "Max")
      };

      _ = people.Should().BeEquivalentTo(Generator.GetPeople());
    }

    [TestCase("{ person { name } }", ExpectedResult = @"{ ""data"": { ""person"": { ""name"": ""Ivan"" } }")]
    [TestCase("{ person { id, name, city, birthDate, doc { number, type } } }", ExpectedResult = @"{ ""data"": { ""person"": { ""name"": ""Ivan"" } }")]
    public async Task<string> GetPersonJson(string query)
    {
      return await executor.ExecuteAsync<PersonQuerySchema>(query);
    }
  }
}
