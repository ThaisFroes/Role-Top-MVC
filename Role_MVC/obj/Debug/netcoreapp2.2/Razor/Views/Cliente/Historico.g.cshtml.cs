#pragma checksum "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d8950b1d1897fdff015856c5f496c5cd625e79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\_ViewImports.cshtml"
using Role_MVC;

#line default
#line hidden
#line 2 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\_ViewImports.cshtml"
using Role_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97d8950b1d1897fdff015856c5f496c5cd625e79", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b675b1c91659e3a40aba85095abadd99070d31e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Role_MVC.ViewModel.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - Role_MVC";
    ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(146, 18, true);
            WriteLiteral("\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(165, 14, false);
#line 8 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(179, 182, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data</th>\r\n                <th>Produto Eventos</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(416, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(463, 19, false);
#line 19 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataDoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(482, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(514, 25, false);
#line 20 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.ProdutoEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(539, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "C:\Users\44592799836\Documents\06-12 role\sem-fim\Role_MVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(584, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Role_MVC.ViewModel.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
