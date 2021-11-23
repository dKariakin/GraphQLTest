using System.Collections.Generic;

namespace Contracts.BasicTypes
{
  public class Person
  {
    public PersonContent person;
    public IEnumerable<PetContent> pets;
  }
}
