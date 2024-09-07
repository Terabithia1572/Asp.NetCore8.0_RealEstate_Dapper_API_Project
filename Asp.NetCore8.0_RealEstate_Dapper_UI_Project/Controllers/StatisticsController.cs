using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region İstatistik1
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage = await client1.GetAsync("https://localhost:44309/api/Statistics/ActiveCategoryCount");
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveCategoryCount = jsonData;
            #endregion
            #region İstatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client1.GetAsync("https://localhost:44309/api/Statistics/ActiveEmployeeCount\r\n");
            var jsonData2 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData;
            #endregion
            #region İstatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client1.GetAsync("https://localhost:44309/api/Statistics/ApartmentCount\r\n");
            var jsonData3 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData;
            #endregion
            return View();
        }
    }
}
