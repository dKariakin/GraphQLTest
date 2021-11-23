using System;
using System.Collections.Generic;
using Contracts.BasicTypes;

namespace Tools
{
  public static class Generator
  {
    public static IEnumerable<Person> GetPeople()
    {
      return new List<Person>
      {
        GetDefaultPerson(1, "Ivan"),
        GetDefaultPerson(2, "Vika"),
        GetDefaultPerson(3, "Max")
      };
    }

    public static Person GetDefaultPerson(int personId = 1, string personName = "Ivan")
    {
      return new Person
      {
        person = new PersonContent
        {
          BirthDate = new DateTime(1980, 5, 10),
          City = "Moscow",
          Id = personId,
          Name = personName,
          Document = new Document
          {
            Id = 1,
            Number = 400,
            Type = DocTypes.Passport
          }
        },
        pets = new List<PetContent>
          {
            new PetContent
            {
              Id = 100,
              Age = 2,
              Name = "Buddy"
            }
          }
      };
    }
  }
}
