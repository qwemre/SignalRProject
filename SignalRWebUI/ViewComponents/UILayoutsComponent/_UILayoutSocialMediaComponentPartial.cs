using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Controllers;
using SignalRWebUI.Dtos.SocialMediaDtos;
using System.Net.Http;
using System.Text;

namespace SignalRWebUI.ViewComponents.UILayoutsComponent
{
    public class _UILayoutSocialMediaComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
            public _UILayoutSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }

            public async Task< IViewComponentResult> InvokeAsync()
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7229/api/SocialMedia");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
                    return View(values);

                }
                return View();

            }
           
        }
}