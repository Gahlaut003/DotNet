using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CloudFunctionApiController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CloudFunctionApiController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
    }

    [HttpGet]
    public async Task<IActionResult> CallCloudFunction()
    {
        // Replace "YOUR_CLOUD_FUNCTION_URL" with the actual URL of your Cloud Function
        string cloudFunctionUrl = "https://us-central1-linear-pursuit-411707.cloudfunctions.net/gcloudtestfunction";

        try
        {
            using (HttpClient client = _httpClientFactory.CreateClient("CloudFunctionClient"))
            {
                HttpResponseMessage response = await client.GetAsync(cloudFunctionUrl);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return Ok(result);
                }

                return StatusCode((int)response.StatusCode, $"Error: {response.ReasonPhrase}");
            }
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(500, $"Error: {ex.Message}");
        }
    }
}
