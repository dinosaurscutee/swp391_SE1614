#pragma checksum "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 6 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\Home\Index.cshtml"
using InsuranceCard1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/loginindex.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/slide1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slide1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/slide2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slide2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/myjs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e6569", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400|Source+Code+Pro:700,900&display=swap""
          rel=""stylesheet"">
    <link rel=""shortcut icon"" href=""img/logo.png"" type=""image/x-icon"" />
    <!-- CSS Libraries -->
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e7598", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e8777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <title>Home</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e10695", async() => {
                WriteLiteral(@"
    <section class=""top"">
        <div class=""contenner"">
            <script type=""text/javascript"">
                $(function () {
                    $("".li-acc>a"").click(function (e) {
                        e.stopPropagation();
                        $("".panel-acc"").stop().slideToggle();
                        return false;
                    });
                });
            </script>

            <nav class=""nav-top nav-top1"">
");
#nullable restore
#line 44 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\Home\Index.cshtml"
                  if (Model == null)
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li><a id=\"login-btn\" onclick=\"return false\"");
                BeginWriteAttribute("alt", " alt=\"", 1693, "\"", 1699, 0);
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 1700, "\"", 1707, 0);
                EndWriteAttribute();
                WriteLiteral(">Đăng nhập/Đăng kí</a><br /></li>\r\n");
#nullable restore
#line 47 "C:\FinalProjectSWP\InsuranceCard\InsuranceCard1\Views\Home\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </nav>
        </div>
    </section>
    <section class=""login-register hidden"">
        <div class=""wrapper"">
            <label id=""show"" class=""close-btn fas fa-times"" title=""close"" style=""float: right;""></label>
            <div class=""form-container"">
                <div class=""slide-controls"">
                    <input type=""radio"" name=""slide"" id=""login"" checked>
                    <input type=""radio"" name=""slide"" id=""signup"">
                    <label for=""login"" class=""slide login"">Login</label>
                    <label for=""signup"" class=""slide signup"">Signup</label>
                    <div class=""slider-tab""></div>
                </div>
                <div class=""form-inner"">
                    <form action=""/Login/CheckAcc"" class=""login"" method=""post"">
                        <div class=""field"">
                            <input type=""text"" name=""uid""");
                BeginWriteAttribute("value", " value=\"", 2678, "\"", 2686, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Tên Đăng Nhập\" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"password\" name=\"pwd\"");
                BeginWriteAttribute("value", " value=\"", 2865, "\"", 2873, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Mật khẩu"" required>
                        </div>
                              Admin <input type=""checkbox"" value=""1"" name=""role""/>
                        <div class=""pass-link"">
                            <a href=""/Forgetpass/Forget"">Forgot password?</a>
                        </div>
                        <div class=""field btn"">
                            <div class=""btn-layer""></div>
                            <input type=""submit"" value=""Login"">
                        </div>
                        <div class=""signup-link"">
                            Not a member? <a");
                BeginWriteAttribute("href", " href=\"", 3485, "\"", 3492, 0);
                EndWriteAttribute();
                WriteLiteral(@">Signup now</a>
                        </div>
                    </form>
                    <form action=""/CustomerUser/Register"" method=""post"" class=""signup"">
                        <div class=""field"">
                            <input type=""text"" placeholder=""adress"" name=""model.Address""");
                BeginWriteAttribute("value", " value=\"", 3793, "\"", 3801, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"number\" placeholder=\"Id\" name=\"model.CustomerId\"");
                BeginWriteAttribute("value", " value=\"", 3980, "\"", 3988, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"text\" placeholder=\"Name\" name=\"model.Name\"");
                BeginWriteAttribute("value", " value=\"", 4161, "\"", 4169, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        </div>

                        <input type=""checkbox"" name=""model.Gender"" value=""Nam""> Nam
                        <input type=""checkbox"" name=""model.Gender"" value=""Nữ""> Nu
                        <div class=""field"">
                            <input type=""date"" placeholder=""Date Of Birth"" name=""model.Dateofbirth""");
                BeginWriteAttribute("value", " value=\"", 4528, "\"", 4536, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"number\" placeholder=\"Identity Number\" name=\"model.IdentityNumber\"");
                BeginWriteAttribute("value", " value=\"", 4732, "\"", 4740, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"text\" placeholder=\"Email Address\" name=\"model.Email\"");
                BeginWriteAttribute("value", " value=\"", 4923, "\"", 4931, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"number\" placeholder=\"phone\" name=\"model.Phone\"");
                BeginWriteAttribute("value", " value=\"", 5108, "\"", 5116, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"text\" placeholder=\"User Name\" name=\"model.Username\"");
                BeginWriteAttribute("value", " value=\"", 5298, "\"", 5306, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                        </div>\r\n                        <div class=\"field\">\r\n                            <input type=\"password\" placeholder=\"Password\" name=\"model.Password\"");
                BeginWriteAttribute("value", " value=\"", 5491, "\"", 5499, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                        </div>


                        <div class=""field btn"">
                            <div class=""btn-layer""></div>
                            <input type=""submit"" value=""Signup"">
                        </div>
                        <div class=""signup-link"">
                            Account already! <a");
                BeginWriteAttribute("href", " href=\"", 5852, "\"", 5859, 0);
                EndWriteAttribute();
                WriteLiteral(@">Login now</a>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>


    <section class=""header shadow "">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-1 col-md-12 col-sm-12 col-xs-12 leftbaner"">
                    <div class=""logo"">
                        <a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e18888", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-11 col-md-6 col-sm-6 col-xs-6 hide-pad\">\r\n                    <div class=\"menubar\">\r\n                        <ul class=\"nav\">\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 6554, "\"", 6562, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Information/Car\"");
                BeginWriteAttribute("class", " class=\"", 6590, "\"", 6598, 0);
                EndWriteAttribute();
                WriteLiteral(">Bảo hiểm xe máy</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 6657, "\"", 6665, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Information/Health\"");
                BeginWriteAttribute("class", " class=\"", 6696, "\"", 6704, 0);
                EndWriteAttribute();
                WriteLiteral(">Bảo hiểm sức khoẻ</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 6765, "\"", 6773, 0);
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Information/Accident\"");
                BeginWriteAttribute("class", " class=\"", 6806, "\"", 6814, 0);
                EndWriteAttribute();
                WriteLiteral(@">Bảo hiểm tai nạn</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
                <!-- Indicators -->
                <ol class=""carousel-indicators"">
                    <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""3""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""4""></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class=""carousel-inner"">
                    <div class=""item active"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e22341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"item\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e23705", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>

                    <div class=""item"">
                        <img src=""img/slide3.png"" alt=""slide3"" style=""width:100%;"">
                    </div>
                    <div class=""item"">
                        <img src=""img/slide4.png"" alt=""slide4"" style=""width:100%;"">
                    </div>
                    <div class=""item"">
                        <img src=""img/slide5.png"" alt=""slide5"" style=""width:100%;"">
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
                    <span class=""glyphicon glyphicon-chevron-left""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                    <span class=""sr-only"">Next");
                WriteLiteral(@"</span>
                </a>
            </div>
        </div>
    </section>
    <section class=""wc"">
        <div class=""inner-wc"">
            <div class=""container"">
                <h1 class=""title-pro text-center""><a href=""#"">Về chúng tôi</a></h1>
                <div class=""content-wc"">
                    <b>#</b> là website bán hàng trực tuyến của Nhằm giúp khách hàng tiếp cận với các gói bảo hiểm cá nhân một cách dễ dàng, chúng tôi ưu tiên sự đơn giản, thuận tiện từ sản phẩm đến quy trình đặt mua và thanh toán.
                    Các sản phẩm bảo hiểm cung cấp trên website hướng tới nhu cầu cá nhân, thời gian đặt hàng 24/7 để tiết kiệm thời gian, công sức cho khách hàng.
                </div>
                <div class=""text-center""><a href=""#"" class=""btn-01 hvr-forward"">Xem thêm về Chúng tôi <i class=""fa fa-angle-right"" aria-hidden=""true""></i></a></div>
            </div>
        </div>
    </section>

    <section class=""why"">
        <div class=""container"">
            <h2 c");
                WriteLiteral(@"lass=""title-why text-center"">
                <a href=""#"">Tại sao chọn<br />Chúng tôi</a>
            </h2>
            <div class=""row"">
                <div class=""col-lg-3 col-md-6 col-sm-6 col-xs-6"">
                    <div class=""item-why hvr-float"">
                        <h3 class=""title-item-why text-center"">ĐƠN GIẢN, NHANH CHÓNG,<br />THUẬN TIỆN</h3>
                        <div class=""num text-center"">10 PHÚT</div>
                        <div class=""intro-item-why"" style=""text-align: justify"">Là thời gian để khách hàng nhận Giấy chứng nhận bảo hiểm điện tử qua email sau khi thanh toán thành công</div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-6 col-xs-6"">
                    <div class=""item-why hvr-float"">
                        <h3 class=""title-item-why text-center"">KHUYẾN MẠI HẤP DẪN<br /><br /></h3>
                        <div class=""num text-center"">LÊN TỚI 50%</div>
                        <div class=""intro-item-w");
                WriteLiteral(@"hy"" style=""text-align: justify"">Là mức ưu đãi phí hàng năm dành cho khách hàng mua bảo hiểm online qua website trực tuyến</div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-6 col-xs-6"">
                    <div class=""item-why hvr-float"">
                        <h3 class=""title-item-why text-center"">HỆ THỐNG ĐỐI TÁC<br />LIÊN KẾT TOÀN QUỐC</h3>
                        <div class=""num text-center"">> 300</div>
                        <div class=""intro-item-why"" style=""text-align: justify"">Là số lượng bệnh viện và gara sửa chữa liên kết phục vụ bảo lãnh bồi thường cho khách hàng </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 col-sm-6 col-xs-6"">
                    <div class=""item-why hvr-float"">
                        <h3 class=""title-item-why text-center"">MẠNG LƯỚI RỘNG KHẮP<br /><br /></h3>
                        <div class=""num text-center"">150</div>
                        <div ");
                WriteLiteral(@"class=""intro-item-why"" style=""text-align: justify"">Là số lượng phòng kinh doanh khu vực sẵn sàng phục vụ khách hàng trên toàn quốc</div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""line-gray"">
        <div class=""container"">
            <h2 class=""title-pro text-center""><a");
                BeginWriteAttribute("href", " href=\"", 12408, "\"", 12415, 0);
                EndWriteAttribute();
                WriteLiteral(@">Trung tâm hỗ trợ khách hàng</a></h2>
            <div class=""row"">
                <div class=""col-lg-4 col-md-6 col-sm-12"">
                    <div class=""box-bottom shadow hvr-float item-height"">
                        <h3 class=""hd-box-bottom hd-box-sup""><a href=""#""><b>Các câu hỏi thường gặp</b></a></h3>
                        <div class=""inner-box item-height"">
                            <div class=""intro-box-bottom"">
                                Giải đáp các thắc mắc của khách hàng về sản phẩm & dịch vụ
                            </div>
                            <a href=""#"" class=""btn-box-bottom"">Xem ngay <i class=""fa fa-angle-right"" aria-hidden=""true""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12"">
                    <div class=""box-bottom shadow hvr-float item-height"">
                        <h3 class=""hd-box-bottom hd-box-truvan""><a href=""#""><b>Truy vấn bồi thường online</b><");
                WriteLiteral(@"/a></h3>
                        <div class=""inner-box item-height"">
                            <div class=""intro-box-bottom"">
                                Hỗ trợ Khách hàng tra cứu thông tin/theo dõi tình trạng hồ sơ bồi thường 24/7
                            </div>
                            <a href=""#"" class=""btn-box-bottom"">Xem ngay <i class=""fa fa-angle-right"" aria-hidden=""true""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-12 col-sm-12"">
                    <div class=""box-bottom shadow hvr-float item-height"">
                        <h3 class=""hd-box-bottom hd-box-hot""><a href=""#""><i class=""fa fa-phone"" aria-hidden=""true""></i><b> Liên hệ hỗ trợ</b></a></h3>
                        <div class=""inner-box item-height"" style=""font-size:19px"">
                            <a class=""hotline-box"" href=""#""></a><br />
                            <a class=""hotline-box"" href=""#"">190010jqk</a>
              ");
                WriteLiteral(@"              <div>Email: #</div><br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-10 col-md-12"">
                    <ul class=""nav-footer"">

                        <li><a href=""dieu-khoan-su-dung-website"">Điều khoản sử dụng</a></li>
                        <li><a href=""bao-mat-va-quyen-rieng-tu-cua-khach-hang"">Bảo mật & quyền riêng tư</a></li>
                        <li><a href=""huong-dan-huy-hop-dong-bao-hiem"">Chính sách đổi và trả hàng</a></li>
                        <li><a href=""cac-buoc-dat-mua-bao-hiem-truc-tuyen"">Hình thức thanh toán và giao hàng</a></li>
                        <li><a href=""lien-he-voi-website-ban-bao-hiem-truc-tuyen"">Liên hệ</a></li>
                    </ul>
                </div>
                <div class=""col-lg-2 col-md-12"">
                  ");
                WriteLiteral(@"  <div class=""linksmo"">
                        <a href=""#"" rel=""nofollow"" target=""_blank"" class=""hvr-float shadow""><i class=""fa fa-facebook facebook""></i></a>

                    </div>
                </div>
            </div>
            <div class=""info-footer"">
                <strong>Tổng Công ty Cổ phần Bảo hiểm </strong><br />
                ĐC: thành phố Hà Nội <br />
                ĐT:190010jqk <br />
            </div>
    </section>


    <!-- JavaScript Libraries -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
    <script src=""lib/easing/easing.min.js""></script>
    <script src=""lib/slick/slick.min.js""></script>

    <!-- Template Javascript -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd5c9ff71bba36af9bd2e8f5dc4ecfc68767e7e33964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
