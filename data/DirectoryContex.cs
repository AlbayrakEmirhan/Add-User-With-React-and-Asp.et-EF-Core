using Microsoft.EntityFrameworkCore;

namespace Contacts.Api;

public class DirectoryContex(DbContextOptions<DirectoryContex> options) : DbContext(options)
{
    public DbSet<Person> people { get; set; }

}


