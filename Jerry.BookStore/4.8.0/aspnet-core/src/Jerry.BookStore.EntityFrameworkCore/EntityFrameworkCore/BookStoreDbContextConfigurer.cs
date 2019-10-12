using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Jerry.BookStore.EntityFrameworkCore
{
    public static class BookStoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookStoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookStoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
