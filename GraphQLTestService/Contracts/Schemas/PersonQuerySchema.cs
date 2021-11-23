using Contracts.QueryTypes;
using GraphQL.Types;

namespace Contracts.Schemas
{
  public class PersonQuerySchema : Schema
  {
    public PersonQuerySchema()
    {
      Query = new PersonQueryType();
    }
  }
}
