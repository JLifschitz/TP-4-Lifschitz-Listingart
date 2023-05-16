using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.indumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.equipos = Equipos.ListaEquipos;
        ViewBag.medias = Equipos.ListaMedias;
        ViewBag.pantalones = Equipos.ListaPantalones;
        ViewBag.remeras = Equipos.ListaRemeras;
        return View();
    }

    public IActionResult GuardarIndumentaria(string equipos, string medias, string pantalones, string remeras)
    {
        Indumentaria indumentaria = new Indumentaria(medias, pantalones, remeras);
        Equipos.IngresarIndumentaria(equipos, indumentaria);
        return RedirectToAction("Index");
    }
}
