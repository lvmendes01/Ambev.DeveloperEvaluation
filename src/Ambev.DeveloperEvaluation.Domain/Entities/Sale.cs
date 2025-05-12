using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public Guid SaleNumber { get; set; }
        private DateTime _saleDate;
        public DateTime SaleDate
        {
            get => _saleDate;
            set => _saleDate = DateTime.SpecifyKind(value, DateTimeKind.Unspecified);
        }

        public string Customer { get; set; }
        public decimal TotalAmount { get; set; }

        public string Branch { get; set; }
        public List<SaleItem> Items { get; set; } = new();
        public bool IsCancelled { get; set; }
    }

    
}
