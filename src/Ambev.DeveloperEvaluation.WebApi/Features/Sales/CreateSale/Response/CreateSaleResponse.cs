namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale.Response
{
    public class CreateSaleResponse
    {
        public Guid SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Customer { get; set; }
        public string Branch { get; set; }
        public decimal TotalAmount { get; set; }
        public List<CreateSaleItemResponse> Items { get; set; } = new();
    }
}
