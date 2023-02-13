using System.Net.Http.Json;

namespace Inventory_Management_FINAL.ECommerce1
{
    public class ECommerce1Service: IECommerce1Service
    {
        private readonly HttpClient _http;

        public ECommerce1Service(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<RevenueType>?> GetRevenue()
        {
            return await this._http.GetFromJsonAsync<List<RevenueType>>("https://excel2json.io/api/share/03e74dde-d2e1-4fee-437d-08da496bf5f2");
        }
    }
}