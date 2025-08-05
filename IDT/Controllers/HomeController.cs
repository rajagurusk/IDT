using IDT.Data;
using IDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;
    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;

    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string UserId, string Password)
    {
        var user = _context.Users.FirstOrDefault(u => u.UserId == UserId && u.Password == Password);
        if (user != null)
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
