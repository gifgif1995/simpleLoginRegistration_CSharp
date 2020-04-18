using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleLoginRegistration.Models;

namespace simpleLoginRegistration.Controllers {
    public class HomeController : Controller {

        [HttpGet("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost("registration")]
        public IActionResult Registration (RegistrationModel newRegistration) {
            if (ModelState.IsValid) {
                return RedirectToAction ("Success");
            }
            return View ("Index");
        }

        [HttpPost("login")]
        public IActionResult Login (LoginModel newLogin) {
            if (ModelState.IsValid) {
                return RedirectToAction ("Success");
            }
            return View ("Index");
        }

        [HttpGet("success")]
        public IActionResult Success () {
            return View ("Success");
        }
    }
}