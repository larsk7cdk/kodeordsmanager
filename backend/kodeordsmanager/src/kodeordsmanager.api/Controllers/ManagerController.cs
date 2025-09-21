using kodeordsmanager.application.Manager;
using kodeordsmanager.contracts.DTOs;
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
    public class ManagerController(IManagerService managerService) : ControllerBase
    {
        /// <summary>
        ///     Hent alle applikationer og deres kodeord for en given bruger
        /// </summary>
        [HttpPost, Route("GetAll")]
        public async Task<IActionResult> GetAllAsync([FromBody] UserManagerDTO request)
        {
            var apps = await managerService.GetAllAsync(request.Email);

            return Ok(new ManagerDTO
            {
                Email = apps.Email,
                Applications = apps.ManagerApplications.Select(s => new ManagerApplicationDTO
                {
                    Name = s.Name,
                    Password = s.Password
                }).ToList()
            });
        }
    }
}