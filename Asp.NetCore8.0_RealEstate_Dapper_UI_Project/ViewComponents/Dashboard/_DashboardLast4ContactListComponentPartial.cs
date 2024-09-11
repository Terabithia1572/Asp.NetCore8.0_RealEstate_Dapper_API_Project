using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.ContactDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.ViewComponents.Dashboard
{
    public class _DashboardLast4ContactListComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4ContactListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Contacts/GetLast4Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4ContactResultDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
