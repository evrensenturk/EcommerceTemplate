#pragma checksum "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9769a43c4429d7b1a3029545b00cb653ad1d92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\_ViewImports.cshtml"
using CoreMvcNTier;

#line default
#line hidden
#line 2 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\_ViewImports.cshtml"
using CoreMvcNTier.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9769a43c4429d7b1a3029545b00cb653ad1d92", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3307f6362942c0dfd310b59effa96bf3ac9583", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dafc07454f524a9da6e855075e4551a9", async() => {
                BeginContext(31, 1951, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Bootshop online Shopping cart</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <!--Less styles -->
    <!-- Other Less css file //different less files has different color scheam
     <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/simplex.less"">
     <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/classified.less"">
     <link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/amelia.less"">  MOVE DOWN TO activate
     -->
    <!--<link rel=""stylesheet/less"" type=""text/css"" href=""/themes/less/bootshop.less"">
    <script src=""/themes/js/less.js"" type=""text/javascript""></script> -->
    <!-- Bootstrap style -->
    <link id=""callCss"" rel=""stylesheet"" href=""/themes/bootshop/bootstrap.min.css"" media=""screen"" />
    <link href=""/themes/css/base.css"" rel=""stylesheet"" media=""screen"" />
    <!-- Bootstrap style resp");
                WriteLiteral(@"onsive -->
    <link href=""/themes/css/bootstrap-responsive.min.css"" rel=""stylesheet"" />
    <link href=""/themes/css/font-awesome.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Google-code-prettify -->
    <link href=""/themes/js/google-code-prettify/prettify.css"" rel=""stylesheet"" />
    <!-- fav and touch icons -->
    <link rel=""shortcut icon"" href=""/themes/images/ico/favicon.ico"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""144x144"" href=""/themes/images/ico/apple-touch-icon-144-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""114x114"" href=""/themes/images/ico/apple-touch-icon-114-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" sizes=""72x72"" href=""/themes/images/ico/apple-touch-icon-72-precomposed.png"">
    <link rel=""apple-touch-icon-precomposed"" href=""/themes/images/ico/apple-touch-icon-57-precomposed.png"">
    <style type=""text/css"" id=""enject""></style>
");
                EndContext();
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
            EndContext();
            BeginContext(1989, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1991, 6930, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5fc4e29fb804d22bcb8de134ab63a0a", async() => {
                BeginContext(1997, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2005, 43, false);
#line 34 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_Header", new { }));

#line default
#line hidden
                EndContext();
                BeginContext(2049, 101, true);
                WriteLiteral("\r\n    <!-- Header End====================================================================== -->\r\n    ");
                EndContext();
                BeginContext(2151, 12, false);
#line 36 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2163, 94, true);
                WriteLiteral("\r\n    <!-- Footer ================================================================== -->\r\n    ");
                EndContext();
                BeginContext(2257, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3875695830b34f339738fc174c5860bd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2283, 6587, true);
                WriteLiteral(@"
    <!-- Placed at the end of the document so the pages load faster ============================================= -->
    <script src=""/themes/js/jquery.js"" type=""text/javascript""></script>
    <script src=""/themes/js/bootstrap.min.js"" type=""text/javascript""></script>
    <script src=""/themes/js/google-code-prettify/prettify.js""></script>
    <script src=""/themes/js/bootshop.js""></script>
    <script src=""/themes/js/jquery.lightbox-0.5.js""></script>
    <!-- /themes switcher section ============================================================================================= -->
    <div id=""secectionBox"">
        <link rel=""stylesheet"" href=""/themes/switch//themeswitch.css"" type=""text/css"" media=""screen"" />
        <script src=""/themes/switch/theamswitcher.js"" type=""text/javascript"" charset=""utf-8""></script>
        <div id=""themeContainer"">
            <div id=""hideme"" class=""themeTitle"">Style Selector</div>
            <div class=""themeName"">Oregional Skin</div>
            <div class=""image");
                WriteLiteral(@"s style"">
                <a href=""/themes/css/#"" name=""bootshop""><img src=""/themes/switch/images/clr/bootshop.png"" alt=""bootstrap business templates"" class=""active""></a>
                <a href=""/themes/css/#"" name=""businessltd""><img src=""/themes/switch/images/clr/businessltd.png"" alt=""bootstrap business templates"" class=""active""></a>
            </div>
            <div class=""themeName"">Bootswatch Skins (11)</div>
            <div class=""images style"">
                <a href=""/themes/css/#"" name=""amelia"" title=""Amelia""><img src=""/themes/switch/images/clr/amelia.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""spruce"" title=""Spruce""><img src=""/themes/switch/images/clr/spruce.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""superhero"" title=""Superhero""><img src=""/themes/switch/images/clr/superhero.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""cyborg""><img src=""/themes/swit");
                WriteLiteral(@"ch/images/clr/cyborg.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""cerulean""><img src=""/themes/switch/images/clr/cerulean.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""journal""><img src=""/themes/switch/images/clr/journal.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""readable""><img src=""/themes/switch/images/clr/readable.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""simplex""><img src=""/themes/switch/images/clr/simplex.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""slate""><img src=""/themes/switch/images/clr/slate.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""spacelab""><img src=""/themes/switch/images/clr/spacelab.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""united""><img src=""/themes/switch/images");
                WriteLiteral(@"/clr/united.png"" alt=""bootstrap business templates""></a>
                <p style=""margin:0;line-height:normal;margin-left:-10px;display:none;""><small>These are just examples and you can build your own color scheme in the backend.</small></p>
            </div>
            <div class=""themeName"">Background Patterns </div>
            <div class=""images patterns"">
                <a href=""/themes/css/#"" name=""pattern1""><img src=""/themes/switch/images/pattern/pattern1.png"" alt=""bootstrap business templates"" class=""active""></a>
                <a href=""/themes/css/#"" name=""pattern2""><img src=""/themes/switch/images/pattern/pattern2.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern3""><img src=""/themes/switch/images/pattern/pattern3.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern4""><img src=""/themes/switch/images/pattern/pattern4.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/c");
                WriteLiteral(@"ss/#"" name=""pattern5""><img src=""/themes/switch/images/pattern/pattern5.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern6""><img src=""/themes/switch/images/pattern/pattern6.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern7""><img src=""/themes/switch/images/pattern/pattern7.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern8""><img src=""/themes/switch/images/pattern/pattern8.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern9""><img src=""/themes/switch/images/pattern/pattern9.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern10""><img src=""/themes/switch/images/pattern/pattern10.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern11""><img src=""/themes/switch/images/pattern/pattern11.png"" alt=""bootstrap business templates""></a");
                WriteLiteral(@">
                <a href=""/themes/css/#"" name=""pattern12""><img src=""/themes/switch/images/pattern/pattern12.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern13""><img src=""/themes/switch/images/pattern/pattern13.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern14""><img src=""/themes/switch/images/pattern/pattern14.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern15""><img src=""/themes/switch/images/pattern/pattern15.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern16""><img src=""/themes/switch/images/pattern/pattern16.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern17""><img src=""/themes/switch/images/pattern/pattern17.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern18""><img src=""/themes/switch/images/pattern/patter");
                WriteLiteral(@"n18.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern19""><img src=""/themes/switch/images/pattern/pattern19.png"" alt=""bootstrap business templates""></a>
                <a href=""/themes/css/#"" name=""pattern20""><img src=""/themes/switch/images/pattern/pattern20.png"" alt=""bootstrap business templates""></a>
            </div>
        </div>
    </div>
    <span id=""/themesBtn""></span>
    ");
                EndContext();
                BeginContext(8871, 41, false);
#line 97 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(8912, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(8921, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
