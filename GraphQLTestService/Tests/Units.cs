using System.Collections.Generic;
using Contracts.BasicTypes;
using Contracts.Schemas;
using NUnit.Framework;
using Tools;

namespace Tests
{
  [TestFixture]
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

      Assert.That(people.Equals(Generator.GetPeople()));
    }

    [TestCase("{ person { name } }", ExpectedResult = @"{ ""data"": { ""person"": { ""name"": ""Ivan"" } }")]
    [TestCase("{ person { id, name, city, birthDate, doc { number, type } } }", ExpectedResult = @"{ ""data"": { ""person"": { ""name"": ""Ivan"" } }")]
    public string GetPersonJson(string query)
    {
      return executor.ExecuteAsync<PersonQuerySchema>(query).GetAwaiter().GetResult();
    }
  }
}
