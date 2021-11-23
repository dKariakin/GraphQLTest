using Contracts.BasicTypes;
using GraphQL.Types;

namespace Contracts.QueryTypes
{
  public class PersonQueryType : ObjectGraphType<Person>
  {
    public PersonQueryType()
    {
      Field(x => x.person, nullable: true).Name("person");
      Field(x => x.pets, nullable: true).Name("pets");
    }
  }
}
