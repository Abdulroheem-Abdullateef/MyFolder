using System;
using System.Collections.Generic;
using System.Security.Claims;
using ApiProject.Dtos;
using ApiProject.Interfaces.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userservice;

        public UserController(IUserService userservice)
        {
            _userservice = userservice;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            var user = _userservice.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _userservice.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userservice.GetAll();
            return View(users);
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(UserLogInModel request)
        {
            var user = _userservice.LogIn(request);            
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Data.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Data.Email),   
                    new Claim(ClaimTypes.Name, user.Data.FirstName),                               
                };
                foreach (var item in user.Data.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item.RoleName));
                }
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);

                foreach (var asd in user.Data.Roles)
                {
                    if (asd.RoleName == "Admin")
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    if (asd.RoleName == "Patient")
                    {
                        return RedirectToAction("Index", "Patient");
                    }
                    if (asd.RoleName == "Doctor")
                    {
                        return RedirectToAction("Index", "Doctor");
                    }
                     if (asd.RoleName == "Hospital")
                    {
                        return RedirectToAction("Index", "Hospital");
                    }
                    //Console.WriteLine(asd);
                }
            }
            ViewBag.error = "Invalid Email or password";
            return View();
            
        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}