﻿using FineManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FineManagement.Infrastructure.Data
{
    public class FineManagementDbContext : DbContext
    {
        public FineManagementDbContext()
        {
        }
        public FineManagementDbContext(DbContextOptions<FineManagementDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Team>? Teams { get; set; }
        public virtual DbSet<Transaction>? Transactions { get; set; }
        public virtual DbSet<Fine>? Fines { get; set; }
        public virtual DbSet<UserTeam>? UserTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FineManagementDbContext).Assembly);
            // Don't call base.OnModelCreating(modelBuilder);
            // It's not required: https://stackoverflow.com/questions/39576176/is-base-onmodelcreatingmodelbuilder-necessary
            // and in this particular case creates problems in migrations.
        }
    }
}
