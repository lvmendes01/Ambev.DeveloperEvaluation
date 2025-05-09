using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleItem : BaseEntity
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public Guid SaleId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        private decimal _totalAmount;

        [NotMapped]
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
    }
}
