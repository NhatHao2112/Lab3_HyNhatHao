using Lab3_HyNhatHao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_HyNhatHao.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}