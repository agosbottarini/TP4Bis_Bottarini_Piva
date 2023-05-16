using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cuatrimestre1.Models;

namespace cuatrimestre1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View();
    }
<<<<<<< HEAD

    public IActionResult DetallePais(string nombrePais)
    {
        ViewBag.Pais = Info.DetallePais(nombrePais);
        return View();
    }

=======
>>>>>>> cdca260f0931d419ebd0e94a2ed34495f26103f9
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
