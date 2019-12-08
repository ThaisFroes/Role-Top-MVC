using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Role_MVC.Models;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioNome = ObterNomeUsuarioSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }
    }
}
