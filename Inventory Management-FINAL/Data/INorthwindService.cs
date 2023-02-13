namespace Inventory_Management_FINAL.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>?> GetOrders();
    }
}