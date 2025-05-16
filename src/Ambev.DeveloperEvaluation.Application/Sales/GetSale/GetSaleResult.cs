using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public class GetSaleResult
{
    /// <summary>
    /// The unique identifier of the Sale
    /// </summary>
    public Guid Id { get; set; }


    public DateTime SaleDate { get; set; }
    public string Customer { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
    public string Branch { get; set; } = string.Empty;
    public List<GetSaleItemResult> Items { get; set; } = new();
    public bool IsCancelled { get; set; }

}


public class GetSaleItemResult
{

    public Guid Id { get; set; }

    public string Product { get; set; }
    public int Quantity { get; set; }
    public Guid SaleId { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    private decimal _totalAmount;

}