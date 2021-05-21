using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProfileMVCProject.Models;
namespace ProfileMVCProject.Models
{
    public class ProfileContext : DbContext
    {
        public ProfileContext():base()
        {

        }
        public ProfileContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Profile> Profile { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile() { PersonId = 1,Name="abi",age=21,qualification="B.E",IsEmployed="yes",NoticePeriod=3,CurrentCTC=3 }) ;
        }


    }
    }

   