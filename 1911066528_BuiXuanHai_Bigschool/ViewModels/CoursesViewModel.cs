using _1911066528_BuiXuanHai_Bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911066528_BuiXuanHai_Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }

        public bool ShowAction { get; set; }
    }
}