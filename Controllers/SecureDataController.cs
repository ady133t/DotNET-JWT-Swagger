using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_WebAPI_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureDataController : ControllerBase
    {

        [Authorize] // Requires a valid JWT token
        [HttpGet("secure")]
        public IActionResult GetSecureData()
        {
            return Ok("This is secure data only accessible to authenticated users.");
        }

        [Authorize(Roles = "User")] // Requires an Admin role
        [HttpGet("admin")]
        public IActionResult GetAdminData()
        {
            return Ok("This data is accessible only to Admin role users.");
        }
    }
}
