#pragma checksum "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2177acd6e947b7c1c21dfc751942023232f917"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\_ViewImports.cshtml"
using Front_to_back.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\_ViewImports.cshtml"
using Front_to_back.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\_ViewImports.cshtml"
using Front_to_back.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\_ViewImports.cshtml"
using Front_to_back.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\_ViewImports.cshtml"
using Front_to_back.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2177acd6e947b7c1c21dfc751942023232f917", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3dc44f83d1b002edea9958df727b640f3a33f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pro-remover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" d-block d-md-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main wrapper start -->
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Cart</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Cart</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- cart main wrapper start -->
    <div class=""cart-main-wrapper section-padding"">
        <div class=""container""");
            WriteLiteral(@">
            <div class=""section-bg-color"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <!-- Cart Table Area -->
                        <div class=""cart-table table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th class=""pro-thumbnail"">Thumbnail</th>
                                        <th class=""pro-title"">Product</th>
                                        <th class=""pro-price"">Price</th>
                                        <th class=""pro-quantity"">Quantity</th>
                                        <th class=""pro-subtotal"">Total</th>
                                        <th class=""pro-remove"">Remove</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 48 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                     foreach (var item in Model.BasketItems)
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"pro-thumbnail\"><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a2177acd6e947b7c1c21dfc751942023232f9179888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2345, "~/assets/img/product/", 2345, 21, true);
#nullable restore
#line 53 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 2366, item.Product.Image, 2366, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-title\"><a href=\"#\">");
#nullable restore
#line 54 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                                         Write(item.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-price\"><span>$");
#nullable restore
#line 55 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                                    Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td class=\"pro-quantity\">\r\n                                                <a data-id=\"");
#nullable restore
#line 57 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                       Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"downbtn\" class=\"dec qtybtn\">-</a>\r\n                                                <div class=\"ml-3 inp-value\">");
#nullable restore
#line 58 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                                       Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <a data-id=\"");
#nullable restore
#line 59 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                       Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"upbtn\" class=\"inc qtybtn\">+</a>\r\n                                            </td>\r\n                                            <td class=\"pro-subtotal\">\r\n                                                <span id=\"total-price\" data-id=\"");
#nullable restore
#line 62 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                                           Write(item.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    $ ");
#nullable restore
#line 64 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                    Write(item.Product.Price * @item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </span>\r\n                                            </td>\r\n                                            <td class=\"pro-remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2177acd6e947b7c1c21dfc751942023232f91714895", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                                                                                                                            WriteLiteral(item.Product.Id);

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
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\ASUS\OneDrive\İş masası\Backend Project\Backend-project\Backend-Project\Front-to-back\Views\Basket\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- Cart Update Option -->
                        <div class=""cart-update-option d-block d-md-flex justify-content-between"">
                            <div class=""apply-coupon-wrapper"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2177acd6e947b7c1c21dfc751942023232f91718201", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Enter Your Coupon Code\" required />\r\n                                    <button class=\"btn\">Apply Coupon</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""cart-update"">
                                <a href=""#"" class=""btn"">Update Cart</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-5 ml-auto"">
                        <!-- Cart Calculation Area -->
                        <div class=""cart-calculator-wrapper"">
                            <div class=""cart-calculate-items"">
                                <h3>Cart Totals</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        

                                            <tr>
                                                <td>Sub Total</td>
                                                <td>$390</td>
                                            </tr>
               ");
            WriteLiteral(@"                             <tr>
                                                <td>Shipping</td>
                                                <td>$70</td>
                                            </tr>
                                            <tr class=""total"">
                                                <td>Total</td>
                                                <td class=""total-amount"">$300</td>
                                            </tr>
                                      
                                        </table>
                                </div>
                            </div>
                            <a href=""checkout.html"" class=""btn d-block"">Proceed Checkout</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- cart main wrapper end -->
</main>
<!-- main wrapper end -->

");
            DefineSection("ScriptsJs", async() => {
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script>

        $(document).ready(function () {

            $(document).on(""click"", "".dec"", function (e) {
                e.preventDefault();
                var id = $(this).attr(""data-id"")
                var total = document.querySelector(""#total-price"")
                var money = document.querySelectorAll("".pro-price"")

                console.log(id)
                $.ajax({
                    url: ""/basket/minus"",
                    data: {
                        id: id
                    },
                    type: ""post"",
                    datatype: ""json"",
                    success: function (data) {
                        money.forEach(mon => {
                            if (id == mon.getAttribute(""data-id"")) {
                                mon.innerHTML += data.price
                                // console.log(data.price)
                            }
                        })
   ");
                WriteLiteral(@"                     money.innerHTML += `${data.totalPrice}`

                    }
                })

            })


            $(document).on(""click"", "".inc"", function (e) {
                e.preventDefault();
                var id = $(this).attr(""data-id"")
                var total = document.querySelector(""#total-price"")
                var money = document.querySelectorAll("".pro-price"")
                console.log(id)
                $.ajax({
                    url: ""/basket/plus"",
                    data: {
                        id: id
                    },
                    type: ""post"",
                    datatype: ""json"",
                    success: function (data) {
                        money.forEach(mon => {
                            if (id == mon.getAttribute(""data-id"")) {
                                mon.innerHTML = data.price
                                console.log(data.price)
                            }
                        })
         ");
                WriteLiteral(@"               money.innerHTML += `${data.totalPrice}`

                    }
                })

            })



            $("".pro-remover"").click(function (e) {
                e.preventDefault()
                console.log($(this).attr(""href""))
                Swal.fire({
                    title: 'Eminsiniz mi?',
                    text: ""Bunu geri qaytara bilmezsiniz!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Beli, sil!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        var link = $(this).attr(""href"");
                        fetch(link).then(response => response.json()).then(data => {
                            if (data.status == 200) {
                                location.reload(true)
                            } else {
           ");
                WriteLiteral(@"                     Swal.fire(
                                    'Not found!',
                                    'Your file can not be deleted.',
                                    'Failed'
                                )
                            }
                        });
                    }
                })
            })

        })
        var myInp = document.querySelectorAll("".inp-value"");
        var increaseBtn = document.querySelectorAll("".inc"");
        var decreaseBtn = document.querySelectorAll("".dec"");
        for (let elem of decreaseBtn) {

            elem.addEventListener(""click"", function (e) {
                e.preventDefault()
                countst = this.nextElementSibling.innerText
                countstn = Number(countst)

                if (countstn > 1) {
                    count = this.nextElementSibling.innerText
                    countn = Number(count)
                    countn -= 1;
                    this.nextElementSibling.inn");
                WriteLiteral(@"erText = countn;
                }
            })
        }
        for (let elem of increaseBtn) {

            elem.addEventListener(""click"", function (e) {
                e.preventDefault()
                count = this.previousElementSibling.innerText
                countn = Number(count)
                countn += 1;
                this.previousElementSibling.innerText = countn;


            })
        }


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
