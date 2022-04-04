using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PriutWebAPI.Models
{
    public partial class ADO : DbContext
    {
        public ADO()
            : base("name=ADO1")
        {
        }

        public virtual DbSet<Dog> Dog { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
