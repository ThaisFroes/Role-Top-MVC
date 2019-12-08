using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Role_MVC.Models;
using Role_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Role_MVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string  SESSION_CLIENTE_EMAIL = "SESSION_CLIENTE_EMAIL"; 
        protected const string SESSION_CLIENTE_NOME = "Cliente_nome";
        protected const string SESSION_TIPO_USUARIO = "Tipo_usuario";

        protected string ObterUsuarioSession()
        {
            var email = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL); 
            if(!string.IsNullOrEmpty(email))
            {
                return email;
            }
            else
            {
                return "";
            }
        }

        protected string ObterNomeUsuarioSession()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            else
            {
                return "";
            }
        }

        protected string ObterUsuarioTipoSession()
        {
            var tipousuario = HttpContext.Session.GetString(SESSION_TIPO_USUARIO);
            if(!string.IsNullOrEmpty(tipousuario))
            {
                return tipousuario;
            }
            else
            {
                return "";
            }
        }

    }
}
