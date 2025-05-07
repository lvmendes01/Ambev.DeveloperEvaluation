namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale.Request
{
    public class CreateSaleRequest
    {

        public DateTime SaleDate { get; set; }
        public string Customer { get; set; }
        public string Branch { get; set; }
        public List<CreateSaleItemRequest> Items { get; set; } = new();
    }



}
