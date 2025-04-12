using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.ProductDetailDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDTO>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ProperySingle(int id)
        {
            ViewBag.i = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Products/GetProductByProductID?id=" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDTO>(jsonData);

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44309/api/ProductDetails/GetProductDetailByProductID?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailByIDDTO>(jsonData2);
            
            ViewBag.title1 = values.ProductTitle.ToString();
            ViewBag.price = values.ProductPrice;
            ViewBag.city = values.ProductCity;
            ViewBag.district = values.ProductDistrict;
            ViewBag.address = values.ProductAddress;
            ViewBag.type = values.ProductType;
            ViewBag.datediff = GetTimeAgo(values.ProductAdvertisementDate); // <-- Burası güncellendi
            ViewBag.bathCount = values2.ProductBathCount;
            ViewBag.bedCount = values2.ProductBedRoomCount;
            ViewBag.size = values2.ProductSize;
            ViewBag.description = values.ProductDescription;
            ViewBag.productID = values.ProductID;
            ViewBag.roomCount = values2.ProductRoomCount;
            ViewBag.garageCount = values2.ProductGarageSize;
            ViewBag.buildYear = values2.ProductBuildYear;
            ViewBag.date=values.ProductAdvertisementDate.ToString("dd/MM/yyyy");
            ViewBag.location = values2.ProductLocation;
            ViewBag.videoURL = values2.ProductVideoURL;

            return View();
        }
        public async Task<IActionResult> PropertyListWithSearch(string searchKeyValue, int propertyCategoryID, string city)
        {
         
            searchKeyValue = TempData["searchKeyValue"].ToString();
            propertyCategoryID = int.Parse((TempData["propertyCategoryID"]).ToString());
            city = TempData["city"].ToString();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Products/ResultProductWithSearchList?searchKeyValue=" + searchKeyValue + "&propertyCategoryID=" + propertyCategoryID + "&city=" + city);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchListDTO>>(jsonData);
                return View(values);
            }
            return View();
        }

        private string GetTimeAgo(DateTime dateTime)
        {
            var timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalMinutes < 1)
                return "az önce eklendi";
            else if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} dakika önce eklendi";
            else if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} saat önce eklendi";
            else if (timeSpan.TotalDays < 30)
                return $"{(int)timeSpan.TotalDays} gün önce eklendi";
            else if (timeSpan.TotalDays < 365)
                return $"{(int)(timeSpan.TotalDays / 30)} ay önce eklendi";
            else
                return $"{(int)(timeSpan.TotalDays / 365)} yıl önce eklendi";
        }

    }
}
