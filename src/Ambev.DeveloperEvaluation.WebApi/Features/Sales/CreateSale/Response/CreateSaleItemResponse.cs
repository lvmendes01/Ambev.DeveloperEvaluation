namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale.Response
{
    public class CreateSaleItemResponse
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
