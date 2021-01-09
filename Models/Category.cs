using System.Collections.Generic;

namespace ShopCartMVCLab1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Course> Course { get; set; }
    }
}