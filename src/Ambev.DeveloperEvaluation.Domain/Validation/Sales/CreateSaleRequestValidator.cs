using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation.Sales
{
    public class CreateSaleRequestValidator : AbstractValidator<Sale>
    {
        public CreateSaleRequestValidator()
        {
            RuleFor(x => x.SaleDate)
                .NotEmpty().WithMessage("The sale date is required.");

            RuleFor(x => x.Customer)
                .NotEmpty().WithMessage("The customer name is required.")
                .MaximumLength(100).WithMessage("The customer name must not exceed 100 characters.");

            RuleFor(x => x.Branch)
                .NotEmpty().WithMessage("The branch name is required.")
                .MaximumLength(100).WithMessage("The branch name must not exceed 100 characters.");

            RuleFor(x => x.Items)
                .NotEmpty().WithMessage("The sale must contain at least one item.")
                .ForEach(item =>
                {
                    item.SetValidator(new CreateSaleItemRequestValidator());
                });
        }
    }
}
