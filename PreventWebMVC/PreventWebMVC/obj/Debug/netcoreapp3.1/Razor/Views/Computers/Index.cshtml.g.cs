#pragma checksum "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4068e93b1d57dd0caf7708fd113f45ec350922d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Computers_Index), @"mvc.1.0.view", @"/Views/Computers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Computers/Index.cshtml", typeof(AspNetCore.Views_Computers_Index))]
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
#line 1 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\_ViewImports.cshtml"
using PreventWebMVC;

#line default
#line hidden
#line 2 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\_ViewImports.cshtml"
using PreventWebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4068e93b1d57dd0caf7708fd113f45ec350922d5", @"/Views/Computers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5f5220a86200984f9b74b890441d93e0edb403", @"/Views/_ViewImports.cshtml")]
    public class Views_Computers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PreventWebMVC.Models.Computer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn myinfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
      
        ViewData["Title"] = PreventWebMVC.Services.ComputerService.GetPCCount();
    

#line default
#line hidden
            BeginContext(152, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(158, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4068e93b1d57dd0caf7708fd113f45ec350922d54884", async() => {
                BeginContext(164, 8, true);
                WriteLiteral("\r\n\r\n    ");
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
            BeginContext(179, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(185, 3998, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4068e93b1d57dd0caf7708fd113f45ec350922d56078", async() => {
                BeginContext(191, 217, true);
                WriteLiteral("\r\n        <div class=\"itemscentral-nomargin\">\r\n            <div class=\"index\">\r\n                <h2 style=\"text-align:center\" class=\"index\">\r\n                    Quantidade de Computadores\r\n                    <br /> ");
                EndContext();
                BeginContext(409, 17, false);
#line 16 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(426, 381, true);
                WriteLiteral(@"
                </h2>

            </div>
            <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Pesquisar"">

            <table class=""table table-striped table-hover table-condensed table-info"">
                <thead>
                    <tr class=""index"">

                        <th style=""text-align:center"">
                            ");
                EndContext();
                BeginContext(808, 40, false);
#line 27 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(848, 117, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"text-align:center\">\r\n                            ");
                EndContext();
                BeginContext(966, 38, false);
#line 30 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Ip));

#line default
#line hidden
                EndContext();
                BeginContext(1004, 142, true);
                WriteLiteral("\r\n                        </th>\r\n\r\n                        <th style=\"text-align:center\" class=\"hide-td-mobile\">\r\n                            ");
                EndContext();
                BeginContext(1147, 40, false);
#line 34 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
                EndContext();
                BeginContext(1187, 140, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"text-align:center\" class=\"hide-td-mobile\">\r\n                            ");
                EndContext();
                BeginContext(1328, 45, false);
#line 37 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Processor));

#line default
#line hidden
                EndContext();
                BeginContext(1373, 117, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"text-align:center\">\r\n                            ");
                EndContext();
                BeginContext(1491, 44, false);
#line 40 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.OpSystem));

#line default
#line hidden
                EndContext();
                BeginContext(1535, 140, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"text-align:center\" class=\"hide-td-mobile\">\r\n                            ");
                EndContext();
                BeginContext(1676, 42, false);
#line 43 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Domain));

#line default
#line hidden
                EndContext();
                BeginContext(1718, 117, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"text-align:center\">\r\n                            ");
                EndContext();
                BeginContext(1836, 39, false);
#line 46 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Tag));

#line default
#line hidden
                EndContext();
                BeginContext(1875, 194, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"text-align:center\">Ações</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"myTable\">\r\n\r\n\r\n");
                EndContext();
#line 54 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(2142, 134, true);
                WriteLiteral("                        <tr id=\"myUL\" style=\"text-align:center\">\r\n\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2277, 39, false);
#line 59 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2316, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2420, 37, false);
#line 62 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Ip));

#line default
#line hidden
                EndContext();
                BeginContext(2457, 128, true);
                WriteLiteral("\r\n                            </td>\r\n\r\n                            <td class=\"hide-td-mobile\">\r\n                                ");
                EndContext();
                BeginContext(2586, 39, false);
#line 66 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
                EndContext();
                BeginContext(2625, 126, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"hide-td-mobile\">\r\n                                ");
                EndContext();
                BeginContext(2752, 44, false);
#line 69 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Processor));

#line default
#line hidden
                EndContext();
                BeginContext(2796, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2900, 43, false);
#line 72 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OpSystem));

#line default
#line hidden
                EndContext();
                BeginContext(2943, 126, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td class=\"hide-td-mobile\">\r\n                                ");
                EndContext();
                BeginContext(3070, 41, false);
#line 75 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Domain));

#line default
#line hidden
                EndContext();
                BeginContext(3111, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(3215, 38, false);
#line 78 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Tag));

#line default
#line hidden
                EndContext();
                BeginContext(3253, 109, true);
                WriteLiteral("\r\n                            </td>\r\n\r\n\r\n                            <td>\r\n\r\n                                ");
                EndContext();
                BeginContext(3362, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4068e93b1d57dd0caf7708fd113f45ec350922d515331", async() => {
                    BeginContext(3429, 8, true);
                    WriteLiteral("Detalhes");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 84 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(3441, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3475, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4068e93b1d57dd0caf7708fd113f45ec350922d517943", async() => {
                    BeginContext(3541, 7, true);
                    WriteLiteral("Excluir");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 85 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(3552, 70, true);
                WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 89 "D:\rnunes\Desktop\PrevenT\PreventWebMVC\PreventWebMVC\Views\Computers\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3645, 531, true);
                WriteLiteral(@"                </tbody>



            </table>
            <script>

                $(document).ready(function () {
                    $(""#myInput"").on(""keyup"", function () {
                        var value = $(this).val().toLowerCase();
                        $(""#myTable tr"").filter(function () {
                            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                        });
                    });
                });

            </script>
        </div>    
");
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
            BeginContext(4183, 18, true);
            WriteLiteral("\r\n        \r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PreventWebMVC.Models.Computer>> Html { get; private set; }
    }
}
#pragma warning restore 1591