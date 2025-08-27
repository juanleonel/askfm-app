using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using askfm.Models;
using askfm.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace askfm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IComment _commentService;
    private readonly IUser _userService;
    public HomeController(ILogger<HomeController> logger, IComment commentService, IUser userService)
    {
        _logger = logger;
        _commentService = commentService;
        _userService = userService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]

    public async Task<IActionResult> Search(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return View("Index");
        }

        var result = await _userService.GetUsers(query.Trim());

        ViewBag.Query = query;

        return View("Search", result);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
