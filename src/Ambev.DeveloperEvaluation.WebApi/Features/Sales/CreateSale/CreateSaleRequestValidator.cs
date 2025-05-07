using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale.Request;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;


public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
   
    public CreateSaleRequestValidator()
    {
        RuleFor(user => user.Branch).NotEmpty();
    }
}