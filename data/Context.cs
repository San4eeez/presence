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

        public DbSet<Groups> Groups { get; set; }

        public DbSet<students> students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Groups>().HasKey(it => it.Groups_id);
            modelBuilder.Entity<subject>().HasKey(it => it.subject_id);
            modelBuilder.Entity<semesters>().HasKey(it => it.semesters_id);
            modelBuilder.Entity<students>().HasKey(it => it.students_id);
            modelBuilder.Entity<attendance>().HasKey(it => it.attendance_id);
            modelBuilder.Entity<status>().HasKey(it => it.status_id);
            modelBuilder.Entity<GroupSemesters>().HasKey(it => it.group_semester_id);
            modelBuilder.Entity<GroupSubjects>().HasKey(it => it.GroupSubjects_id);

            modelBuilder.Entity<Groups>().Property(it => it.Groups_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<subject>().Property(it => it.subject_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<semesters>().Property(it => it.semesters_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<students>().Property(it => it.students_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<attendance>().Property(it => it.attendance_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<status>().Property(it => it.status_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<GroupSemesters>().Property(it => it.group_semester_id).ValueGeneratedOnAdd();
            modelBuilder.Entity<GroupSubjects>().Property(it => it.GroupSubjects_id).ValueGeneratedOnAdd();












        }




    }
}
