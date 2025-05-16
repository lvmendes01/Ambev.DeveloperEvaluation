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
        public decimal Discount
        {
            get { return CalculateDiscount(); }
        }
        private decimal _totalAmount;

        [NotMapped]
        public decimal TotalAmount
        {
            get { return _totalAmount - CalculateDiscount(); }
            set { _totalAmount = value; }
        }
        //### Business Rules

        //* Purchases above 4 identical items have a 10% discount
        //* Purchases between 10 and 20 identical items have a 20% discount
        //* It's not possible to sell above 20 identical items
        //* Purchases below 4 items cannot have a discount

        public decimal CalculateDiscount()
        {
            //* It's not possible to sell above 20 identical items
            if (Quantity > 20)
            {
                throw new InvalidOperationException("Cannot sell more than 20 identical items.");
            }

            //* Purchases below 4 items cannot have a discount
            decimal discount = 0;
            if (Quantity >= 10 && Quantity <= 20)
            {
                discount = 0.20m; //* Purchases between 10 and 20 identical items have a 20% discount
            }
            else if (Quantity > 4)
            {
                discount = 0.10m; //* Purchases above 4 identical items have a 10% discount
            }

            decimal total = Quantity * UnitPrice;
            return total - (total * discount);
        }


    }
}
