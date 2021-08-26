using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OmniWMS.Infrastructure.CustomModels;
using OmniWMS.Infrastructure.Models;

namespace OmniWMS.Infrastructure.CustomeModels
{
    public partial class CustomWMSDbContext : WMSDB_PWBContext
    {
        public CustomWMSDbContext(DbContextOptions<WMSDB_PWBContext> options)
    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ViewCheckShort>().HasNoKey();
        }
    }
}
