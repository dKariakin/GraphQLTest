using Contracts.BasicTypes;
using GraphQL.Types;

namespace Contracts.QueryTypes
{
  public class DocumentType : ObjectGraphType<Document>
  {
    public DocumentType()
    {
      Field(x => x.Id, nullable: true).Name("id");
      Field(x => x.Number, nullable: true).Name("number");
      Field(x => x.Type, nullable: true).Name("type");
    }
  }
}
