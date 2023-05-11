using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetIdentityRoleBasedTutorial.Data;
using AspnetIdentityRoleBasedTutorial.Services.User;

namespace AspnetIdentityRoleBasedTutorial.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> UserList()
        {
            return View(await _userService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetById(id);
            return View(user);
        }


    }

}
