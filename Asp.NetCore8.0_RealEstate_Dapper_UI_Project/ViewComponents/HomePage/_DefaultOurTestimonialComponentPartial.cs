using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.BottomGridDTOs;
using Asp.NetCore8._0_RealEstate_Dapper_UI_Project.DTOs.TestimonialDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore8._0_RealEstate_Dapper_UI_Project.ViewComponents.HomePage
{
    public class _DefaultOurTestimonialComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44309/api/Testimonials");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
