using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.WhoWeAreDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/WhoWeAreDetail");
            if(responseMessage.IsSuccessStatusCode)
            {
               var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDTO>>(jsonData);
                ViewBag.Title = values.Select(x=>x.Title).FirstOrDefault();
                ViewBag.Subtitle = values.Select(x=>x.Subtitle).FirstOrDefault();
                ViewBag.Description1 = values.Select(x=>x.Description1).FirstOrDefault();
                ViewBag.Description2 = values.Select(x=>x.Description2).FirstOrDefault();
                return View();
            }
        return View();
        }
    }
}
