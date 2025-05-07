namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale.Request
{
    public class CreateSaleItemRequest
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
