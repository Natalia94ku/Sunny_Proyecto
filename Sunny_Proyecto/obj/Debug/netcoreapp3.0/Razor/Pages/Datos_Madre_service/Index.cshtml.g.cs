#pragma checksum "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21d9dad8a7e04875a457c3458d13cce82b227545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sunny_Proyecto.Pages.Datos_Madre_service.Pages_Datos_Madre_service_Index), @"mvc.1.0.razor-page", @"/Pages/Datos_Madre_service/Index.cshtml")]
namespace Sunny_Proyecto.Pages.Datos_Madre_service
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
#line 1 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\_ViewImports.cshtml"
using Sunny_Proyecto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21d9dad8a7e04875a457c3458d13cce82b227545", @"/Pages/Datos_Madre_service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad91f999574ba9a1091671d0a9d1bf3a49d070f3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Datos_Madre_service_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Datos de la Madre</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d9dad8a7e04875a457c3458d13cce82b2275454578", async() => {
                WriteLiteral("Crear Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Nombre_Madre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Apellido_Paterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Apellido_Materno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Fecha_Nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Ocupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Domicilio_padres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Comunidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Datos_Madre[0].Estado_civil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
 foreach (var item in Model.Datos_Madre) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre_Madre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido_Paterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido_Materno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha_Nacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ocupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Domicilio_padres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comunidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado_civil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d9dad8a7e04875a457c3458d13cce82b22754515005", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d9dad8a7e04875a457c3458d13cce82b22754517209", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21d9dad8a7e04875a457c3458d13cce82b22754519418", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 100 "C:\Users\natal\Desktop\Aplicaciones Web\Proyecto\Sunny_Proyecto\Sunny_Proyecto\Pages\Datos_Madre_service\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sunny_Proyecto.Pages.Datos_Madre_service.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sunny_Proyecto.Pages.Datos_Madre_service.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sunny_Proyecto.Pages.Datos_Madre_service.IndexModel>)PageContext?.ViewData;
        public Sunny_Proyecto.Pages.Datos_Madre_service.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
