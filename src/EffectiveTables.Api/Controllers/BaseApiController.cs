using Microsoft.AspNetCore.Mvc;

namespace EffectiveTables.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
    }
}