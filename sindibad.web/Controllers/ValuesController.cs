using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;



namespace sindibad.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {

        private IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet("functionApp")]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            var functionAppUrl = _configuration["SandibadFunctionAppUrl"];
            string ApiUrl = $"{functionAppUrl}?name={name}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Make a GET request to the specified API
                    HttpResponseMessage response = await client.GetAsync(ApiUrl);

                    // Check if the request was successful (status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and return the response content as a string
                        string responseData = await response.Content.ReadAsStringAsync();
                        return Ok(responseData);
                    }
                    else
                    {
                        // Return the status code and reason phrase
                        return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the request
                return Problem(ex.Message);
            }
        }
    }
}