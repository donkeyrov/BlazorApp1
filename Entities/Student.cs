using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string  StudentId { get; set; }
        public int SchoolId { get; set; }
        public int DepartmentId { get; set; }
        public int ProgrammeId { get; set; }
        public int AcademicYearId { get; set; }
        public bool Active { get; set; }
        public School School { get; set; }
        public Department Department { get; set; }
        public Programme Programme { get; set; }
        public AcademicYear AcademicYear { get; set; }
    }
}
