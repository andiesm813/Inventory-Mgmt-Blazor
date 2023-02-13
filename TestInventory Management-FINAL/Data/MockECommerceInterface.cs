namespace Inventory_Management_FINAL.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<SalesType>?> GetSales()
        {
            return Task.FromResult<List<SalesType>?>(new());
        }
    }
}