using System;
using Microsoft.EntityFrameworkCore;
using CommanderGQL.Models;

namespace CommandGQL.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
