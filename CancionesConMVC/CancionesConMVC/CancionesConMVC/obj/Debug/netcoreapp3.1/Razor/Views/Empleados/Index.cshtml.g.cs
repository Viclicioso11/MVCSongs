#pragma checksum "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726dc274489aa45913c24608e223c50e63e117ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Index), @"mvc.1.0.view", @"/Views/Empleados/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\_ViewImports.cshtml"
using CancionesConMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\_ViewImports.cshtml"
using CancionesConMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726dc274489aa45913c24608e223c50e63e117ab", @"/Views/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9865fb7ad3c246d9f2b0c3af616620c27a95834e", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginadorGenerico<Empleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Empleados</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "726dc274489aa45913c24608e223c50e63e117ab4724", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nombres
            </th>
            <th>
                Apellidos
            </th>
            <th>
                Cargo
            </th>
            <th>
                Empleado Jefe
            </th>
            <th>
                Teléfono
            </th>
            <th>
                Email
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
         foreach (var item in Model.Resultado)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmpleadoJefe.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.EmpleadoJefe.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "726dc274489aa45913c24608e223c50e63e117ab9321", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                           WriteLiteral(item.EmpleadoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "726dc274489aa45913c24608e223c50e63e117ab11538", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                              WriteLiteral(item.EmpleadoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "726dc274489aa45913c24608e223c50e63e117ab13762", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                             WriteLiteral(item.EmpleadoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 68 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
 if (Model.Resultado.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>\r\n        <strong>");
#nullable restore
#line 71 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
           Write(Model.TotalRegistros);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> registros encontrados\r\n    </span>\r\n    <span>&nbsp;|&nbsp;</span>\r\n    <span>\r\n        Página <strong>");
#nullable restore
#line 75 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                   Write(Model.PaginaActual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> de\r\n        <strong>");
#nullable restore
#line 76 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
           Write(Model.TotalPaginas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </span>\r\n    <span>&nbsp;|&nbsp;</span>\r\n");
#nullable restore
#line 79 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>No hay resultados para esta búsqueda</span>\r\n    <span>&nbsp;|&nbsp;</span>\r\n");
#nullable restore
#line 84 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
 if (Model.PaginaActual > 1)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink("<<", "Index", new { pagina = 1 },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 91 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink("Anterior", "Index", new { pagina = Model.PaginaActual - 1 },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                                              
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink("<<", "Index", new { pagina = 1 },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 99 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink("Anterior", "Index", new { pagina = 1 },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                                                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<span></span>\r\n");
#nullable restore
#line 103 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
 if (Model.PaginaActual < Model.TotalPaginas)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink("Siguiente", "Index", new { pagina = Model.PaginaActual + 1 },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 108 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink(">>", "Index", new { pagina = Model.TotalPaginas },
                    new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                                              
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink("Siguiente", "Index", new { pagina = Model.TotalPaginas - 1 },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 116 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
Write(Html.ActionLink(">>", "Index", new { pagina = Model.TotalPaginas },
                    new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\Bryan\Documents\Code\MVCSongs\CancionesConMVC\CancionesConMVC\CancionesConMVC\Views\Empleados\Index.cshtml"
                                                                       
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginadorGenerico<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
