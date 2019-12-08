using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Models;

namespace Role_MVC.Repositories
{
    public class EventosRepository : RepositoryBase
    {
        private const string PATH = "Database/ProdutoEvento.csv";
    
    public EventosRepository()
    {
        if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
    }

    public double obterOrcamentoDe(string nomeProdutoEvento)
        {
            var list = obterTodos();
            double orcamento = 0.0;
            foreach(var item in list)
            {
                if(item.Nome.Equals(nomeProdutoEvento))
                {
                    orcamento = item.Orcamento;
                    break;
                }
            }
            return orcamento;
        }

        internal static object ObterTodos()
        {
            throw new NotImplementedException();
        }

        public List<ProdutoEvento> obterTodos()
        {
            List<ProdutoEvento>produtoEventos =new List<ProdutoEvento>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                ProdutoEvento e = new ProdutoEvento();
                string[] dados = linha.Split(";");
                e.Nome = dados[0];
                e.Orcamento = double.Parse(dados[1]);
                produtoEventos.Add(e);
            }
            return produtoEventos;
        }
    }
}
