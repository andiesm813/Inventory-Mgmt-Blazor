namespace Inventory_Management_FINAL.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<OrdersType>?> GetOrders()
        {
            return Task.FromResult<List<OrdersType>?>(new());
        }
    }
}