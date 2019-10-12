using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Jerry.BookStore.Authorization.Roles;
using Jerry.BookStore.Authorization.Users;
using Jerry.BookStore.MultiTenancy;
using Jerry.BookStore.Tasks;
using Jerry.BookStore.Persons;

namespace Jerry.BookStore.EntityFrameworkCore
{
    public class BookStoreDbContext : AbpZeroDbContext<Tenant, Role, User, BookStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }


        public DbSet<Task> Tasks { get; set; }

        public DbSet<Person> People { get; set; }


    }
}
