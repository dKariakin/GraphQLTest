using System;

namespace Contracts.BasicTypes
{
  public class PersonContent
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public DateTime BirthDate { get; set; }
    public Document Document { get; set; }
  }
}
