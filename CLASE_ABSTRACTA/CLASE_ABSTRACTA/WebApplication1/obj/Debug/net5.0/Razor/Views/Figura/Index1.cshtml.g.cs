#pragma checksum "C:\Users\jlap1\OneDrive\Documentos\GitHub\sena.net\CLASE_ABSTRACTA\WebApplication1\Views\Figura\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8b2abc2d349315ec5dab0716b73f63d45d3741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Figura_Index1), @"mvc.1.0.view", @"/Views/Figura/Index1.cshtml")]
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
#line 1 "C:\Users\jlap1\OneDrive\Documentos\GitHub\sena.net\CLASE_ABSTRACTA\WebApplication1\Views\_ViewImports.cshtml"
using WebFiguras;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jlap1\OneDrive\Documentos\GitHub\sena.net\CLASE_ABSTRACTA\WebApplication1\Views\_ViewImports.cshtml"
using WebFiguras.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8b2abc2d349315ec5dab0716b73f63d45d3741", @"/Views/Figura/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c415078df98eff39a8db2743e72f33a957c08b3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Figura_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">

                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='#tab2'>Cuadrado</a>

                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='#tab1'>Circunferencia</a>

                    </li>
                </ul>
                <div class=""secciones"">
                    <article id=""tab1"">
                        <div class=""col-md-10 offset-md-1"">
");
            WriteLiteral(@"                            <input id=""txtRadio"" type=""text"" class=""form-control"" placeholder=""Radio"" />
                            <br />
                            <input type=""button"" id=""btnAgregarcircunferencia"" value=""Agregar"" class=""btn btn-primary"" />
                            <br />
                            <br />
                        </div>
                    </article>
                    <article id=""tab2"">
                        <div class=""col-md-10 offset-md-1"">
");
            WriteLiteral(@"

                            <input id=""txtLado"" type=""text"" class=""form-control dark"" placeholder=""Lado"" />
                            <br />
                            <input type=""button"" id=""btnAgregarcuadrado"" value=""Agregar"" class=""btn btn-primary "" />
                            <br />
                            <br />
                        </div>
                    </article>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('ul li a:first').addClass('active');
            $('.secciones article').hide();
            $('.secciones article:first').show();

            $('ul li a').click(function () {
                $('ul li a').removeClass('active');
                $(this).addClass('active');
                $('.secciones article').hide();

                var activeTab = $(this).attr('href');
                $(activeTab).show();
                return false;
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
