using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TSUViewEngine.Models;

namespace TSUViewEngine.Controllers
{
    public class AuthController : Controller
    {

        private readonly IUserRepository _userRepository;
        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(UserVM model)
        {
            if (ModelState.IsValid)
            {

                if (_userRepository.ExistsEmail(model.Email))
                {
                    ModelState.AddModelError("", "ელ.ფოსტა უკვე რეგისტრირებულია");
                    return View(model);
                }

                User user = new User
                {
                    Name = model.Name,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    Password = model.Password
                };

                _userRepository.Create(user);
                return View();
            }
          

            return View(model);
        }
    }
}