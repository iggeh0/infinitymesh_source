using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using infinitymesh_test.DAL.Models;

namespace infinitymesh_test.DAL.Models
{
    public class TempDB : DbContext
    {
        public TempDB()
        {
        }

        public TempDB(DbContextOptions<TempDB> options)
            : base(options)
        { }

        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }

        //public static bool AllMigrationsApplied(this DbContext context)
        //{
        //    var applied = context.GetService<IHistoryRepository>()
        //        .GetAppliedMigrations()
        //        .Select(m => m.MigrationId);

        //    var total = context.GetService<IMigrationsAssembly>()
        //        .Migrations
        //        .Select(m => m.Key);

        //    return !total.Except(applied).Any();
        //}

    }
}
