#pragma checksum "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be9564f49e066a4cb6e16096dc0b607e92711dd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be9564f49e066a4cb6e16096dc0b607e92711dd", @"/Views/Project/_ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e4e4f0fe33f8274ebfe4226897e88f18c18210", @"/Views/_ViewImports.cshtml")]
    public class Views_Project__ProjectDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollabDocEd.Models.ProjectModels.ProjectDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Document", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md\">\r\n\r\n        <nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n            <h4 style=\"margin-right:20px\">");
#nullable restore
#line 11 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" details</h4>\r\n");
            WriteLiteral(@"            <div class=""modal fade"" id=""addDocumentModalView"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" id=""addDocument"" role=""document"">

                </div>
            </div>
            <div class=""modal fade"" id=""inviteUserToProjectModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" id=""inviteUserToProject"" role=""document"">

                </div>
            </div>
            <div class=""modal fade"" id=""addCommentModalView"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" id=""addComment"" role=""document"">

                </div>
            </div>
            <div class=""modal fade"" id=""deleteProjectModalView"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModa");
            WriteLiteral("lCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" id=\"deleteProject\" role=\"document\">\r\n\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral(@"            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav"">

                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Documents</a>
                        <div class=""dropdown-menu"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1937, "\"", 1944, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                               data-ajax=\"true\"\r\n                               data-ajax-method=\"GET\"\r\n                               data-ajax-url=\"/Document/AddDocument/?projectId=");
#nullable restore
#line 44 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 2504, "\"", 2511, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                               data-ajax=\"true\"\r\n                               data-ajax-method=\"GET\"\r\n                               data-ajax-url=\"/Document/GetAllDocuments/");
#nullable restore
#line 56 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                               data-ajax-update=""#divInfo""
                               class=""nav-link dropdown-item"">


                                All documents
                            </a>
                            <div class=""dropdown-divider""></div>

                        </div>
                    </li>


                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Users</a>
                        <div class=""dropdown-menu"">
");
#nullable restore
#line 72 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                             if (Model.Creator == User.Identity.Name)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 3443, "\"", 3450, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                                   data-ajax=\"true\"\r\n                                   data-ajax-method=\"GET\"\r\n                                   data-ajax-url=\"/Project/InviteUserToProject/?projectId=");
#nullable restore
#line 77 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
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
");
#nullable restore
#line 85 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 4079, "\"", 4086, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link dropdown-item\"\r\n                               data-ajax=\"true\"\r\n                               data-ajax-method=\"GET\"\r\n                               data-ajax-url=\"/Project/GetAllUsers/");
#nullable restore
#line 89 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
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
#nullable restore
#line 97 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                     if (Model.Creator == User.Identity.Name)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4733, "\"", 4740, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                               data-ajax=\"true\"\r\n                               data-ajax-method=\"GET\"\r\n                               data-ajax-url=\"/Project/DeleteProject/?projectId=");
#nullable restore
#line 104 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                               data-ajax-update=""#deleteProject""
                               class=""nav-link dropdown-item""
                               data-toggle=""modal""
                               data-target=""#deleteProjectModalView"">Delete project</a>
                        </li>
");
#nullable restore
#line 110 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <span class=\"text-muted small\">Creator: ");
#nullable restore
#line 121 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                           Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <br />\r\n        <span class=\"text-muted small\">Created: ");
#nullable restore
#line 123 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                           Write(Model.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"divInfo\">\r\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 5645, "\"", 5652, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n       data-ajax=\"true\"\r\n       data-ajax-method=\"GET\"\r\n       data-ajax-url=\"/Document/AddDocument/?projectId=");
#nullable restore
#line 132 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n       data-ajax-update=\"#addDocument\"\r\n       class=\"btn btn-success btn-sm\"\r\n       data-toggle=\"modal\"\r\n       data-target=\"#addDocumentModalView\">\r\n\r\n        Add document\r\n    </a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 5970, "\"", 5977, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n       data-ajax=\"true\"\r\n       data-ajax-method=\"GET\"\r\n       data-ajax-url=\"/Project/AddComment/?projectId=");
#nullable restore
#line 143 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
       data-ajax-update=""#addComment""
       class=""btn btn-success btn-sm""
       data-toggle=""modal""
       data-target=""#addCommentModalView"">

        Add comment
    </a>
    <div id=""onScreen"" class=""onScreen"">
        <ul class=""onScreen-items"">
");
#nullable restore
#line 153 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
             foreach (var el in Model.onScreens)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"onScreen-item\">\r\n                    <div class=\"onScreen-item_header small\">\r\n                        ");
#nullable restore
#line 157 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                   Write(el.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 159 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                   Write(el.Created.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ?? ");
#nullable restore
#line 159 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                                     Write(el.Created.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>");
#nullable restore
#line 161 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                    Write(el.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 162 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                     if (el.Filename != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"onScreen-item_file\">\r\n                            <span class=\"small\">Attached file: </span>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be9564f49e066a4cb6e16096dc0b607e92711dd18268", async() => {
                WriteLiteral("\r\n\r\n                                ");
#nullable restore
#line 172 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                           Write(el.Filename);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 170 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                                 WriteLiteral(el.Id);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 175 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <hr />\r\n                </li>\r\n");
#nullable restore
#line 179 "D:\VeryInteresting\CollabDocEd\CollabDocEd\CollabDocEd\Views\Project\_ProjectDetails.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be9564f49e066a4cb6e16096dc0b607e92711dd22044", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be9564f49e066a4cb6e16096dc0b607e92711dd23144", async() => {
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
