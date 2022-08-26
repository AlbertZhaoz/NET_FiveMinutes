using GraphQL;
using GraphQL.Types;
using NET_FiveMinutes_009_GraphQL.GraphQL.Types;
using NET_FiveMinutes_009_GraphQL.Models;

namespace NET_FiveMinutes_009_GraphQL.GraphQL.Queries
{
    public class AlbertQuery:ObjectGraphType
    {
        public AlbertQuery(Tool_LuDbContext toolLuDbContext)
        {
            Field<ListGraphType<Tool_LuType>>(
                "tools",
                resolve: context => toolLuDbContext.ToolLus
            );

            Field<Tool_LuType>(
                "tool",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "toolId" }),
                resolve: context =>
                {
                    var toolId = context.GetArgument<string>("toolId");

                    if (long.TryParse(toolId, out var id)) return toolLuDbContext.ToolLus.Where(a=>a.ID == id);

                    context.Errors.Add(new ExecutionError("错误的id格式"));
                    return null;
                }
            );
        }
    }
}
