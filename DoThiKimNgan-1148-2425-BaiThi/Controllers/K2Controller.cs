
using DoThiKimNgan_1148_2425_BaiThi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoThiKimNgan_1148_2425_BaiThi.Controllers;

public class K2Controller : Controller
{
    private readonly ILogger<K2Controller> _logger;

    public K2Controller(ILogger<K2Controller> logger)
    {
        _logger = (ILogger<K2Controller>?)logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}