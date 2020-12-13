using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Entities
{
    public class BlazorDbContext : DbContext
    {
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<ProgrammeLevel> ProgrammeLevels { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudyCategory> StudyCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilders)
        {
            optionsBuilders.UseSqlServer(@"Data Source=DESKTOP-ROG8LBJ;Initial Catalog=DemoDB;Integrated Security=True;MultipleActiveResultSets=true;Connection Timeout=180");
        }
    }
}
