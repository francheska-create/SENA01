#pragma checksum "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d2f3bab478973305f0aa0637047547e4e5f39d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programa_Index), @"mvc.1.0.view", @"/Views/Programa/Index.cshtml")]
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
#line 1 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\_ViewImports.cshtml"
using ControlAsistencia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\_ViewImports.cshtml"
using ControlAsistencia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d2f3bab478973305f0aa0637047547e4e5f39d", @"/Views/Programa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a934f3f24efa9eb3231643c37c54826c248bef4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Programa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlAsistencia.Models.Programa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<style>\r\n    th {\r\n        cursor: pointer;\r\n    }\r\n</style>\r\n\r\n\r\n<h1> Lista de Programa de Formacion  del SENA</h1>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d2f3bab478973305f0aa0637047547e4e5f39d5878", async() => {
                WriteLiteral("<i class=\"fas fa-address-book\"></i>&nbsp;Agregar programa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</p>\r\n<table class=\"table  table-striped table-hover table-primary\" id=\"tabla\" >\r\n    <thead>\r\n        <tr>\r\n            <th> \r\n                ");
#nullable restore
#line 25 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n                ");
#nullable restore
#line 28 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th >\r\n\r\n                ");
#nullable restore
#line 32 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
           Write(Html.DisplayNameFor(Model => Model.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Operaciones\r\n            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 44 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
         foreach (var item in Model)
        {
            if (item.Estado == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d2f3bab478973305f0aa0637047547e4e5f39d9768", async() => {
                WriteLiteral("<i class=\"far fa-edit\"></i>&nbsp;Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
                                                                       WriteLiteral(item.ProgramaId);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d2f3bab478973305f0aa0637047547e4e5f39d12092", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle\"></i>&nbsp;Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
                                                                       WriteLiteral(item.ProgramaId);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d2f3bab478973305f0aa0637047547e4e5f39d14426", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>&nbsp;Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
                                                                        WriteLiteral(item.ProgramaId);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
            }


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 79 "J:\ff\WebMVCApplicationo01\ControlAsistencia\Views\Programa\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        //function sortTable(n) {
        //    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
        //    table = document.getElementById(""tabla"");
        //    switching = true;
        //    //Set the sorting direction to ascending:
        //    dir = ""asc"";
        //    /*Make a loop that will continue until
        //    no switching has been done:*/
        //    while (switching) {
        //        //start by saying: no switching is done:
        //        switching = false;
        //        rows = table.rows;
        //        /*Loop through all table rows (except the
        //        first, which contains table headers):*/
        //        for (i = 1; i < (rows.length - 1); i++) {
        //            //start by saying there should be no switching:
        //            shouldSwitch = false;
        //            /*Get the two elements you want to compare,
        //            one from current row and one from the next:*/
        /");
                WriteLiteral(@"/            x = rows[i].getElementsByTagName(""TD"")[n];
        //            y = rows[i + 1].getElementsByTagName(""TD"")[n];
        //            /*check if the two rows should switch place,
        //            based on the direction, asc or desc:*/
        //            if (dir == ""asc"") {
        //                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
        //                    //if so, mark as a switch and break the loop:
        //                    shouldSwitch = true;
        //                    break;
        //                }
        //            } else if (dir == ""desc"") {
        //                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
        //                    //if so, mark as a switch and break the loop:
        //                    shouldSwitch = true;
        //                    break;
        //                }
        //            }
        //        }
        //        if (shouldSwitch) {
        //          ");
                WriteLiteral(@"  /*If a switch has been marked, make the switch
        //            and mark that a switch has been done:*/
        //            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
        //            switching = true;
        //            //Each time a switch is done, increase this count by 1:
        //            switchcount++;
        //        } else {
        //            /*If no switching has been done AND the direction is ""asc"",
        //            set the direction to ""desc"" and run the while loop again.*/
        //            if (switchcount == 0 && dir == ""asc"") {
        //                dir = ""desc"";
        //                switching = true;
        //            }
        //        }
        //    }
        //}
        $(document).ready(function () {
            $('#tabla').DataTable();
            //$('tr').removeClass(""odd"");
            //$('tr').removeClass(""even"");
            //$('table').removeClass(""dataTable"");
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n<script src=\"https://kit.fontawesome.com/eac556b4db.js\" crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControlAsistencia.Models.Programa>> Html { get; private set; }
    }
}
#pragma warning restore 1591