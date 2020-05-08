using System.Collections.Generic;
using FacturacionMVC.Models;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace FacturacionMVC.Controllers
{
    public class ProductInStockController : Controller
    {
        private const string URL = "http://localhost:54161/api/Stocks/GetStock";
        static readonly HttpClient client = new HttpClient();

        // GET: PriceList
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<ProductsInStock> customers = (new JavaScriptSerializer()).Deserialize<List<ProductsInStock>>(response.Content.ReadAsStringAsync().Result);

            return View(customers);
        }
    }
}
