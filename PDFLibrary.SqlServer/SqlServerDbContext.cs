using Microsoft.EntityFrameworkCore;
using System.Xml;
using PDFLibrary.Model.Entities;
using PDFLibrary.SqlServer.Entities;
namespace PDFLibrary.SqlServer
{
    public partial class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.ApplyConfiguration(new PDFDetailsConfiguration());           
        }      
        DbSet<PDFDetails> PDFDetails { get; set; }
        
    }
}
