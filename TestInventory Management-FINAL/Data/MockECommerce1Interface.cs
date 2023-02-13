namespace Inventory_Management_FINAL.ECommerce1
{
    public class MockECommerce1Service : IECommerce1Service
    {
        public Task<List<RevenueType>?> GetRevenue()
        {
            return Task.FromResult<List<RevenueType>?>(new());
        }
    }
}