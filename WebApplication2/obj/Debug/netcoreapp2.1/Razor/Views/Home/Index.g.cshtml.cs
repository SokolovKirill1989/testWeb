#pragma checksum "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385851f7286b5f679307d6b549ace6803f221350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
#line 3 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 1 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"385851f7286b5f679307d6b549ace6803f221350", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CursModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(130, 41, true);
            WriteLiteral("\r\n\r\n\r\n<!doctype html>\r\n<html lang=\"ru\">\r\n");
            EndContext();
            BeginContext(171, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ae61aa8d8b412dbf258acd6693bcda", async() => {
                BeginContext(177, 110, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>\"Курс ЦБ\"</title>\r\n    <link rel=\"stylesheet\" href=\"style.css\" />\r\n");
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
            BeginContext(294, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(296, 3304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "136be9f682ad444f8ef294549717a32b", async() => {
                BeginContext(302, 41, true);
                WriteLiteral("\r\n\r\n    <p id=\"qrCode\"></p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                EndContext();
#line 24 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(413, 33, true);
                WriteLiteral("        <SELECT NAME=\"Valutes\">\r\n");
                EndContext();
#line 27 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
              
                try
                {
                    VALUTES vals = ViewBag.Valutes;/*Model.GetValutes()*/;
                    foreach (Val val in vals)
                    {
                        if (@val.Vname.Contains("Евро"))
                        {

#line default
#line hidden
                BeginContext(733, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(761, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5173b089dd184734a2807a2ff1c0b909", async() => {
                    BeginContext(795, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(830, 9, false);
#line 36 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                           Write(val.Vname);

#line default
#line hidden
                    EndContext();
                    BeginContext(839, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 35 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                              WriteLiteral(val.Vcode);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(878, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(964, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(992, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e87b1e847264175a824b72ec47dd781", async() => {
                    BeginContext(1017, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(1052, 9, false);
#line 42 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                           Write(val.Vname);

#line default
#line hidden
                    EndContext();
                    BeginContext(1061, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 41 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                              WriteLiteral(val.Vcode);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1100, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"

                        }
                    }
                }
                catch (Exception ex)
                {

#line default
#line hidden
                BeginContext(1230, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1250, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("OPTION", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ba578e8faf3424893e77cef2e363fcb", async() => {
                    BeginContext(1277, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(1304, 2, false);
#line 51 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                   Write(ex);

#line default
#line hidden
                    EndContext();
                    BeginContext(1306, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 50 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                      WriteLiteral(ex);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("VALUE", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1337, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                }

            

#line default
#line hidden
                BeginContext(1375, 21, true);
                WriteLiteral("\r\n        </SELECT>\r\n");
                EndContext();
                BeginContext(1398, 238, true);
                WriteLiteral("        <input type=\"date\" name=\"StartDate\" />\r\n        <input type=\"date\" name=\"EndDate\" />\r\n        <button name=\"action\" value=\"GetCurCurs\">Текущий курс</button>\r\n        <button name=\"action\" value=\"GetDynamicCurs\">Динамика</button>\r\n");
                EndContext();
                BeginContext(1638, 44, true);
                WriteLiteral("        <p>\r\n            <table id=\"data\">\r\n");
                EndContext();
#line 66 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                  
                    try
                    {
                        bool isCur = (bool)ViewBag.Act;
                        if (isCur)
                        {
                            CURSES curs = ViewBag.CurCurs;/*Model.GetValutes()*/;
                            foreach (CURS c in curs)
                            {


#line default
#line hidden
                BeginContext(2040, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2161, 7, false);
#line 78 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                   Write(c.Vname);

#line default
#line hidden
                EndContext();
                BeginContext(2168, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2296, 9, false);
#line 81 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                   Write(c.VchCode);

#line default
#line hidden
                EndContext();
                BeginContext(2305, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2433, 7, false);
#line 84 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                   Write(c.Vcurs);

#line default
#line hidden
                EndContext();
                BeginContext(2440, 84, true);
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 87 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                            }
                        }
                        else
                        {
                            DCURSES curs = ViewBag.DynCurs;/*Model.GetValutes()*/;
                            foreach (DCURS c in curs)
                            {


#line default
#line hidden
                BeginContext(2811, 120, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2932, 10, false);
#line 97 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                   Write(c.CursDate);

#line default
#line hidden
                EndContext();
                BeginContext(2942, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3070, 7, false);
#line 100 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                   Write(c.Vcode);

#line default
#line hidden
                EndContext();
                BeginContext(3077, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3205, 7, false);
#line 103 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                   Write(c.Vcurs);

#line default
#line hidden
                EndContext();
                BeginContext(3212, 84, true);
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 106 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        

#line default
#line hidden
                BeginContext(3471, 2, false);
#line 113 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                   Write(ex);

#line default
#line hidden
                EndContext();
#line 113 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                           
                    }

                

#line default
#line hidden
                BeginContext(3519, 38, true);
                WriteLiteral("\r\n            </table>\r\n        </p>\r\n");
                EndContext();
#line 120 "C:\Users\admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"

    }

#line default
#line hidden
                BeginContext(3566, 27, true);
                WriteLiteral("    <div>\r\n\r\n\r\n    </div>\r\n");
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
            BeginContext(3600, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CursModel> Html { get; private set; }
    }
}
#pragma warning restore 1591