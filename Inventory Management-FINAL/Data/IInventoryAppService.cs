namespace Inventory_Management_FINAL.InventoryApp
{
    public interface IInventoryAppService
    {
        Task<List<NewProductsType>?> GetNewProducts();

        Task<List<ProductsType>?> GetProducts();
    }
}