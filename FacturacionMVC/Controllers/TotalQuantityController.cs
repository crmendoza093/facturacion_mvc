using System.Collections.Generic;
using FacturacionMVC.Models;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace FacturacionMVC.Controllers
{
    public class TotalQuantityController : Controller
    {
        private const string URL = "http://localhost:54161/api/Orders/GetTotalQuantity";
        static readonly HttpClient client = new HttpClient();

        // GET: PriceList
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            List<TotalQuantity> customers = (new JavaScriptSerializer()).Deserialize<List<TotalQuantity>>(response.Content.ReadAsStringAsync().Result);

            return View(customers);
        }
    }
}
