#pragma checksum "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a519ad1f12c708a51f1651af183b9b496b87b9dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Grid), @"mvc.1.0.view", @"/Views/Demo/Grid.cshtml")]
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
#nullable restore
#line 5 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a519ad1f12c708a51f1651af183b9b496b87b9dd", @"/Views/Demo/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e65d62c3c8578d2fe1bbb9a559f0ec5689756f", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductPagingInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>

<style>

    .arrow {
        display: inline-block;
        height: 16px;
        vertical-align: middle;
        width: 16px;
    }

        .arrow.up {
            background-image: url('/images/arrow-up.png');
        }

        .arrow.down {
            background-image: url('/images/arrow-down.png');
        }
</style>

<div class=""container"">

    <h4>List of Products</h4>
");
#nullable restore
#line 35 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
     using (Html.BeginForm("Grid", "Demo", FormMethod.Get, new { @id = "frmSearch" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n\r\n            <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                ");
#nullable restore
#line 40 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
           Write(Html.TextBoxFor(m => m.Search, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </div>
            <div class=""col-md-4 col-sm-4 col-xs-12"">
                <input id=""btnsubmit"" class=""btn btn-success"" type=""submit"" value=""Search"" />
                <input id=""btnclear"" class=""btn btn-success"" type=""button"" value=""Clear"" />
                <input id=""btnsubmit"" class=""btn btn-success"" type=""submit"" value=""Edit"" />
            </div>
            <div class=""col-md-4 col-sm-4 col-xs-12"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"" style=""margin-top: 25px"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr");
            BeginWriteAttribute("sortby", " sortby=\"", 1767, "\"", 1789, 1);
#nullable restore
#line 56 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
WriteAttributeValue("", 1776, Model.sortBy, 1776, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("pagesize", " pagesize=\"", 1790, "\"", 1816, 1);
#nullable restore
#line 56 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
WriteAttributeValue("", 1801, Model.pageSize, 1801, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("isAsc", " isAsc=\"", 1817, "\"", 1837, 1);
#nullable restore
#line 56 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
WriteAttributeValue("", 1825, Model.isAsc, 1825, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("search", " search=\"", 1838, "\"", 1860, 1);
#nullable restore
#line 56 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
WriteAttributeValue("", 1847, Model.Search, 1847, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></tr>\r\n                    </thead>\r\n                   \r\n                    <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
                               Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                        <tr>\r\n\r\n                            <td colspan=\"3\">\r\n                                ");
#nullable restore
#line 78 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
                           Write(Html.PagedListPager((IPagedList)Model.Products,
             page => Url.Action("Grid", new
             {
                 page = page,
                 sortby = Model.sortBy,
                 Search = Model.Search
             }),
             PagedListRenderOptions.OnlyShowFivePagesAtATime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 93 "C:\Users\TAM\Desktop\New folder\tam\TAM\WebGridDemo\WebGridDemo\Views\Demo\Grid.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#btnclear"").click(function () {
            window.location.href = window.location.href.split('?')[0];
        });

        $(""#Search"").blur(function () {
            var value = $(""#Search"").val();
            value = value.trim();
            $(""#Search"").val(value);
        });
    });
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductPagingInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591