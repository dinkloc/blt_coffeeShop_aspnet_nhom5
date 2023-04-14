#pragma checksum "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86c2b76879078de7d537b788e97c582fdead393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard), @"mvc.1.0.view", @"/Views/Accounts/Dashboard.cshtml")]
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
#line 1 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86c2b76879078de7d537b788e97c582fdead393", @"/Views/Accounts/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fbff6ed3fb2df6caccf6b3bc2e967120906a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShopMangement.Models.Customer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Order> DanhSachDonHang = ViewBag.DonHang;
    var total = DanhSachDonHang.Sum(x => x.TotalMoney).ToString("#,##0");
    CoffeeShopMangement.ModelViews.ChangePasswordViewModel changePassword = new CoffeeShopMangement.ModelViews.ChangePasswordViewModel();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Product Related</h2>
                        <ul>
                            <li>
                                <a href=""/"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Tài khoản của tôi</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""account-page-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tab");
            WriteLiteral(@"list"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""account-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Thông tin tài khoản</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Danh sách đơn hàng</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Thay đổi mật khẩu</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""account-logout-tab"" href=""dang-xuat.html"" role=""tab"" ");
            WriteLiteral(@"aria-selected=""false"">Đăng xuất</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-9"">
                    <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                        <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                            <div class=""myaccount-dashboard"">
                                <p>
                                    Xin chào, <b>");
#nullable restore
#line 53 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                </p>\r\n                                <p>Email: ");
#nullable restore
#line 55 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Số điện thoại: ");
#nullable restore
#line 56 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>Địa chỉ: ");
#nullable restore
#line 57 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                            <div class=""myaccount-orders"">
                                <h4 class=""small-title"">DANH SÁCH ĐƠN HÀNG</h4>
");
#nullable restore
#line 63 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                 if (DanhSachDonHang != null && DanhSachDonHang.Count() > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered table-hover"">
                                            <tbody>
                                                <tr>
                                                    <th>ID</th>
                                                    <th>Ngày mua hàng</th>
                                                    <th>Ngày ship hàng</th>
                                                    <th>Trạng thái</th>
                                                </tr>
");
#nullable restore
#line 74 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                 foreach (var item in DanhSachDonHang)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 77 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                                                                              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                        <td>");
#nullable restore
#line 78 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 79 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 80 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                       Write(item.TransactStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <a href=\"javascript:void(0)\" class=\"xemdonhang\" data-madonhang=\"");
#nullable restore
#line 82 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                                                                                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xem đơn hàng</a>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 85 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </tbody>
                                        </table>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <hr />
                                        <div id=""records_table"">

                                        </div>
                                    </div>
");
#nullable restore
#line 99 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có đơn hàng!</p>\r\n");
#nullable restore
#line 103 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-address"" role=""tabpanel"" aria-labelledby=""account-address-tab"">
                            <div class=""myaccount-address"">
                                <p>The following addresses will be used on the checkout page by default.</p>
                                <div class=""row"">
                                    <div class=""col"">
                                        <h4 class=""small-title"">BILLING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 113 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                    <div class=""col"">
                                        <h4 class=""small-title"">SHIPPING ADDRESS</h4>
                                        <address>
                                            ");
#nullable restore
#line 119 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </address>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                            ");
#nullable restore
#line 126 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Accounts\Dashboard.cshtml"
                       Write(await Html.PartialAsync("_ChangePasswordPartialView", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    $(document).ready(function () {
        $("".xemdonhang"").click(function () {
            var madonhang = $(this).attr(""data-madonhang"")
            $.ajax({
                url: '/DonHang/Details',
                datatype: ""json"",
                type: ""POST"",
                data: { id: madonhang },
                async: true,
                success: function (results) {
                    $(""#records_table"").html("""");
                    $(""#records_table"").html(results);
                },
                error: function (xhr) {
                    alert('error');
                }
            });
        });
    });
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShopMangement.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
