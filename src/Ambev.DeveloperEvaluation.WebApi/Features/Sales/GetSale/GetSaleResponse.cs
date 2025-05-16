using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sale.GetUser;

/// <summary>
/// API response model for GetUser operation
/// </summary>
public class GetSaleResponse
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

    public DateTime SaleDate { get; set; }
    public string Customer { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
    public string Branch { get; set; } = string.Empty;
    public List<GetSaleItemResponse> Items { get; set; } = new();
    public bool IsCancelled { get; set; }

}


public class GetSaleItemResponse
{

    public Guid Id { get; set; }

    public string Product { get; set; }
    public int Quantity { get; set; }
    public Guid SaleId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    private decimal _totalAmount;

}