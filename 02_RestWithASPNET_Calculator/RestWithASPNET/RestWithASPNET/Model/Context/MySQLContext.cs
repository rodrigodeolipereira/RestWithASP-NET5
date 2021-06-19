using Microsoft.EntityFrameworkCore;
using RestWithASPNET.Controllers.Model;

namespace RestWithASPNET.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
