using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Entities
{
    public class Programme
    {
        [Key]
        public int Id { get; set; }        
        public int SchoolId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        [ForeignKey("ProgrammeLevel")]
        public int ProgrammeLevelId { get; set; }
        [ForeignKey("StudyCategory")]
        public int StudyCategoryId { get; set; }
        public bool Active { get; set; }
        public School School { get; set; }
        public ProgrammeLevel ProgrammeLevel { get; set; }
        public StudyCategory StudyCategory { get; set; }
        public List<Student> Students { get; set; }
    }
}
