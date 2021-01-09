using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCartMVCLab1.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
new Category
{
    CategoryId=101,
    Name="Web Development",
    Description="All Client-side Courses."
},
new Category
{
    CategoryId=102,
    Name="Software Development",
    Description="All server-side Courses."
},
new Category
{
    CategoryId=103,
    Name="Data Science",
    Description="All DataScience Courses."
}
        };
    }
}
