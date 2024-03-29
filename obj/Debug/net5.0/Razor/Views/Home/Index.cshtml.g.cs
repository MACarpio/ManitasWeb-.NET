#pragma checksum "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4f7968a07f764b42c33abb79caa8c65b6c43e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Proyectos\ManitasWeb\Views\_ViewImports.cshtml"
using ManitasWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\ManitasWeb\Views\_ViewImports.cshtml"
using ManitasWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4f7968a07f764b42c33abb79caa8c65b6c43e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7765660d141965c7a2e4783288b2e83a3372f64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-Cat", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-Mat", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";
    IEnumerable<ManitasWeb.Models.Producto> product = new List<Producto>();
    IEnumerable<ManitasWeb.Models.Categoria> categoria = new List<Categoria>();
    product = @Model.prod;
    categoria = @Model.cate;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- home section starts  -->

<section class=""home"" id=""home"">

    <div class=""content"">
        <h3>Las mejores <span>manualidades</span> para ti</h3>
        <p>Manitos Creativas te ofrece, hermosas manualidades para todos los gustos</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4f7968a07f764b42c33abb79caa8c65b6c43e65621", async() => {
                WriteLiteral("Ver Productos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Cat", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cat"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Mat"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

</section>

<!-- home section ends -->

<!-- features section starts  -->

<section class=""features"" id=""features"">

    <h1 class=""heading""> Quienes <span>Somos</span> </h1>

    <div class=""box-container"">

        <div class=""box"">
            <h1 class=""heading"" style=""font-size: 2.5rem;""><span>Manitas Creativas</span></h1>
            <p>Manitas Creativas es Lorem ipsum dolor sit amet consectetur adipisicing elit. Officia ipsum quae
                expedita,
                non beatae et, illo velit cum labore, nesciunt recusandae id illum voluptates modi nam neque rem ea
                vero.</p>
            <p>Manitas Creativas es Lorem ipsum dolor sit amet consectetur adipisicing elit. Officia ipsum quae
                expedita,
                non beatae et, illo velit cum labore, nesciunt recusandae id illum voluptates modi nam neque rem ea
                vero.</p>
        </div>

        <div class=""box""
            style=""background-image: url(/image/bann");
            WriteLiteral(@"er-bg1.jpg);background-size:cover;display:flex;align-items:end;justify-content:center"">
            <h1 class=""heading"" style=""font-size: 2.5rem;""><span>Siempre <br> creando</span></h1>
        </div>


    </div>

</section>

<!-- features section ends -->

<!-- products section starts  -->

<section class=""products"" id=""products"">

    <h1 class=""heading""> Nuestros <span>productos</span> </h1>

    <div class=""swiper product-slider"">
        <div class=""swiper-wrapper"">
");
#nullable restore
#line 65 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
         foreach (var item in product)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                     if(item.Home =="Activo"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"swiper-slide box\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2396, "\"", 2464, 1);
#nullable restore
#line 69 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 2402, Url.ActionLink("MostrarImagen","Catalogo",new { id=item.Id }), 2402, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2465, "\"", 2486, 1);
#nullable restore
#line 69 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 2471, item.ImagenNom, 2471, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h3>");
#nullable restore
#line 70 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"price\"> s/ ");
#nullable restore
#line 71 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                                              Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4f7968a07f764b42c33abb79caa8c65b6c43e611142", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 74 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</section>

<!-- products section ends -->

<!-- categories section starts  -->
<section class=""products"" id=""products"">
    <h1 class=""heading"">Nuestras <span>Categorias</span> </h1>
    <div class=""swiper product-slider"">
        <div class=""swiper-wrapper"">

");
#nullable restore
#line 87 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
             foreach (var item in categoria)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"swiper-slide box\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3232, "\"", 3303, 1);
#nullable restore
#line 90 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 3238, Url.ActionLink("MostrarImagenCat","Catalogo",new { id=item.Id }), 3238, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>");
#nullable restore
#line 91 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                   Write(item.NomCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4f7968a07f764b42c33abb79caa8c65b6c43e615218", async() => {
                WriteLiteral("Ver Productos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Cat", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cat"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Cat", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cat"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Mat", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Mat"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 94 "D:\Proyectos\ManitasWeb\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <!-- categories section ends -->

    <!-- review section starts  -->

    <section class=""review"" id=""review"">

        <h1 class=""heading""> Administrador <span>Empresa</span> </h1>

        <div class=""swiper review-slider"">

            <div class=""swiper-wrapper"">

                <div class=""swiper-slide box"">
                    <img src=""image/pic-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 3947, "\"", 3953, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Unde sunt fugiat dolore ipsum id est
                        maxime
                        ad tempore quasi tenetur.</p>
                    <h3>john deo</h3>
                    <div class=""stars"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star-half-alt""></i>
                    </div>
                </div>

                <div class=""swiper-slide box"">
                    <img src=""image/pic-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 4665, "\"", 4671, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Unde sunt fugiat dolore ipsum id est
                        maxime
                        ad tempore quasi tenetur.</p>
                    <h3>john deo</h3>
                    <div class=""stars"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star-half-alt""></i>
                    </div>
                </div>


            </div>

        </div>

    </section>

    <!-- review section ends -->
");
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
