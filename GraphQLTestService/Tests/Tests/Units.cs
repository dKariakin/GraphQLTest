using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts.BasicTypes;
using Contracts.Schemas;
using FluentAssertions;
using NUnit.Framework;
using Tests.Data;
using Tools;
using Tools.Impl;

namespace Tests
{
  [TestFixture]
  [Parallelizable(ParallelScope.All)]
  public class Units
  {
    private IQueryExecutor executor;
    private IGenerator generator;
    
    [OneTimeSetUp]
    public void SetUp()
    {
      executor = new QueryExecutor();
      generator = new Generator();
    }

    [Test]
    public void TestPeopleList()
    {
      List<Person> people = new List<Person>()
      {
        generator.GetDefaultPerson(1, "Ivan"),
        generator.GetDefaultPerson(2, "Vika"),
        generator.GetDefaultPerson(3, "Max")
      };

      _ = people.Should().BeEquivalentTo(generator.GetPeople());
    }

    [Test, TestCaseSource(typeof(TestData), nameof(TestData.PersonDataJson))]
    public async Task<string> GetPersonJson(string query)
    {
      return await executor.ExecuteAsync<PersonQuerySchema>(query);
    }
  }
}
