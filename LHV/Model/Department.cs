using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHV.Model
{
    public class Department
    {
        [Key]
        [Required]
        public int DepartmentID {get; set;}
        public string DepartmentName {get; set;}
        public string DepartmentCode {get; set;}
        public ICollection<Student> Student {get; set;}
        public ICollection<DepartmentCourse> DepartmentCourses {get; set;}
    }
}