using Microsoft.AspNetCore.Mvc;
using APIKeyManager.Services;

namespace APIKeyManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiKeyController : ControllerBase
    {
        private readonly IApiKeyService _apiKeyService;

        public ApiKeyController(IApiKeyService apiKeyService)
        {
            _apiKeyService = apiKeyService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_apiKeyService.GetApiKeys());
        }

        [HttpPost]
        public ActionResult Add([FromBody] string apiKey)
        {
            _apiKeyService.AddApiKey(apiKey);
            return Ok("API Key added");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _apiKeyService.DeleteApiKey(id);
            return Ok("API Key deleted");
        }
    }
}
