#pragma checksum "F:\git_layouteditor_core\LayoutEditor\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da590d7832844329896154c7bfc9377d5797d14e"
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
#line 1 "F:\git_layouteditor_core\LayoutEditor\Views\_ViewImports.cshtml"
using LayoutEditor;

#line default
#line hidden
#line 2 "F:\git_layouteditor_core\LayoutEditor\Views\_ViewImports.cshtml"
using LayoutEditor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da590d7832844329896154c7bfc9377d5797d14e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449d69c305fb9e2e8b9c4c0b0af50f2ec012af33", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit toolbox-reset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c47e620b105a426fb5fcc0430784f912", async() => {
                BeginContext(31, 1281, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css"">
        <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta name=""title"" content=""Create page with Bootstrap"">
    <meta name=""description"" content=""Create page with Bootstrap"">
    <meta name=""keywords"" content=""Create page with Bootstrap"">
    <title>Bootstrap Page Builder</title>
        <link href=""css/toolbox.css"" rel=""stylesheet"">
    <link href=""css/editor.css"" rel=""stylesheet"">
    <link href=""css/docs.min.css"" rel=""stylesheet"">
    <link rel=""shortcut icon"" href=""img/favicon.png"">
    <style>
  .container-fluid{
      *zoom:1;margin-left: 0px;
      margin-top: 10px;
      padding: 30px 15px 15px;
      border: 1px solid #DDDDDD;
      border-radius: 4px;
      position: relative;
      word-wrap: break-word;
  }
  body.devpreview {
     ");
                WriteLiteral(@" margin-top: 60px;
      margin-left:5px !important;
  }
   span.fa-6{
    font-size: 20em;
}
span.fa-5{
    font-size: 12em;
}
span.fa-4{
    font-size: 7em;
}
span.fa-3{
    font-size: 4em;
}
span.fa-2{
    font-size: 2em;
}
  </style>
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
            BeginContext(1319, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1321, 4558, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcd1c55fc16f4e3185d7e9a1bc553313", async() => {
                BeginContext(1376, 2339, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-inverse navbar-fixed-top"">
              <div class=""navbar-header"" style=""margin-right: 100px;"">
        <a class=""navbar-brand emphasized3"" href=""#"">
          Bootstrap Page Builder
        </a>
      </div>
      <div class=""collapse navbar-collapse"" id=""bs-example-navbar-collapse-3"">
        <ul class=""nav navbar-nav"">
          <li>
            <div class=""btn-group"" style=""margin-right: 20px;"">
              <button onclick=""resizeCanvas('lg')"" class=""btn btn-default navbar-btn""><i class=""fa fa-desktop""></i> </button>
              <button onclick=""resizeCanvas('md')"" class=""btn btn-default navbar-btn""><i class=""fa fa-laptop""></i> </button>
              <button onclick=""resizeCanvas('sm')"" class=""btn btn-default navbar-btn""><i class=""fa fa-tablet""></i> </button>
              <button onclick=""resizeCanvas('xs')"" class=""btn btn-default navbar-btn""><i class=""fa fa-mobile-phone""></i> </button>
            </div>
          </li>
          <li>
            <");
                WriteLiteral(@"div class=""btn-group"" data-toggle=""buttons-radio"">
              <button id=""edit"" class=""btn btn-default navbar-btn"">
                <i class=""fa fa-edit""></i> Edit
              </button>
              <button type=""button"" class=""btn btn-default navbar-btn"" id=""devpreview"">
                <i class=""fa icon-eye-close"" style=""color: #333;""></i> Developer
              </button>
              <button type=""button"" class=""btn btn-default navbar-btn"" id=""sourcepreview"" >
                <i class=""fa icon-eye-open"" style=""color: #333;""></i> Preview
              </button>
            </div>
          </li>

        </ul>
        <ul class=""nav navbar-nav navbar-right"">
          <li>
            <div class=""btn-group"">
              <button class=""btn btn-default navbar-btn"" href=""#clear"" id=""clear"" color=""#333;"">
                <i class=""fa icon-trash"" style=""color: #333;""></i>Clear
              </button>
              <button type=""button"" class=""btn btn-primary navbar-btn"" data-target=");
                WriteLiteral(@"""#downloadModal"" rel=""/build/downloadModal"" role=""button"" data-toggle=""modal"">
                <i class=""fa icon-chevron-down"" ></i>Download
              </button>
            </div>
          </li>
        </ul>
      </div>
    </nav>

    <div class=""container-fluid"">
        ");
                EndContext();
                BeginContext(3716, 12, false);
#line 95 "F:\git_layouteditor_core\LayoutEditor\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3728, 2144, true);
                WriteLiteral(@"
    </div>

        <script type=""text/javascript"" src=""js/jquery-2.0.0.min.js""></script>
    <!--[if lt IE 9]>
    <script type=""text/javascript"" src=""http://code.jquery.com/jquery-1.9.1.min.js""></script>
    <![endif]-->
    <script type=""text/javascript"" src=""js/bootstrap.min.js""></script>
    <script type=""text/javascript"" src=""js/jquery-ui.js""></script>
    <script type=""text/javascript"" src=""js/jquery.ui.touch-punch.min.js""></script>
    <script type=""text/javascript"" src=""js/jquery.htmlClean.js""></script>
    <script type=""text/javascript"" src=""ckeditor/ckeditor.js""></script>
    <script type=""text/javascript"" src=""ckeditor/config.js""></script>
    <script type=""text/javascript"" src=""js/scripts.js""></script>
    <script type=""text/javascript"" src=""js/FileSaver.js""></script>
    <script type=""text/javascript"" src=""js/blob.js""></script>
    <script src=""js/docs.min.js""></script>
    <script>
      function resizeCanvas(size)
      {

      var containerID = document.getElementsByCla");
                WriteLiteral(@"ssName(""changeDimension"");
      var containerDownload = document.getElementById(""download-layout"").getElementsByClassName(""container-fluid"")[0];
      var row = document.getElementsByClassName(""demo ui-sortable"");
      var container1 = document.getElementsByClassName(""container1"");
      if (size == ""md"")
      {
      $(containerID).width('id', ""MD"");
      $(row).attr('id', ""MD"");
      $(container1).attr('id', ""MD"");
      $(containerDownload).attr('id', ""MD"");
      }
      if (size == ""lg"")
      {
      $(containerID).attr('id', ""LG"");
      $(row).attr('id', ""LG"");
      $(container1).attr('id', ""LG"");
      $(containerDownload).attr('id', ""LG"");
      }
      if (size == ""sm"")
      {
      $(containerID).attr('id', ""SM"");
      $(row).attr('id', ""SM"");
      $(container1).attr('id', ""SM"");
      $(containerDownload).attr('id', ""SM"");
      }
      if (size == ""xs"")
      {
      $(containerID).attr('id', ""XS"");
      $(row).attr('id', ""XS"");
      $(container1).attr('id");
                WriteLiteral("\', \"XS\");\r\n      $(containerDownload).attr(\'id\', \"XS\");\r\n\r\n      }\r\n\r\n\r\n      }\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5879, 11, true);
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
