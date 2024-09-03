using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            var client= _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(createCategoryDTO);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:44309/api/Categories", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

