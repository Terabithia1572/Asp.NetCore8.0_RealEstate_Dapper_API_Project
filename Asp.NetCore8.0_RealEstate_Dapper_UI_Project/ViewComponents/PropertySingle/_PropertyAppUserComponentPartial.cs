using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.AppUserDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.PropertyImgeDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.ViewComponents.PropertySingle
{
    public class _PropertyAppUserComponentPartial:ViewComponent
    {
            private readonly IHttpClientFactory _httpClientFactory;

            public _PropertyAppUserComponentPartial(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }
            public async Task<IViewComponentResult> InvokeAsync()
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:44309/api/AppUsers?id=1");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<GetAppUserByProductIDDTO>(jsonData);
                    return View(values);
                }
                return View();
            }
        }
    }
