namespace Inventory_Management_FINAL.ECommerce1
{
    public interface IECommerce1Service
    {
        Task<List<RevenueType>?> GetRevenue();
    }
}