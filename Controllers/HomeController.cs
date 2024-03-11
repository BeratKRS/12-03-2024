using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lessons.Models;
using Lessons.Models.Entities;

namespace Lessons.Controllers;

public class HomeController : Controller
{
    private readonly storeContext dbContext = new storeContext();

    public HomeController(storeContext _dbContext)
    {
        dbContext = _dbContext;
    }

    public IActionResult Index()
    {
        var Peoples = dbContext.Customers.ToList();
        return View(Peoples);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
