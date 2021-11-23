using System;
using System.Threading.Tasks;
using Contracts.Schemas;
using Tools;

namespace GraphQLTestService
{
  public class Program
  {
    public static void Main()
    {
      MainAsync().GetAwaiter().GetResult();
    }

    public static async Task MainAsync()
    {
      QueryExecutor executor = new QueryExecutor();
      string json = await executor.ExecuteAsync<PersonQuerySchema>("{ person { name } }");

      Console.Write(json);
      Console.ReadLine();
    }
  }
}
