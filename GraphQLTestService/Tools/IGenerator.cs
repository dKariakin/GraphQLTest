using System.Collections.Generic;
using Contracts.BasicTypes;

namespace Tools
{
  public interface IGenerator
  {
    public IEnumerable<Person> GetPeople();
    public Person GetDefaultPerson(int personId = 1, string personName = "Ivan");
  }
}
