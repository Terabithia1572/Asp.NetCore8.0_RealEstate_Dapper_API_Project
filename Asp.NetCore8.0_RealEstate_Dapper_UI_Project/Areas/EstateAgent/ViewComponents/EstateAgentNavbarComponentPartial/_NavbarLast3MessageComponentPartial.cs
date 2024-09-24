using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.MessageDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.Areas.EstateAgent.ViewComponents.EstateAgentNavbarComponentPartial
{
    public class _NavbarLast3MessageComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;

        public _NavbarLast3MessageComponentPartial(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }
        public async Task< IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserID;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Messages?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultInboxMessageDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
