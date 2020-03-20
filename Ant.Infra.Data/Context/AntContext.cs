using Ant.Domain.Models;
using Ant.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Infra.Data.Context
{
    public class AntContext : DbContext
    {
        public AntContext(DbContextOptions<AntContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<SMS_SendRecord> SMS_SendRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new SMS_SendRecordMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
