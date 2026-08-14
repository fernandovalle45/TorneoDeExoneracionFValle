using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAcademia.Models;

namespace WebAcademia.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["NombreEstudiante"] = "Fernando Emilio Valle Bernal";
        ViewData["Carrera"] = "Ingeniería en Desarrollo de Software";
        ViewData["Materia"] = "Desarrollo Multiplataforma de Aplicaciones Web";
        ViewData["Seccion"] = "A";

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
