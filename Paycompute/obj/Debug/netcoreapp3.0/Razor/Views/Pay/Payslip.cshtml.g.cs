#pragma checksum "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054e5fd315712e0011023e2539fb28cdf05bd3c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pay_Payslip), @"mvc.1.0.view", @"/Views/Pay/Payslip.cshtml")]
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
#line 1 "G:\.NET Core\PaycomputeApp\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\.NET Core\PaycomputeApp\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054e5fd315712e0011023e2539fb28cdf05bd3c5", @"/Views/Pay/Payslip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a17a92ca28dc354efe5ab80300d7aa4b038b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pay_Payslip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentRecordDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap-grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
   ViewBag.Title = "Payslip";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "054e5fd315712e0011023e2539fb28cdf05bd3c54201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""container-fluid d-flex justify-content-between"">
                    <div class=""col-md-3 pl-0"">
                        <p class=""mt-5 mb-2""><b>PayCompute Ltd</b></p>
                        <p>11 Downing Street <br />London <br />W1C 2X</p>
                    </div>
                    <div class=""col-md-3 pr-0"">
                        <p class=""mt-5 mb-2 text-right""><b>Pay Date: ");
#nullable restore
#line 18 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                                                                Write(Model.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        <p class=\"text-right\">Tax Code: ");
#nullable restore
#line 19 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                                                   Write(Model.TaxCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />Year: ");
#nullable restore
#line 19 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                                                                              Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />HMRC</p>\r\n                    </div>\r\n                </div><br /><br />\r\n                <div class=\"col-md-12 row\">\r\n                    <div class=\"col-md-8\"><h5>Employees\'s Name : ");
#nullable restore
#line 23 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                                                            Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></div>\r\n                    <div class=\"col-md-8\"><h5>National Insurance Number Name : ");
#nullable restore
#line 24 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                                                                          Write(Model.NiNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5></div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12 table-responsive-md"">
                    <table class=""table table-striped"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Earnings</th>
                                <th>Hours</th>
                                <th>Rates</th>
                                <th>Amount</th>
                                <th>Deductions</th>
                                <th>Earnings</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><b>Basic :</b></td>
                                <td>");
#nullable restore
#line 44 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.ContractualHours.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.HourlyRate.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.ContractualEarnings.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><b>Tax:</b></td>\r\n                                <td>");
#nullable restore
#line 48 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.Tax.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Overtime :</b></td>\r\n                                <td>");
#nullable restore
#line 52 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeHours.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeRate.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeEarnings.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><b>NIC:</b></td>\r\n                                <td>");
#nullable restore
#line 56 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.NIC.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>Union Fee:</b></td>
                                <td>");
#nullable restore
#line 64 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.UnionFee.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>SLC:</b></td>
                                <td>");
#nullable restore
#line 72 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.SLC.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>Total :</b></td>\r\n                                <td>");
#nullable restore
#line 76 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.HoursWorked);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
#nullable restore
#line 78 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.TotalEarnings.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
#nullable restore
#line 80 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.TotalDeduction.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class=""table-dark""><b>NET PAY:</b></td>
                                <td class=""table-dark"">");
#nullable restore
#line 90 "G:\.NET Core\PaycomputeApp\Paycompute\Views\Pay\Payslip.cshtml"
                                                  Write(Model.NetPayment.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tfoot>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentRecordDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
