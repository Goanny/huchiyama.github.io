using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cv.Models;
using Cv.AccesoDatos;
using Cv.Data; 
using Cv.Models;

namespace Cv.Controllers;

public class HomeController : Controller
{
     private readonly ILogger<HomeController> _logger;
    private readonly IDARepositorioProyectos DAARepositorioProyectos; 
    private readonly IDAServicioEmailSendGrid DAAServicioEmailSendGrid; 

    public HomeController(ILogger<HomeController> logger, IDARepositorioProyectos DAARepositorioProyectos,
    IDAServicioEmailSendGrid DAAServicioEmailSendGrid)
    {
        _logger = logger;
       this.DAARepositorioProyectos = DAARepositorioProyectos;
       this.DAAServicioEmailSendGrid = DAAServicioEmailSendGrid;
    }


    public IActionResult index()
    {
        return View();
    }
      public IActionResult Curso()
    {
        return View();
    }
  public IActionResult Proyecto()
    {
        var proyecto=DAARepositorioProyectos.Obtener(); 
        return View(proyecto);
    }
    public IActionResult Certificado()
    {
        return View();
    }

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
