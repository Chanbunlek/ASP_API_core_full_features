using full_webapi_features.Model;
using Microsoft.EntityFrameworkCore;

namespace full_webapi_features.Config;

public class DbConnection(DbContextOptions<DbConnection> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
