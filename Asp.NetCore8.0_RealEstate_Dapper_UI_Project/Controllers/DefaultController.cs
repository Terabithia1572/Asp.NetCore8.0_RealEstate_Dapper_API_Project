using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task< PartialViewResult> PartialSearch()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsonData);
                return PartialView(values);
            }
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialSearch(string p,string y)
        {
            TempData["word"] = p;
            TempData["word1"] = y;

            return RedirectToAction("PropertyListWithSearch", "Property");
        }
    }
}
