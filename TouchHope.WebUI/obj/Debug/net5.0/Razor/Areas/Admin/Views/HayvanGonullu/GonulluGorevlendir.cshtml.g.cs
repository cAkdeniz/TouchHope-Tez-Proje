#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d517b830d4d1c30737ea42dd334b5c1c00ed12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HayvanGonullu_GonulluGorevlendir), @"mvc.1.0.view", @"/Areas/Admin/Views/HayvanGonullu/GonulluGorevlendir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d517b830d4d1c30737ea42dd334b5c1c00ed12", @"/Areas/Admin/Views/HayvanGonullu/GonulluGorevlendir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873208247ad4470939f874bdafaa4f257cc8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HayvanGonullu_GonulluGorevlendir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HastaHayvanListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HayvanGonullu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GorevlendirmeTamam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-icon icon-left btn-success text-center font-14"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::TouchHope.WebUI.TagHelpers.ResimDetayTagHelper __TouchHope_WebUI_TagHelpers_ResimDetayTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
  
    ViewData["Title"] = "GonulluGorevlendir";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""section-body"">
        <div class=""row mt-sm-4"">
            <div class=""col-12 col-md-12 col-lg-4"">
                <div class=""card author-box"">
                    <h4 class=""text-center lead pt-2 font-27"" style=""font:bold;color:red"">Hasta Hayvan Bilgileri</h4>
                    <div class=""card-body"">
                        <div class=""author-box-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirDetayResimBuyuk", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d517b830d4d1c30737ea42dd334b5c1c00ed125054", async() => {
            }
            );
            __TouchHope_WebUI_TagHelpers_ResimDetayTagHelper = CreateTagHelper<global::TouchHope.WebUI.TagHelpers.ResimDetayTagHelper>();
            __tagHelperExecutionContext.Add(__TouchHope_WebUI_TagHelpers_ResimDetayTagHelper);
#nullable restore
#line 16 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
__TouchHope_WebUI_TagHelpers_ResimDetayTagHelper.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __TouchHope_WebUI_TagHelpers_ResimDetayTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            <div class=\"card-body\">\r\n                                <strong style=\"color:blue\" class=\"font-17\">Aciliyet Durumu: </strong> <span class=\"badge badge-danger\" style=\"font-size:large\">");
#nullable restore
#line 19 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                                                          Write(Model.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <br />\r\n                                <br />\r\n                                <strong style=\"color:blue\" class=\"font-17\">Olu??turulma Tarihi: </strong> <small style=\"font-size:large;color:black\" class=\"font-16\">");
#nullable restore
#line 22 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                                                               Write(Model.OlusturulmaTarih.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                <br />
                                <br />
                                <p class=""card-text"">
                                    <strong style=""color:blue"" class=""font-17"">A????klama: </strong> <strong class=""font-16"">");
#nullable restore
#line 26 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                      Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-17\">A????k Adres: </strong> <strong class=\"font-16\">");
#nullable restore
#line 29 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                        Write(Model.AcikAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-17\">??l: </strong> <strong class=\"font-16\">");
#nullable restore
#line 32 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                Write(Model.Il.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                </p>\r\n                                <p class=\"card-text\">\r\n                                    <strong style=\"color:blue\" class=\"font-17\">T??r: </strong>\r\n");
#nullable restore
#line 36 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                     if (Model.Tur == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <strong class=\"font-16\">T??r Belirtilmemi??</strong>\r\n");
#nullable restore
#line 39 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <strong class=\"font-16\">");
#nullable restore
#line 42 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                           Write(Model.Tur.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-12 col-lg-8"">
                <div class=""card"">
                    <div class=""text-center mt-2"">
                        <h4 class=""font-27"" style=""color:red"">G??n??ll?? Listesi</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <div id=""table-1_wrapper"" class=""container-fluid dt-bootstrap4 no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped dataTable no-footer"" id=""table-1"" role=""grid"" aria-describedby=""table-1_info"">
                                            <thead>
                                                <tr role=""row"">
    ");
            WriteLiteral(@"                                                <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""
                              #
                            : activate to sort column ascending"" style=""width: 61.6562px;"">
                                                        #
                                                    </th>
                                                    <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">Ad Soyad</th>
                                                    <th class=""sorting_desc font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Soyad: activate to sort column ascending"" aria-sort=""descending"">Dogum Tarihi</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-lab");
            WriteLiteral(@"el=""E-mail: activate to sort column ascending"">E-mail</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Cinsiyet: activate to sort column ascending"">Cinsiyet</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""Il: activate to sort column ascending"">??l</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""TelefonNo: activate to sort column ascending"">Telefon No</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-1"" rowspan=""1"" colspan=""1"" aria-label=""KullaniciAd: activate to sort column ascending"">Kullan??c?? Ad</th>
                                                    <th class=""sorting font-18"" tabindex=""0"" aria-controls=""table-");
            WriteLiteral(@"1"" rowspan=""1"" colspan=""1"" aria-label=""??slem: activate to sort column ascending"">????lem</th>
                                                </tr>
                                            </thead>
                                            <tbody class=""mb-3"">
");
#nullable restore
#line 79 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                 foreach (var item in ViewBag.Gonullu)
                                                {
                                                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 83 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 84 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 84 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                Write(item.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 85 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.DogumTarih.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 86 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 87 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.Cinsiyet.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 88 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.Il.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 89 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.TelefonNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"font-14\">");
#nullable restore
#line 90 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                       Write(item.KullaniciAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d517b830d4d1c30737ea42dd334b5c1c00ed1219291", async() => {
                WriteLiteral("<i class=\"far fa-user\"></i>G??revlendir");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hayvanId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hayvanId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hayvanId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hayvanId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
                                                                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gonulluId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gonulluId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gonulluId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\HayvanGonullu\GonulluGorevlendir.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HastaHayvanListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
