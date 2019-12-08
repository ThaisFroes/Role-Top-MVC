using System;
using Role_MVC.Models;
using Role_MVC.Repositories;
using Role_MVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Role_MVC.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        EventosRepository eventosRepository = new EventosRepository();
        ClienteRepository clienteRepository =  new ClienteRepository();

        public IActionResult Index()
        {
            PedidoViewModel pedido = new PedidoViewModel();

            var produtoEventos = EventosRepository.ObterTodos(); 
            
            var usuarioLogado = ObterUsuarioSession();

            var nomeUsuarioLogado = ObterNomeUsuarioSession();

            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pedido.NomeUsuario = nomeUsuarioLogado;
            }
            pedido.NomeUsuario = ObterNomeUsuarioSession();

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado !=null)
            {
                pedido.Cliente = clienteLogado;
            }


            pedido.NomeView = "Pedido";
            pedido.UsuarioEmail = ObterUsuarioSession();
            pedido.UsuarioNome = ObterNomeUsuarioSession();
            return View(pedido);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();

            Cliente Cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"],
                Conta = form["conta"],
                Cpf = form ["cpf"]
            };

            pedido.Cliente = Cliente;

            pedido.DataDoPedido = DateTime.Now;
            
            if(pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso", new RespostaViewModel()
            {
                Mensagem = "Aguarde a aprovação dos nossos administradores",
                NomeView = "Sucesso",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeUsuarioSession()
            });
            }
            else
            {
                return View("Erro", new RespostaViewModel()
            {
                Mensagem = "Houve um erro ao processar o seu pedido. Tente novamente",
                NomeView = "Erro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterNomeUsuarioSession()
            });
            }
        }
    }
}
