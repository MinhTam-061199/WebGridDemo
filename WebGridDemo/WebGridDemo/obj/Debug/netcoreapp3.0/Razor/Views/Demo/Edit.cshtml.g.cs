#pragma checksum "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc65f528924b705e7a9f2d341f14dbe34377eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Edit), @"mvc.1.0.view", @"/Views/Demo/Edit.cshtml")]
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
#line 1 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\_ViewImports.cshtml"
using WebGridDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\_ViewImports.cshtml"
using WebGridDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc65f528924b705e7a9f2d341f14dbe34377eed", @"/Views/Demo/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e65d62c3c8578d2fe1bbb9a559f0ec5689756f", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebGridDemo.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml"
  
    Layout = null;


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h2>Edit </h2>\r\n    <div class=\"form-group\">\r\n        ID: ");
#nullable restore
#line 14 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml"
       Write(Html.TextBoxFor(x => x.ProductId, new { @class = "form-controller" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Name: ");
#nullable restore
#line 18 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml"
         Write(Html.TextBoxFor(x => x.Name, new { @class = "form-controller" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        Price: ");
#nullable restore
#line 22 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml"
          Write(Html.TextBoxFor(x => x.Price, new { @class = "form-controller" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n\r\n        <button class=\"btn btn-success\"> Edit </button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 30 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebGridDemo.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
