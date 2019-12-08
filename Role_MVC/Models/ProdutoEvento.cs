using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Role_MVC.Models
{
    public class ProdutoEvento : Produto
    {
        public ProdutoEvento()
        {
            
        }

        public ProdutoEvento(string nome, double orcamento)
        {
            this.Nome = nome;
            this.Orcamento = orcamento;
        }
    }
}
