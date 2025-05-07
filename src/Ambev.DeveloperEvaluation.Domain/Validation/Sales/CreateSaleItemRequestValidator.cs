using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation.Sales
{
    public class CreateSaleItemRequestValidator : AbstractValidator<SaleItem>
    {
        public CreateSaleItemRequestValidator()
        {
            RuleFor(x => x.Product)
                .NotEmpty().WithMessage("The product name is required.")
                .MaximumLength(100).WithMessage("The product name must not exceed 100 characters.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("The quantity must be greater than zero.")
                .LessThanOrEqualTo(20).WithMessage("The quantity must not exceed 20.");

            RuleFor(x => x.UnitPrice)
                .GreaterThan(0).WithMessage("The unit price must be greater than zero.");
        }
    }
}
