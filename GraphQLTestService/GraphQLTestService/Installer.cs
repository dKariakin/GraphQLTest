using Microsoft.Extensions.DependencyInjection;
using Tools;
using Tools.Impl;

namespace GraphQLTestService
{
  public class Installer
  {
    public static ServiceProvider provider { get; private set; }

    public static void Install()
    {
      provider = new ServiceCollection()
        .AddSingleton<IQueryExecutor, QueryExecutor>()
        .AddSingleton<IGenerator, Generator>()
        .BuildServiceProvider();
    }
  }
}
