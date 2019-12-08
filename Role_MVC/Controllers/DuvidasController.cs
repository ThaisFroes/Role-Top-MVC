using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class DuvidasController : AbstractController
    {
        public IActionResult Duvidas()
        {
            return View( new BaseViewModel()
            {
                NomeView = "Duvidas"
            });
        }
    }
}
