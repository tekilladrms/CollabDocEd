#pragma checksum "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a220271c5a026122e81a5e2d86fe6816300e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project__AllUsers), @"mvc.1.0.view", @"/Views/Project/_AllUsers.cshtml")]
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
#line 1 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\_ViewImports.cshtml"
using CollabDocEd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\_ViewImports.cshtml"
using CollabDocEd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a220271c5a026122e81a5e2d86fe6816300e2b", @"/Views/Project/_AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e4e4f0fe33f8274ebfe4226897e88f18c18210", @"/Views/_ViewImports.cshtml")]
    public class Views_Project__AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollabDocEd.Models.ProjectModels.AllUsersModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 70, "\"", 77, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n   data-ajax=\"true\"\r\n   data-ajax-method=\"GET\"\r\n   data-ajax-url=\"/Project/InviteUserToProject/?projectId=");
#nullable restore
#line 10 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
                                                     Write(Model.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
   data-ajax-update=""#inviteUserToProject""
   class=""btn btn-success""
   data-toggle=""modal""
   data-target=""#inviteUserToProjectModal"">

    Invite user
</a>
<hr />
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">User</th>
            <th scope=""col""></th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
         foreach (var el in Model.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
               Write(el.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                \r\n                <td>\r\n");
#nullable restore
#line 38 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
                     if (el.Email != Model.Creator)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 852, "\"", 859, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                           data-ajax=\"true\"\r\n                           data-ajax-method=\"POST\"\r\n                           data-ajax-url=\"/Project/ExcludeUserFromProject/?projectId=");
#nullable restore
#line 43 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
                                                                                Write(Model.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&userId=");
#nullable restore
#line 43 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
                                                                                                        Write(el.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                           data-ajax-update=\"#divInfo\"\r\n                           class=\"btn btn-danger\">\r\n                            Exclude\r\n                        </a>\r\n");
#nullable restore
#line 48 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Creator has not be exclude</p>\r\n");
#nullable restore
#line 52 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 56 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_AllUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3a220271c5a026122e81a5e2d86fe6816300e2b7899", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3a220271c5a026122e81a5e2d86fe6816300e2b8998", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CollabDocEd.Models.ProjectModels.AllUsersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591