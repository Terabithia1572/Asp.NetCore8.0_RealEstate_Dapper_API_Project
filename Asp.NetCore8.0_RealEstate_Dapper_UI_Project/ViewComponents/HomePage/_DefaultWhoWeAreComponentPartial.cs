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
            var client2=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/WhoWeAreDetail");
            var responseMessage2 = await client2.GetAsync("https://localhost:44309/api/Services");
            if(responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
               var jsonData=await responseMessage.Content.ReadAsStringAsync();
               var jsonData2=await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDTO>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultServiceDTO>>(jsonData2);
                ViewBag.Title = values.Select(x=>x.Title).FirstOrDefault();
                ViewBag.Subtitle = values.Select(x=>x.Subtitle).FirstOrDefault();
                ViewBag.Description1 = values.Select(x=>x.Description1).FirstOrDefault();
                ViewBag.Description2 = values.Select(x=>x.Description2).FirstOrDefault();
                return View(values2);
            }
        return View();
        }
    }
}
