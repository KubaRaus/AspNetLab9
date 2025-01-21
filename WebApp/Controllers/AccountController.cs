using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "user" && password == "user1")
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Actors");
            }

            ViewBag.Error = "Nieprawidłowa nazwa użytkownika lub hasło.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            return RedirectToAction("Index", "Home");
        }
    }
}