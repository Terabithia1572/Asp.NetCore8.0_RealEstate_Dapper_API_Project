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
            var responseMessage2 = await client1.GetAsync("https://localhost:44309/api/Statistics/ActiveEmployeeCount");
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
            var responseMessage5 = await client1.GetAsync("https://localhost:44309/api/Statistics/AverageProductPriceBySale");
            var jsonData5 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceBySale = jsonData;
            #endregion
            #region Statistics6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client1.GetAsync("https://localhost:44309/api/Statistics/AverageRoomCount");
            var jsonData6 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.AverageRoomCount = jsonData;
            #endregion
            #region Statistics7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client1.GetAsync("https://localhost:44309/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData;
            #endregion
            #region Statistics8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client1.GetAsync("https://localhost:44309/api/Statistics/CategoryNameByMaxCount\r\n");
            var jsonData8 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.CategoryNameByMaxCount = jsonData;
            #endregion
            #region Statistics9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client1.GetAsync("https://localhost:44309/api/Statistics/CityNameByMaxProductCount\r\n");
            var jsonData9 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxProductCount = jsonData;
            #endregion
            #region Statistics10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client1.GetAsync("https://localhost:44309/api/Statistics/DifferentCityCount\r\n");
            var jsonData10 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData;
            #endregion
            #region Statistics11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client1.GetAsync("https://localhost:44309/api/Statistics/EmployeeNameByMaxCount\r\n");
            var jsonData11 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxCount = jsonData;
            #endregion
            #region Statistics12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client1.GetAsync("https://localhost:44309/api/Statistics/LastProductPrice\r\n");
            var jsonData12 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData;
            #endregion
            #region Statistics13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client1.GetAsync("https://localhost:44309/api/Statistics/NewestBuildingYear\r\n");
            var jsonData13 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.NewestBuildingYear = jsonData;
            #endregion
            #region Statistics14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client1.GetAsync("https://localhost:44309/api/Statistics/OldestBuildingYear\r\n");
            var jsonData14 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.OldestBuildingYear = jsonData;
            #endregion
            #region Statistics15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client1.GetAsync("https://localhost:44309/api/Statistics/PassiveCategoryCount\r\n");
            var jsonData15 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData;
            #endregion
            #region Statistics16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client1.GetAsync("https://localhost:44309/api/Statistics/ProductCount\r\n");
            var jsonData16 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData;
            #endregion
            return View();
        }
    }
}
