#pragma checksum "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81b39440b1042557ee40578886debc7e64ad7e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project__ProjectDetails), @"mvc.1.0.view", @"/Views/Project/_ProjectDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b39440b1042557ee40578886debc7e64ad7e8c", @"/Views/Project/_ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e4e4f0fe33f8274ebfe4226897e88f18c18210", @"/Views/_ViewImports.cshtml")]
    public class Views_Project__ProjectDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollabDocEd.Models.ProjectModels.ProjectDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisableProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"



<div class=""row"">
    <div class=""col-md"">

        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <h4 style=""margin-right:20px"">Project details</h4>

            <div class=""modal fade"" id=""addDocumentModalView"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" id=""addDocument"" role=""document"">

                </div>
            </div>
            <div class=""modal fade"" id=""inviteUserToProjectModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" id=""inviteUserToProject"" role=""document"">

                </div>
            </div>
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav"">
                    
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link d");
            WriteLiteral("ropdown-toggle\" data-toggle=\"dropdown\" href=\"#\" role=\"button\" aria-haspopup=\"true\" aria-expanded=\"false\">Documents</a>\r\n                        <div class=\"dropdown-menu\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1294, "\"", 1301, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                               data-ajax=\"true\"\r\n                               data-ajax-method=\"GET\"\r\n                               data-ajax-url=\"/Document/AddDocument/?projectId=");
#nullable restore
#line 32 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                                          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                               data-ajax-update=""#addDocument""
                               class=""nav-link dropdown-item""
                               data-toggle=""modal""
                               data-target=""#addDocumentModalView"">

                                Add document
                            </a>

                            <a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1868, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                               data-ajax=\"true\"\r\n                               data-ajax-method=\"GET\"\r\n                               data-ajax-url=\"/Document/GetAllDocuments/");
#nullable restore
#line 44 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                               data-ajax-update=""#divInfo""
                               class=""nav-link dropdown-item""
                               >


                                All documents
                            </a>
                            <div class=""dropdown-divider""></div>

                        </div>
                    </li>

");
#nullable restore
#line 57 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                     if (Model.Creator == User.Identity.Name)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Users</a>
                            <div class=""dropdown-menu"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 2827, "\"", 2834, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                                   data-ajax=\"true\"\r\n                                   data-ajax-method=\"GET\"\r\n                                   data-ajax-url=\"/Project/InviteUserToProject/?projectId=");
#nullable restore
#line 65 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                                                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                   data-ajax-update=""#inviteUserToProject""
                                   class=""nav-link""
                                   data-toggle=""modal""
                                   data-target=""#inviteUserToProjectModal"">

                                    Invite user
                                </a>
                                
                                <a");
            BeginWriteAttribute("href", " href=\"", 3470, "\"", 3477, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link dropdown-item\"\r\n                                   data-ajax=\"true\"\r\n                                   data-ajax-method=\"GET\"\r\n                                   data-ajax-url=\"/Project/GetAllUsers/");
#nullable restore
#line 77 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                   data-ajax-update=""#divInfo"">
                                    All users
                                </a>
                                <div class=""dropdown-divider""></div>

                            </div>
                        </li>
");
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b39440b1042557ee40578886debc7e64ad7e8c11550", async() => {
                WriteLiteral("Disable project");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b39440b1042557ee40578886debc7e64ad7e8c13116", async() => {
                WriteLiteral("Delete project");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 92 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <span class=\"text-muted small\">Creator: ");
#nullable restore
#line 102 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                           Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <br />\r\n        <span class=\"text-muted small\">Created: ");
#nullable restore
#line 104 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                           Write(Model.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"divInfo\">\r\n");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b39440b1042557ee40578886debc7e64ad7e8c15868", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b39440b1042557ee40578886debc7e64ad7e8c16968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CollabDocEd.Models.ProjectModels.ProjectDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
