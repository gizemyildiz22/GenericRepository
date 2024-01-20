using GenericRepository.Context;
using GenericRepository.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IUserService _userService;

        public HomeController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("AddUser")]
        [AllowAnonymous]
        public IActionResult AddUser(User user )
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {

            return View();

        }
    }
}
