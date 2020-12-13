using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Entities
{
    public class AcademicYear
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Semester { get; set; }
        public int NextAcademicYearId { get; set; }
    }
}
