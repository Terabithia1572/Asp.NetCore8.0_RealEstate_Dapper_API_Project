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
            #region Statistics1
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage = await client1.GetAsync("https://localhost:44309/api/Statistics/ActiveCategoryCount");
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveCategoryCount = jsonData;
            #endregion
            #region Statistics2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client1.GetAsync("https://localhost:44309/api/Statistics/ActiveEmployeeCount\r\n");
            var jsonData2 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData;
            #endregion
            #region Statistics3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client1.GetAsync("https://localhost:44309/api/Statistics/ApartmentCount\r\n");
            var jsonData3 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData;
            #endregion
            #region Statistics4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client1.GetAsync("https://localhost:44309/api/Statistics/AverageProductPriceByRent\r\n");
            var jsonData4 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceByRent = jsonData;
            #endregion
            #region Statistics5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client1.GetAsync("https://localhost:44309/api/Statistics/AverageProductPriceBySale\r\n\r\n");
            var jsonData5 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceBySale = jsonData;
            #endregion
            #region Statistics6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client1.GetAsync("https://localhost:44309/api/Statistics/AverageRoomCount\r\n\r\n\r\n");
            var jsonData6 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.AverageRoomCount = jsonData;
            #endregion
            #region Statistics7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client1.GetAsync("https://localhost:44309/api/Statistics/CategoryCount\r\n\r\n\r\n\r\n");
            var jsonData7 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData;
            #endregion
            return View();
        }
    }
}
