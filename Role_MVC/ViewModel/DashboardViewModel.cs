using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Models;

namespace Role_MVC.ViewModel
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}
        public DashboardViewModel()
        {
            this.Pedidos = new List<Pedido>();
        }
    }
}
