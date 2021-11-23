using Contracts.BasicTypes;
using GraphQL.Types;

namespace Contracts.QueryTypes
{
  public class DocTypeEnum : EnumerationGraphType
  {
    public DocTypeEnum()
    {
      AddValue("PASSPORT", "Customer has a passport as a primary document", DocTypes.Passport);
      AddValue("VISA", "Customer has a visa as a primary document", DocTypes.Visa);
    }
  }
}
