//namespace Inventory_Management_FINAL.Data.InventoryApp; // Razor won't recognize third level namespace
namespace Inventory_Management_FINAL.InventoryApp;

public class ProductsType
{
    public string? Product { get; set; }
    public string? Department { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? ImageURL { get; set; }
}
