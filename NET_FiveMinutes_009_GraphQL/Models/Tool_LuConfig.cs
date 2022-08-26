using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NET_FiveMinutes_009_GraphQL.Models
{
    public class Tool_LuConfig:IEntityTypeConfiguration<Tool_Lu>
    {
        public void Configure(EntityTypeBuilder<Tool_Lu> builder)
        {
            builder.ToTable("Tool_Lu");
            builder.Property(e=>e.Title).HasColumnName("标题");
            builder.Property(e=>e.TitleLink).HasColumnName("标题链接");
            builder.Property(e=>e.Sort).HasColumnName("类别");
            builder.Property(e=>e.Description).HasColumnName("描述");
        }
    }
}
