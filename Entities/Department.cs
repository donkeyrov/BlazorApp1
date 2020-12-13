using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public School School { get; set; }
        public List<Programme> Programmes { get; set; }
        public List<Student> Students { get; set; }
        
    }
}
