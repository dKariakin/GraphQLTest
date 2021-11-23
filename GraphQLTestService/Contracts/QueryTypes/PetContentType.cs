using Contracts.BasicTypes;
using GraphQL.Types;

namespace Contracts.QueryTypes
{
  public class PetContentType : ObjectGraphType<PetContent>
  {
    public PetContentType()
    {
      Field(x => x.Id, nullable: true).Name("id");
      Field(x => x.Name, nullable: true).Name("name");
      Field(x => x.Age, nullable: true).Name("age");
    }
  }
}
