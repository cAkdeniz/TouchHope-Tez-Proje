#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68b53ddeafec6575531dd60598e85ef13d2a6e12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HastaHayvan_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HastaHayvan/Index.cshtml")]
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
#line 4 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using TouchHope.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b53ddeafec6575531dd60598e85ef13d2a6e12", @"/Areas/Admin/Views/HastaHayvan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873208247ad4470939f874bdafaa4f257cc8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HastaHayvan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HastaHayvanListModel>>
    {
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
        private global::TouchHope.WebUI.TagHelpers.ResimHastaHayvanTagHelper __TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""section-body"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""text-center mt-2"">
                        <h4 class=""font-27"" style=""color:red"">Hasta Hayvan Listesi</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <div id=""table-1_wrapper"" class=""container-fluid dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped dataTable no-footer"" id=""table-1"" role=""grid"" aria-describedby=""table-1_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""");
            WriteLiteral(@"table-1"" rowspan=""1"" colspan=""1"" aria-label=""
                              #
                            : activate to sort column ascending"" style=""width: 61.6562px;"">
                                                        #
                                                    </th>
                                                    <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">A????klama</th>
                                                    <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">Resim</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""E-mail: activate to sort column ascending"">Olu??turulma Tarihi</th>
                                       ");
            WriteLiteral(@"             <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">A????k Adres</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Il: activate to sort column ascending"">??l</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""TelefonNo: activate to sort column ascending"">Aciliyet</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""KullaniciAd: activate to sort column ascending"">T??r</th>
                                                </tr>
                                            </thead>
                                            <tbody class=""mb-3"">

");
#nullable restore
#line 40 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                 foreach (var item in Model)
                                                {
                                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr role=\"row\" class=\"odd\">\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 44 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 45 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirHastaHayvanResim", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68b53ddeafec6575531dd60598e85ef13d2a6e128016", async() => {
            }
            );
            __TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper = CreateTagHelper<global::TouchHope.WebUI.TagHelpers.ResimHastaHayvanTagHelper>();
            __tagHelperExecutionContext.Add(__TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper);
#nullable restore
#line 47 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
__TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper.Id = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __TouchHope_WebUI_TagHelpers_ResimHastaHayvanTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 49 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                   Write(item.OlusturulmaTarih.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 50 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                   Write(item.AcikAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"font-14\">");
#nullable restore
#line 51 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                   Write(item.Il.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>\r\n");
#nullable restore
#line 53 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                         if (item.Aciliyet.Tanim == "??ok Hafif" || item.Aciliyet.Tanim == "Hafif")
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-warning font-15\">");
#nullable restore
#line 55 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                                                 Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                        }
                                                        else if (item.Aciliyet.Tanim == "Normal")
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-warning font-15\">");
#nullable restore
#line 59 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                                                 Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 60 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"badge badge-danger font-15\">");
#nullable restore
#line 63 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                                                                Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 64 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                    <td class=\"font-14\">\r\n");
#nullable restore
#line 67 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                         if (item.Tur == null)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h6>T??r belirtilmemi??.</h6>\r\n");
#nullable restore
#line 70 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <h6>");
#nullable restore
#line 73 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                           Write(item.Tur.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 74 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HastaHayvan\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HastaHayvanListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
