using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace kodeordsmanager.api.Controllers
{
    /// <summary>
    ///    Håndtering af kodeord og applikationer
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PasswordApplicationManager : ControllerBase
    {
        /// <summary>
        ///     Hent alt
        /// </summary>
        [HttpGet, Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
    }
}