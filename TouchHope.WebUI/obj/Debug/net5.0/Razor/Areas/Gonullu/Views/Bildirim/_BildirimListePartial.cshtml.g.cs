#pragma checksum "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61101fc4e38bd2c238c43e55e5f8ac77c25531a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Gonullu_Views_Bildirim__BildirimListePartial), @"mvc.1.0.view", @"/Areas/Gonullu/Views/Bildirim/_BildirimListePartial.cshtml")]
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
#line 4 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\_ViewImports.cshtml"
using TouchHope.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61101fc4e38bd2c238c43e55e5f8ac77c25531a4", @"/Areas/Gonullu/Views/Bildirim/_BildirimListePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e451376d7072963e54773d0d26b9a31c641fba6f", @"/Areas/Gonullu/Views/_ViewImports.cshtml")]
    public class Areas_Gonullu_Views_Bildirim__BildirimListePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BildirimListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
 if (Model.Count > 0)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
     foreach (var bildirim in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"dialog-inner mg-t-30\">\r\n                <div class=\"contact-hd dialog-hd\">\r\n                    <h2>");
#nullable restore
#line 11 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
                   Write(bildirim.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 12 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
                  Write(bildirim.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"dialog-pro dialog\">\r\n                    <a class=\"btn btn-success waves-effect float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 500, "\"", 527, 3);
            WriteAttributeValue("", 510, "sil(", 510, 4, true);
#nullable restore
#line 15 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
WriteAttributeValue("", 514, bildirim.Id, 514, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 526, ")", 526, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Okundu Olarak İşaretle</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"lead\">\r\n        <h2 class=\"text-center p-4\" style=\"color:blue\">Okunmamış bildiriminiz bulunmamaktadır.</h2>\r\n    </p>\r\n");
#nullable restore
#line 26 "C:\Users\User\Documents\NetCoreProjects\TouchHope\TouchHope.WebUI\Areas\Gonullu\Views\Bildirim\_BildirimListePartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BildirimListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591