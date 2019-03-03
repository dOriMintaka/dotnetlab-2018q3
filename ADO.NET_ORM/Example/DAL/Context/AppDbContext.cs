﻿using System.Data.Entity;
using DAL.Configuration;
using DAL.Entities;

namespace DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("InternationWidgets")
        {
             Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>());
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TODO: setup dbcontext configuration using EF Fluent API. DO NOT add property attributes for any files from "Entities" folder.

            modelBuilder.Configurations.Add(new ItemConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
