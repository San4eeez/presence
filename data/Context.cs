using data.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=45.67.56.214;Port=5454;Username=user14;Password=PPFlStRD");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<students>().HasKey(it => it.id);
            modelBuilder.Entity<Groups>().HasKey(it => it.id);
            modelBuilder.Entity<subject>().HasKey(it => it.id);
            modelBuilder.Entity<semesters>().HasKey(it => it.id);
            modelBuilder.Entity<students>().HasKey(it => it.id);
            modelBuilder.Entity<attendance>().HasKey(it => it.id);
            modelBuilder.Entity<GroupSemesters>().HasKey(it => new { it.group_semester_id,it.group_id,it.semester_id });




        }




    }
}
