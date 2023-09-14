using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A5Jenkins.Model;

namespace A5Jenkins.Data
{
    public class A5JenkinsDbContext : DbContext
    {
        public A5JenkinsDbContext (DbContextOptions<A5JenkinsDbContext> options)
            : base(options)
        {
        }

        public DbSet<A5Jenkins.Model.User> User { get; set; } = default!;
    }
}
