using System.Net.Http.Json;

namespace Inventory_Management_FINAL.InventoryApp
{
    public class InventoryAppService: IInventoryAppService
    {
        private readonly HttpClient _http;

        public InventoryAppService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<NewProductsType>?> GetNewProducts()
        {
            return await this._http.GetFromJsonAsync<List<NewProductsType>>("https://excel2json.io/api/share/4b54e7f8-927a-4a38-e690-08dab79fa5b4");
        }

        public async Task<List<ProductsType>?> GetProducts()
        {
            return await this._http.GetFromJsonAsync<List<ProductsType>>("https://excel2json.io/api/share/22b3aaa8-bba3-43cb-e68f-08dab79fa5b4");
        }
    }
}