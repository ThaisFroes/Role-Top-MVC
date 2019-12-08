using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Enums;

namespace Role_MVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public ProdutoEvento ProdutoEvento {get;set;}
        public DateTime DataDoPedido {get;set;}
        public double Orcamento {get;set;}
        public uint Status {get;set;}

        public Pedido()
        {
            this.Cliente = new Cliente();
            this.ProdutoEvento = new ProdutoEvento();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
        }
    }
}
