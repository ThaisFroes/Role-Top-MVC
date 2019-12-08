using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Role_MVC.Repositories
{
    public class RepositoryBase
    {
        public string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
                var chave = nomeCampo;
                var indiceChave = linha.IndexOf(chave);
                
                var indiceTerminal = linha.IndexOf(";", indiceChave);
                var valor = "";
                
                if(indiceTerminal != -1)
                {
                    valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
                }
                else
                {
                    valor = linha.Substring(indiceChave);
                }
                System.Console.WriteLine($"Campo {nomeCampo} tem valor {valor}");
                return valor.Replace(nomeCampo + "=" , "");
        }
    }
}
