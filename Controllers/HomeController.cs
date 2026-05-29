using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ProjZtpai.Models;

namespace ProjZtpai.Controllers;

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

    [HttpGet("ThrowUnhandled")]
    public IActionResult ThrowUnhandled() 
    {
        throw new Exception("Example Exception");
    }

    [HttpGet("Teapot")]
    public IActionResult Teapot()
    {
        return Problem(
            detail: "I'm a teapot",
            statusCode: 418,
            title: "Teapot error"
        );
    }
}
