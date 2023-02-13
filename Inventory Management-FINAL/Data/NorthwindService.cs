using System.Net.Http.Json;

namespace Inventory_Management_FINAL.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<OrdersType>?> GetOrders()
        {
            return await this._http.GetFromJsonAsync<List<OrdersType>>("/static-data/northwind-orders.json");
        }
    }
}