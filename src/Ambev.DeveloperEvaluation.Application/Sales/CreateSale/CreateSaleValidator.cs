using FluentValidation;
namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale;
public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
 
    public CreateSaleCommandValidator()
    {       
        RuleFor(user => user.Branch).NotEmpty();
    }
}