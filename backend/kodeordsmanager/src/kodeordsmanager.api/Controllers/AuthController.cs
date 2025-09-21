using kodeordsmanager.api.DTOs;
using kodeordsmanager.application.Auth;
using Microsoft.AspNetCore.Mvc;

namespace kodeordsmanager.api.Controllers
{
    /// <summary>
    ///    Autentifikation af brugere
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        /// <summary>
        ///     Kontroller om brugeren kan logge ind og returner et JWT token hvis det er tilfældet
        /// </summary>
        [HttpPost, Route("login")]
        public async Task<IActionResult> Login([FromBody] UserDTO request)
        {
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Email or Password cannot be empty.");
            }

            var user = await authService.Login(request.Email, request.Password);

            if (!user.IsAuthenticated)
                return Unauthorized(user.Status);

            return Ok(new AuthDTO
            {
                Token = user.JwtToken,
                ExpiresIn = user.ExpiresIn
            });
        }
    }
}