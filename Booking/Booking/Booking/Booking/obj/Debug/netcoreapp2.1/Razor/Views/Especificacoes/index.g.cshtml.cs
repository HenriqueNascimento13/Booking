#pragma checksum "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22a7e2efd9c51b216bdadd045e93af7d4d128c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Especificacoes_index), @"mvc.1.0.view", @"/Views/Especificacoes/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Especificacoes/index.cshtml", typeof(AspNetCore.Views_Especificacoes_index))]
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
#line 1 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\_ViewImports.cshtml"
using Booking;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\_ViewImports.cshtml"
using Booking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22a7e2efd9c51b216bdadd045e93af7d4d128c8", @"/Views/Especificacoes/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb8ea961cb0ab3563b2a23336f52fa904a03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Especificacoes_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking.Models.Especificacoes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 39, false);
#line 10 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
Write(Html.ActionLink("criar novo", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(159, 31, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div id=\"pesquisa\">\r\n");
            EndContext();
#line 14 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
     using (Html.BeginForm("Index", "Especificações", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(270, 158, true);
            WriteLiteral("        <input type=\"text\" placeholder=\"Insira a especificação a procurar\" name=\"texto\" />\r\n        <input type=\"submit\" name=\"Procurar\" value=\"Procurar\" />\r\n");
            EndContext();
#line 18 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"

    }

#line default
#line hidden
            BeginContext(437, 79, true);
            WriteLiteral("\r\n\r\n</div>\r\n<br />\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(517, 45, false);
#line 27 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(562, 57, true);
            WriteLiteral("\r\n        </th>\r\n      \r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 33 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(660, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(709, 45, false);
#line 37 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(754, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(824, 66, false);
#line 41 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.IDEspecificacao }));

#line default
#line hidden
            EndContext();
            BeginContext(890, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(911, 72, false);
#line 42 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.IDEspecificacao }));

#line default
#line hidden
            EndContext();
            BeginContext(983, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1004, 70, false);
#line 43 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.IDEspecificacao }));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\admin\Desktop\Booking\Booking\Booking\Views\Especificacoes\index.cshtml"
    }

#line default
#line hidden
            BeginContext(1117, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking.Models.Especificacoes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
