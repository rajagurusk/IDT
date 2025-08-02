using IDT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string userid, string password)
    {
        if (userid == "IDT" && password == "Idt@1234")
        {
            {
                TempData["Success"] = "Logged in successfully!";
                return RedirectToAction("HomePage", "Home");
            }
        }
        else
        {
            TempData["Error"] = "Invalid user ID or password";
            return View("Index");
        }
    }
    public IActionResult HomePage()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
