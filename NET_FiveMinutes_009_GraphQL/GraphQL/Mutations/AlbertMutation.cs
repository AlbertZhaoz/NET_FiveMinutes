using GraphQL;
using GraphQL.Types;
using NET_FiveMinutes_009_GraphQL.GraphQL.Types;
using NET_FiveMinutes_009_GraphQL.Models;

namespace NET_FiveMinutes_009_GraphQL.GraphQL.Mutations
{
    public class AlbertMutation:ObjectType<Mutation>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(f => f.AddTool(default));
        }
    }

    public class Mutation
    {
        private readonly Tool_LuDbContext _toolLuDbContext;
        public Mutation(Tool_LuDbContext toolLuDbContext)
        {
            this._toolLuDbContext = toolLuDbContext;
        }
        public async Task<Tool_Lu> AddTool(Tool_Lu toolLu)
        {
            await _toolLuDbContext.ToolLus.AddAsync(toolLu);
            return toolLu;
        }
    }
}
