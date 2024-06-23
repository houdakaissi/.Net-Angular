
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using APP7.Models;
 



namespace APP7.Models

{
    public class APIDBContext: DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity Configurations...
            //Continue if db provider is Sqlite

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entity.GetProperties().Where(p => p.GetColumnType().StartsWith("nvarchar", StringComparison.OrdinalIgnoreCase)))
                {
                    var columnType = property.GetColumnType();
                    if (columnType.Contains('(') && !columnType.Contains("MAX", StringComparison.OrdinalIgnoreCase))
                        property.SetMaxLength(int.Parse(columnType.Substring("nvarchar".Length + 1).Replace(")", "")));
                    property.SetColumnType("TEXT");
                }
            }
        }
        public DbSet<APP7.Models.Employee> Employee { get; set; } = default!;

    }
}
