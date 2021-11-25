using System.Threading.Tasks;
using GraphQL.Types;

namespace Tools
{
  public interface IQueryExecutor
  {
    public Task<string> ExecuteAsync<T>(string query, T customSchema = null) where T : Schema;
  }
}
