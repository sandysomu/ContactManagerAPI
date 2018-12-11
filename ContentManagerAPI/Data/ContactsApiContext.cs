using ContentManagerAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace ContentManagerAPI.Data
{


    public class ContactsApiContext : DbContext
    {
        public ContactsApiContext(DbContextOptions<ContactsApiContext> options)
            : base(options)
        { }

      
        public DbSet<ContactsInfo> ContactsInfo { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<Example>()
        //        .Property(e => e.Name)
        //        .HasColumnType("varchar(512)");
        //}
    }

    //public static class ContactsApiContextFactory
    //{
    //    public static ContactsApiContext Create(string connectionString)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<ContactsApiContext>();
    //        optionsBuilder.UseSqlite(connectionString);

    //        var context = new ContactsApiContext(optionsBuilder.Options);
    //        context.Database.EnsureCreated();

    //        return context;
    //    }
    //}
}
