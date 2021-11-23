using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.SystemTextJson;
using GraphQL.Types;

namespace Tools
{
  public class QueryExecutor
  {
    private readonly IDocumentExecuter executer;
    private readonly IDocumentWriter writer;

    public QueryExecutor()
    {
      executer = new DocumentExecuter();
      writer = new DocumentWriter(indent: false);
    }

    public async Task<string> ExecuteAsync<T>(string query, T customSchema = null) where T : Schema
    {
      T schema = customSchema ?? (T)Activator.CreateInstance(typeof(T));
      ExecutionResult result = await executer.ExecuteAsync(options =>
      {
        options.Schema = schema;
        options.Query = query;
      });
      ExecutionResult renderResult = new ExecutionResult
      {
        Data = result.Data,
        Executed = result.Executed
      };

      return await writer.WriteToStringAsync(renderResult);
    }
  }
}
