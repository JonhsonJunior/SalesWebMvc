using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {

    public int SalesRecordId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller? Seller { get; set; }

    }
}
