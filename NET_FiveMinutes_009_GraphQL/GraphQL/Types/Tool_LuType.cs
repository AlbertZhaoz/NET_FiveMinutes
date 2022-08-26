using NET_FiveMinutes_009_GraphQL.Models;

namespace NET_FiveMinutes_009_GraphQL.GraphQL.Types
{
    public class Tool_LuType: ObjectType<Tool_Lu>
    {
        public Tool_LuType(IObjectTypeDescriptor<Tool_Lu> descriptor)
        {
            descriptor
                .Field(f => f.ID)
                .Type<LongType>();
            descriptor
                .Field(f => f.Title)
                .Type<StringType>();
            descriptor
                .Field(f => f.TitleLink)
                .Type<StringType>();
            descriptor
                .Field(f => f.Sort)
                .Type<StringType>();
            descriptor
                .Field(f => f.Description)
                .Type<StringType>();
        }
    }
}
