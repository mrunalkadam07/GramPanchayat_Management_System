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
        public DbSet<GramPanchayat_MigrationProject.API.Models.DeadBirth> DeadBirthReg {get; set;}
        public DbSet<GramPanchayat_MigrationProject.API.Models.DeathRegistration> DeathReg {get; set;}

        public DbSet<GramPanchayat_MigrationProject.API.Models.Birth> BirthReg {get; set;}
        public DbSet<GramPanchayat_MigrationProject.API.Models.PropertyTaxPaid> TaxPaid {get; set;}
        public DbSet<GramPanchayat_MigrationProject.API.Models.Assasment> Assasmenttax {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
        }
    }
    //     protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Login1>(entity =>
    //     {
    //         entity
    //             .HasNoKey()
    //             .ToTable("login1");

    //         entity.Property(e => e.Pass)
    //             .HasMaxLength(50)
    //             .HasColumnName("pass");
    //         entity.Property(e => e.User)
    //             .HasMaxLength(50)
    //             .HasColumnName("user");
    //     });

    //     // modelBuilder.Entity<DeathReg>(entity =>
    //     // {
    //     //     entity
    //     //         .HasNoKey()
    //     //         .ToTable("DeathReg");

    //     //     entity.Property(e => e.CityVillege).HasMaxLength(50);
    //     //     entity.Property(e => e.DateOfDeath).HasColumnType("datetime");
    //     //     entity.Property(e => e.Dist).HasMaxLength(50);
    //     //     entity.Property(e => e.MotherFatherHusbandName).HasMaxLength(50);
    //     //     entity.Property(e => e.NameAndAddressOfDeathSenderPerson).HasMaxLength(50);
    //     //     entity.Property(e => e.NameOfDeathPerson).HasMaxLength(50);
    //     //     entity.Property(e => e.NameOfRegistar).HasMaxLength(50);
    //     //     entity.Property(e => e.PermentAddressOfDeathPerson).HasMaxLength(50);
    //     //     entity.Property(e => e.PlaceOfDeath).HasMaxLength(50);
    //     //     entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
    //     //     entity.Property(e => e.Sex).HasMaxLength(50);
    //     //     entity.Property(e => e.Taluko).HasMaxLength(50);
    //     // });

    //     // modelBuilder.Entity<DeadBirthreg>(entity =>
    //     // {
    //     //     entity
    //     //         .HasNoKey()
    //     //         .ToTable("DeadBirthreg");

    //     //     entity.Property(e => e.Address).HasMaxLength(50);
    //     //     entity.Property(e => e.BirthPlace).HasMaxLength(50);
    //     //     entity.Property(e => e.CityVillege).HasMaxLength(50);
    //     //     entity.Property(e => e.DeadBirthDate).HasColumnType("datetime");
    //     //     entity.Property(e => e.Dist).HasMaxLength(50);
    //     //     entity.Property(e => e.FatherName).HasMaxLength(50);
    //     //     entity.Property(e => e.MotherName).HasMaxLength(50);
    //     //     entity.Property(e => e.NameAndAddressOfDetailSendesPerson).HasMaxLength(50);
    //     //     entity.Property(e => e.NameOfRegistar).HasMaxLength(50);
    //     //     entity.Property(e => e.RegistretionDate).HasColumnType("datetime");
    //     //     entity.Property(e => e.Sex).HasMaxLength(50);
    //     //     entity.Property(e => e.Taluko).HasMaxLength(50);
    //     // });

    //     OnModelCreatingPartial(modelBuilder);
    // }

    //     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    // }

    }
}
    
