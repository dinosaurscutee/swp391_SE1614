#pragma checksum "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70afe86c5bf62e2f2590f82edd231230597a3b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerUser_Add), @"mvc.1.0.view", @"/Views/CustomerUser/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70afe86c5bf62e2f2590f82edd231230597a3b16", @"/Views/CustomerUser/Add.cshtml")]
    public class Views_CustomerUser_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleForm.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70afe86c5bf62e2f2590f82edd231230597a3b163940", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n    <title>Add Customer_User Information Form</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70afe86c5bf62e2f2590f82edd231230597a3b164338", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70afe86c5bf62e2f2590f82edd231230597a3b166307", async() => {
                WriteLiteral("\r\n    <h2>Add Customer_User Information</h2>\r\n    <form action=\"/CustomerUser/DoAdd\" method=\"post\">\r\n        <p> <h2>");
#nullable restore
#line 16 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\CustomerUser\Add.cshtml"
           Write(ViewData["Caution"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2> </p>\r\n        <p>CustomerId: <input type=\"text\" name=\"NewCs.CustomerId\"");
                BeginWriteAttribute("value", " value=\"", 594, "\"", 602, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>CustomerName: <input type=\"text\" name=\"NewCs.Name\"");
                BeginWriteAttribute("value", " value=\"", 673, "\"", 681, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>Gender: <input type=\"text\" name=\"NewCs.Gender\"");
                BeginWriteAttribute("value", " value=\"", 748, "\"", 756, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>Date Of Birth: <input type=\"text\" name=\"NewCs.Dateofbirth\"");
                BeginWriteAttribute("value", " value=\"", 835, "\"", 843, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>IdentityNumber: <input type=\"text\" name=\"NewCs.IdentityNumber\"");
                BeginWriteAttribute("value", " value=\"", 926, "\"", 934, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>Email: <input type=\"text\" name=\"NewCs.Email\"");
                BeginWriteAttribute("value", " value=\"", 999, "\"", 1007, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>Phone: <input type=\"text\" name=\"NewCs.Phone\"");
                BeginWriteAttribute("value", " value=\"", 1072, "\"", 1080, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>UserName: <input type=\"text\" name=\"NewCs.Username\"");
                BeginWriteAttribute("value", " value=\"", 1151, "\"", 1159, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>Address: <input type=\"text\" name=\"NewCs.Address\"");
                BeginWriteAttribute("value", " value=\"", 1228, "\"", 1236, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>Password: <input type=\"text\" name=\"NewCs.Password\"");
                BeginWriteAttribute("value", " value=\"", 1307, "\"", 1315, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p>StaffID: <input type=\"text\" name=\"NewCs.StaffID\"");
                BeginWriteAttribute("value", " value=\"", 1384, "\"", 1392, 0);
                EndWriteAttribute();
                WriteLiteral(" /></p>\r\n        <p><input type=\"submit\" value=\"Submit\" /></p>\r\n    </form>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
