using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Role_MVC.Models;
using Role_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeUsuarioSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try{
            Cliente cliente = new Cliente(
                form["nome"], 
                form["endereco"], 
                form["telefone"], 
                form["senha"], 
                form["email"], 
                form["conta"],
                form["cpf"],
                DateTime.Parse (form["data-nascimento"]));
                clienteRepositorio.Inserir(cliente);

                return View("Sucesso");
    
            }
            catch(Exception e){
                return View("Erro"); 
            }
        }
    }
}
