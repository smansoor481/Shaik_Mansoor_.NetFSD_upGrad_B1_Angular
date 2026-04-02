using EntityFrameworkAssignment.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntiryMVC.Database
{
    public class AccDBContext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        //define connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MANSOOR\\SQLEXPRESS;Initial Catalog=EFcoreDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
