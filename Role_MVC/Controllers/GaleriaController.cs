using Microsoft.AspNetCore.Mvc;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Galeria()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Galeria"
            });
        }
    }
}