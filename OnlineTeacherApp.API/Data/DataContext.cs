using Microsoft.EntityFrameworkCore;
using OnlineTeacherApp.API.Models;

namespace OnlineTeacherApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        

        public DbSet<Value> Values {get;set;}
        public DbSet<User> Users {get;set;}
    }
}