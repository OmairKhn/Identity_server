#pragma checksum "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_UserCodeConfirmation), @"mvc.1.0.view", @"/Views/Device/UserCodeConfirmation.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\CODE\qStartIS\src\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a", @"/Views/Device/UserCodeConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70172ad1e11deb98c0fed2168cf30f9a40e06246251c96f3cd8e3b0a42d7f218", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Device_UserCodeConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeviceAuthorizationViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Description or name of device"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Callback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"page-device-confirmation\">\n    <div class=\"lead\">\n");
#nullable restore
#line 5 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
         if (Model.ClientLogoUrl != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"client-logo\"><img");
            BeginWriteAttribute("src", " src=\"", 192, "\"", 218, 1);
#nullable restore
#line 7 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 198, Model.ClientLogoUrl, 198, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\n");
#nullable restore
#line 8 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>\n            ");
#nullable restore
#line 10 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
       Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <small class=\"text-muted\">is requesting your permission</small>\n        </h1>\n");
#nullable restore
#line 13 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
         if (Model.ConfirmUserCode)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Please confirm that the authorization request quotes the code: <strong>");
#nullable restore
#line 15 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                                                                 Write(Model.UserCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.</p>\n");
#nullable restore
#line 16 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Uncheck the permissions you do not wish to grant.</p>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a8578", async() => {
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
            WriteLiteral("\n        </div>\n    </div>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a9750", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a10038", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 27 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                           WriteLiteral(Model.UserCode);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <div class=\"row\">\n            <div class=\"col-sm-8\">\n");
#nullable restore
#line 30 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <span class=""glyphicon glyphicon-user""></span>
                                Personal Information
                            </div>
                            <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 39 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                 foreach (var scope in Model.IdentityScopes)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a13505", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 41 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 42 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\n                        </div>\n                    </div>\n");
#nullable restore
#line 46 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
#nullable restore
#line 48 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.ApiScopes.Any())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <span class=""glyphicon glyphicon-tasks""></span>
                                Application Access
                            </div>
                            <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 57 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                 foreach (var scope in Model.ApiScopes)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a16669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 59 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 60 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\n                        </div>\n                    </div>\n");
#nullable restore
#line 64 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <div class=""form-group"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Description
                        </div>
                        <div class=""card-body"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a19218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 73 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("autofocus", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n\n");
#nullable restore
#line 78 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\n                        <div class=\"form-check\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a21701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 82 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f25e82999241badf66a00bd627ad0bae18c553dae5b01aa95284583087100a23331", async() => {
                    WriteLiteral("\n                                <strong>Remember My Decision</strong>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 83 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                    </div>\n");
#nullable restore
#line 88 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </div>

        <div class=""row"">
            <div class=""col-sm-4"">
                <button name=""button"" value=""yes"" class=""btn btn-primary"" autofocus>Yes, Allow</button>
                <button name=""button"" value=""no"" class=""btn btn-secondary"">No, Do Not Allow</button>
            </div>
            <div class=""col-sm-4 col-lg-auto"">
");
#nullable restore
#line 98 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.ClientUrl != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"btn btn-outline-info\"");
                BeginWriteAttribute("href", " href=\"", 4018, "\"", 4041, 1);
#nullable restore
#line 100 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 4025, Model.ClientUrl, 4025, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        <span class=\"glyphicon glyphicon-info-sign\"></span>\n                        <strong>");
#nullable restore
#line 102 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                           Write(Model.ClientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n                    </a>\n");
#nullable restore
#line 104 "D:\CODE\qStartIS\src\IdentityServer\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeviceAuthorizationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
