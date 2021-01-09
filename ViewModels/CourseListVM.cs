using ShopCartMVCLab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCartMVCLab1.ViewModels
{
    public class CourseListVM
    {
        public IEnumerable<Course> Courses { get; set; }
        public string SelectedCategoryName { get; set; }

    }
}
