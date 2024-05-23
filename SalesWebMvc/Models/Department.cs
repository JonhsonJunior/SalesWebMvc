using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public ICollection<Seller>? Sellers { get; set; }
    }
}
