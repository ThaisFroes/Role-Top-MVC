using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Models;

namespace Role_MVC.ViewModel 
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<ProdutoEvento> ProdutoEventos {get;set;}
        public string NomeUsuario {get;set;}
        public Cliente Cliente {get;set;}

        public PedidoViewModel()
        {
            this.ProdutoEventos = new List<ProdutoEvento>();
            this.NomeUsuario = "Abacaxi";
            this.Cliente = new Cliente();
        }
    }
}
