using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SR413POS.Models
{
    public class SaleDetail
    {
        [Key]
        public Guid SaleDetailId { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
    }
}
