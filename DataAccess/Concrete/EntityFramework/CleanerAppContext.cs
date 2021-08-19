using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CleanerAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<AdministratorHospital> AdministratorHospital { get; set; }
        public DbSet<Cleaner> Cleaners { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalIsActive> HospitalIsActives { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<LocationObject> LocationObjects { get; set; }
        public DbSet<Entities.Concrete.Object> Objects { get; set; } //diğer object ile karıştığından dolayı böyle yazıldı. tekrar bakılacak.
        public DbSet<UserIsActive> UserIsActives { get; set; }

        public CleanerAppContext(DbContextOptions<CleanerAppContext> options) : base(options)
        {

        }
    }
}