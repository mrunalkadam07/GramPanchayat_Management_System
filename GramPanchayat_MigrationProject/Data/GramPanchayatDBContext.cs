using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.Database;

namespace GramPanchayat_MigrationProject.API.Data
{
    public partial class GramPanchayatDBContext : DbContext
    {
        public GramPanchayatDBContext(DbContextOptions<GramPanchayatDBContext> options): base(options) 
        {
            
        }

        public DbSet<LoginModel> Login1 { get; set; }
        public DbSet<MarriageRegModel> MarriageReg {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
        }
    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("login1");

            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .HasColumnName("pass");
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .HasColumnName("user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

    }
    
