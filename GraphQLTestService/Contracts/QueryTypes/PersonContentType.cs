using Contracts.BasicTypes;
using GraphQL.Types;

namespace Contracts.QueryTypes
{
  public class PersonContentType : ObjectGraphType<PersonContent>
  {
    public PersonContentType()
    {
      Field(x => x.Id, nullable: true).Name("id");
      Field(x => x.Name, nullable: true).Name("name");
      Field(x => x.City, nullable: true).Name("city");
      Field(x => x.BirthDate, nullable: true).Name("birthDate");
      Field(x => x.Document, nullable: false).Name("doc");
    }
  }
}
