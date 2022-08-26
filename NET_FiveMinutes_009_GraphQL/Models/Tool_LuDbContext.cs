using Microsoft.EntityFrameworkCore;

namespace NET_FiveMinutes_009_GraphQL.Models
{
    public class Tool_LuDbContext:DbContext
    {
        public DbSet<Tool_Lu> ToolLus { get; set; }

        public Tool_LuDbContext(DbContextOptions<Tool_LuDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
