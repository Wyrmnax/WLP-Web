using Microsoft.EntityFrameworkCore;

using wwlp.Domain.Entities;

namespace wwlp.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        #region Tables
        public DbSet<User> User { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            #region TablesMap
            
            //modelBuilder.Entity<User>().ToTable("User");
            #endregion
        }

    }
}
