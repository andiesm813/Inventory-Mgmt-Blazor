namespace Inventory_Management_FINAL.ECommerce
{
    public interface IECommerceService
    {
        Task<List<SalesType>?> GetSales();
    }
}