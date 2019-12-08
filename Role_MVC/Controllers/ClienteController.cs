using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Role_MVC.Repositories;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();
        
        [HttpGet]
        public IActionResult Login()
        {
        return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeUsuarioSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
            System.Console.WriteLine("=================");
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["senha"]);
            System.Console.WriteLine("=================");


            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = clienteRepository.ObterPor(usuario);
            
            if(cliente !=null)
            {
                if(cliente.Senha.Equals(senha))
                {
                    HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                    HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                    return RedirectToAction("Historico", "Cliente");
                }
                else
                {
                    return View("Erro", new RespostaViewModel("Senha incorreta"));
                }
            }
            else
            {
                return View("Erro", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));
            }
            
            }
            catch (Exception e)
            {
                System.Console.WriteLine("=============");
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine("=============");
                return View("Erro");
            }
        }

    IActionResult RedirectToAction(string v1, string v2)
    {
        throw new NotImplementedException();
    }

    public IActionResult Historico()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidos = pedidoRepository.ObterTodosPorCliente(emailCliente); 
        
            return View(new HistoricoViewModel()
            {
                Pedidos = pedidos,
                NomeView = "Historico",
                UsuarioNome = ObterNomeUsuarioSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
            
        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
