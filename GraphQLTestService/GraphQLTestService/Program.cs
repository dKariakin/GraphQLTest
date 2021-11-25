using System;
using System.Threading.Tasks;
using Contracts.Schemas;
using Microsoft.Extensions.DependencyInjection;
using Tools;

namespace GraphQLTestService
{
  public class Program : Installer
  {
    private static readonly IQueryExecutor executor;

    static Program()
    {
      Install();
      executor = provider.GetService<IQueryExecutor>();
    }

    public static void Main()
    {
      MainAsync().GetAwaiter().GetResult();
    }

    public static async Task MainAsync()
    {
      string json = await executor.ExecuteAsync<PersonQuerySchema>("{ person { name } }");

      Console.Write(json);
      Console.ReadLine();
    }
  }
}
