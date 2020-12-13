using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsSchool { get; set; }
        public List<Department> Departments { get; set; }

        public List<Student> Students { get; set; }
    }
}
