#pragma checksum "E:\PROJECT\MVC\Ecommerce\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9317a34214aad464188115f191f6fa53ba05937a"
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
#line 1 "E:\PROJECT\MVC\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\MVC\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9317a34214aad464188115f191f6fa53ba05937a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\PROJECT\MVC\Ecommerce\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>  \r\n<html lang=\"en\">  \r\n  \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9317a34214aad464188115f191f6fa53ba05937a5193", async() => {
                WriteLiteral("  \r\n  \r\n    <meta charset=\"utf-8\">  \r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">  \r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">  \r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 297, "\"", 307, 0);
                EndWriteAttribute();
                WriteLiteral(">  \r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 336, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(@">  
  
    <title>Freelancer - Start Bootstrap Theme</title>  
  
    <!-- Bootstrap Core CSS - Uses Bootswatch Flatly Theme: http://bootswatch.com/flatly/ -->  
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">  
  
    <!-- Custom CSS -->  
    <link href=""css/freelancer.css"" rel=""stylesheet"">  
  
    <!-- Custom Fonts -->  
    <link href=""font-awesome/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"">  
    <link href=""http://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">  
    <link href=""http://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"">  
  
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->  
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->  
    <!--[if lt IE 9]>  
<script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>  
<script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/res");
                WriteLiteral("pond.min.js\"></script>  \r\n<![endif]-->  \r\n  \r\n");
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
            WriteLiteral("  \r\n  \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9317a34214aad464188115f191f6fa53ba05937a7874", async() => {
                WriteLiteral(@"  

     <!-- Header-->
        <header class=""bg-white py-5 "">
           <!-- start carusel-->
<div class=""container-fluid1 mb-5 "">
<div id=""carouselExampleIndicators""
      class=""carousel slide""
      data-bs-ride=""carousel""
    >
      <div class=""carousel-inner active"">
        <div class=""carousel-item active"">
          <img class=""d-block w-100"" src=""https://www2.splashfashions.com/jo/sites/default/files/Desktop_2900x1200_1.jpg"" alt=""First slide"">
        </div>
        <div class=""carousel-item "" >
          <img class=""d-block w-100"" src=""https://www2.splashfashions.com/jo/sites/default/files/Desktop_2900x1200-Ramadan.jpg"" alt=""Second slide"">
        </div>
        <div class=""carousel-item "" >
          <img class=""d-block w-100 img-responsive"" src=""https://www2.splashfashions.com/jo/sites/default/files/Desktop_2900x1200_2.jpg "" alt=""Third slide"">
        </div>
        <div class=""carousel-item "" >
          <img class=""d-block w-100 img-responsive"" src=""https://www2.splashfa");
                WriteLiteral(@"shions.com/jo/sites/default/files/Desktop_2900x1200-Plus.jpg "" alt=""Third slide"">
        </div>
      </div>
      </div>
      <button
        class=""carousel-control-prev""
        type=""button""
        data-bs-target=""#carouselExampleIndicators""
        data-bs-slide=""prev""
      >
      <i class=""fas fa-angle-left""></i>
        <!-- <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span> -->
        <span class=""visually-hidden"">Previous</span>
      </button>
      <button
        class=""carousel-control-next ""
        type=""button""
        data-bs-target=""#carouselExampleIndicators""
        data-bs-slide=""next""
      >
        <i class=""fas fa-angle-right ""></i>
        <!-- <span class=""carousel-control-next-icon"" aria-hidden=""true""></span> -->
        <span class=""visually-hidden"" ></span>
      </button>
    </div>
</header>

");
                WriteLiteral("\r\n<h2 style=\"color:rgb(78 115 223);\">Select Category</h2>\r\n<br />\r\n\r\n<select id=\"categories\" class =\"form-control\" onchange=\"getAll()\" >\r\n");
#nullable restore
#line 91 "E:\PROJECT\MVC\Ecommerce\Views\Home\Index.cshtml"
     foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9317a34214aad464188115f191f6fa53ba05937a10555", async() => {
#nullable restore
#line 93 "E:\PROJECT\MVC\Ecommerce\Views\Home\Index.cshtml"
                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "E:\PROJECT\MVC\Ecommerce\Views\Home\Index.cshtml"
           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("       \r\n");
#nullable restore
#line 94 "E:\PROJECT\MVC\Ecommerce\Views\Home\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</select>



<div id = ""Products""></div>
<script>
    
    function getAll(){
        var id=$(""#categories"").val();
        
        $.ajax(
            {
                url: `/Home/Products?CatId=${id}`,
                
                success: function(result){
                    
                    $(""#Products"").html(result);
                }
            }
         );
    }
</script>




<!--end carusel-->
        
  
    <!-- Navigation -->  
");
                WriteLiteral("            <!-- Brand and toggle get grouped for better mobile display -->  \r\n");
                WriteLiteral("            <!-- Collect the nav links, forms, and other content for toggling -->  \r\n");
                WriteLiteral("            <!-- /.navbar-collapse -->  \r\n");
                WriteLiteral("        <!-- /.container-fluid -->  \r\n");
                WriteLiteral("    <!-- Header -->  \r\n");
                WriteLiteral("  \r\n    <!-- Portfolio Grid Section -->  \r\n");
                WriteLiteral("  \r\n    <!-- About Section -->  \r\n");
                WriteLiteral(@"  
    <!-- Contact Section -->  
    <section id=""contact"">  
        <div class=""container"">  
            <div class=""row"">  
                <div class=""col-lg-12 text-center"">  
                    <h2>Contact Me</h2>  
                    <hr class=""star-primary"">  
                </div>  
            </div>  
            <div class=""row"">  
                <div class=""col-lg-8 col-lg-offset-2"">  
                    <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19. -->  
                    <!-- The form should work on most web servers, but if the form is not working you may need to configure your web server differently. -->  
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9317a34214aad464188115f191f6fa53ba05937a14415", async() => {
                    WriteLiteral(@"  
                        <div class=""row control-group"">  
                            <div class=""form-group col-xs-12 floating-label-form-group controls"">  
                                <label>Name</label>  
                                <input type=""text"" class=""form-control"" placeholder=""Name"" id=""name"" required data-validation-required-message=""Please enter your name."">  
                                <p class=""help-block text-danger""></p>  
                            </div>  
                        </div>  
                        <div class=""row control-group"">  
                            <div class=""form-group col-xs-12 floating-label-form-group controls"">  
                                <label>Email Address</label>  
                                <input type=""email"" class=""form-control"" placeholder=""Email Address"" id=""email"" required data-validation-required-message=""Please enter your email address."">  
                                <p class=""help-block text-danger""></p");
                    WriteLiteral(@">  
                            </div>  
                        </div>  
                        <div class=""row control-group"">  
                            <div class=""form-group col-xs-12 floating-label-form-group controls"">  
                                <label>Phone Number</label>  
                                <input type=""tel"" class=""form-control"" placeholder=""Phone Number"" id=""phone"" required data-validation-required-message=""Please enter your phone number."">  
                                <p class=""help-block text-danger""></p>  
                            </div>  
                        </div>  
                        <div class=""row control-group"">  
                            <div class=""form-group col-xs-12 floating-label-form-group controls"">  
                                <label>Message</label>  
                                <textarea rows=""5"" class=""form-control"" placeholder=""Message"" id=""message"" required data-validation-required-message=""Please enter a messag");
                    WriteLiteral(@"e.""></textarea>  
                                <p class=""help-block text-danger""></p>  
                            </div>  
                        </div>  
                        <br>  
                        <div id=""success""></div>  
                        <div class=""row"">  
                            <div class=""form-group col-xs-12"">  
                                <button type=""submit"" class=""btn btn-success btn-lg"">Send</button>  
                            </div>  
                        </div>  
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("  \r\n                </div>  \r\n            </div>  \r\n        </div>  \r\n    </section>  \r\n  \r\n    <!-- Footer -->  \r\n");
                WriteLiteral("  \r\n    <!-- Scroll to Top Button (Only visible on small and extra-small screen sizes) -->  \r\n");
                WriteLiteral("  \r\n    <!-- Portfolio Modals -->  \r\n");
                WriteLiteral(@"  
    <!-- jQuery -->  
    <script src=""js/jquery.js""></script>  
  
    <!-- Bootstrap Core JavaScript -->  
    <script src=""js/bootstrap.min.js""></script>  
  
    <!-- Plugin JavaScript -->  
    <script src=""http://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js""></script>  
    <script src=""js/classie.js""></script>  
    <script src=""js/cbpAnimatedHeader.js""></script>  
  
    <!-- Contact Form JavaScript -->  
    <script src=""js/jqBootstrapValidation.js""></script>  
    <script src=""js/contact_me.js""></script>  
  
    <!-- Custom Theme JavaScript -->  
    <script src=""js/freelancer.js""></script>  
  
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n  \r\n</html>  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
