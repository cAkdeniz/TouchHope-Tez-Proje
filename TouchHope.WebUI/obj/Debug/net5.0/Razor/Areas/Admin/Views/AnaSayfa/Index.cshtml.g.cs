#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1238177f293fcc102af5b5e8f287dc860c8cb6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AnaSayfa_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AnaSayfa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1238177f293fcc102af5b5e8f287dc860c8cb6b", @"/Areas/Admin/Views/AnaSayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9873208247ad4470939f874bdafaa4f257cc8943", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AnaSayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/site/assets/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("145"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""row "">
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">??hbar Say??s??</h4>
                                    <br />
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 19 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.IhbarSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b6107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">Hasta Hayvan Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 41 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.HastaHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b8851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">Kaybolan Hayvan Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 63 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.KaybolanHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b11601", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">Sahiplendirilecek Hayvan Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 85 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.SahiplendirilecekHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b14370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">??yile??en Hayvan Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 107 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.IyilesenHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b17122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-18"">Aktif ??lgilenilen Hasta Hayvan Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 129 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.AktifHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b19886", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-18"">Ilgilenilmeyen Hasta Hayvan Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 151 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.PasifHayvanSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b22647", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">Okunmam???? Bildirim Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 173 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.BildirimSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b25396", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">Toplam Yaz??lan Rapor Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 195 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.ToplamRaporSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b28150", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">G??n??ll?? Say??s??</h4>
                                    <br />
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 218 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.GonulluSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b30931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">G??n??ll?? Erkek Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 240 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.GonulluErkekSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b33679", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6 col-sm-6 col-xs-12"">
            <div class=""card"">
                <div class=""card-statistic-4"">
                    <div class=""align-items-center justify-content-between"">
                        <div class=""row "">
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pr-0 pt-3"">
                                <div class=""card-content"">
                                    <h4 class=""font-20"">G??n??ll?? Kad??n Say??s??</h4>
                                    <br />
                                    <h1 class=""mb-3 font-26 text-center"" style=""color:red"">");
#nullable restore
#line 262 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Admin\Views\AnaSayfa\Index.cshtml"
                                                                                      Write(ViewBag.GonulluKadinSayisi.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-6 pl-0"">
                                <div class=""banner-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1238177f293fcc102af5b5e8f287dc860c8cb6b36427", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
