using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserIntraction.Models;

namespace UserIntraction
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
        { }
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        { }
        public DbSet<UserModel> ApplicationUser { get; set; }
    }
}
