using System.Linq;
using System.Threading.Tasks;
using AMIS3610.GroupProject.Api.Data;
using AMIS3610.GroupProject.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AMIS3610.GroupProject.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private IConfiguration configuration;

        public AccountController(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager, 
            IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] ApplicationUser registration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            ApplicationUser user = new ApplicationUser
            {
                Email = registration.Email,
                UserName = registration.Email,
                Id = registration.Email
            };

            IdentityResult result = await userManager.CreateAsync(user, registration.Password);

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(err.Code, err.Description);
                }

                return BadRequest(ModelState);
            }
            return Ok();
        }
    }

}