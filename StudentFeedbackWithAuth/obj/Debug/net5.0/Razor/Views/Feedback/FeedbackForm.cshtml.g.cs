#pragma checksum "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9825e0feec18d92658b1ef25c8df2c17df5ad26a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_FeedbackForm), @"mvc.1.0.view", @"/Views/Feedback/FeedbackForm.cshtml")]
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
#line 1 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/_ViewImports.cshtml"
using StudentFeedbackWithAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/_ViewImports.cshtml"
using StudentFeedbackWithAuth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9825e0feec18d92658b1ef25c8df2c17df5ad26a", @"/Views/Feedback/FeedbackForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6057313dd93f95b67b48488709c69ca55be0770a", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_FeedbackForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentFeedbackWithAuth.Models.FeedbackQuestion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
  
    ViewData["Title"] = "Feedback Form";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Feedback Form</h1>\n\n");
            WriteLiteral("<table class=\"table\">\n");
            WriteLiteral("    <tbody>\n");
#nullable restore
#line 25 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
         foreach (var item in Model)
        {
            if (item.ResponseType == "rating")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        <div class=\"form-group\">\n                            <label");
            BeginWriteAttribute("for", " for=\"", 745, "\"", 777, 2);
            WriteAttributeValue("", 751, "feedBackQuestions+", 751, 18, true);
#nullable restore
#line 32 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
WriteAttributeValue("", 769, item.Id, 769, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 32 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</span> ");
#nullable restore
#line 32 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                            <input type=\"range\" class=\"form-control-range\" min=\"1\" max=\"5\"");
            BeginWriteAttribute("id", " id=\"", 945, "\"", 950, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        </div>\n                    </td>\n                </tr>\n");
#nullable restore
#line 37 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        <div class=\"form-group\">\n                            <label");
            BeginWriteAttribute("for", " for=\"", 1206, "\"", 1238, 2);
            WriteAttributeValue("", 1212, "feedBackQuestions+", 1212, 18, true);
#nullable restore
#line 43 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
WriteAttributeValue("", 1230, item.Id, 1230, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 43 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</span> ");
#nullable restore
#line 43 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                            <textarea class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 1374, "\"", 1379, 0);
            EndWriteAttribute();
            WriteLiteral(" rows=\"3\"></textarea>\n                        </div>\n                    </td>\n                </tr>\n");
#nullable restore
#line 48 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
            }
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/kazimhomayee/Documents/FH Kiel/Web Application .Net/StudentFeedbackWithAuth/StudentFeedbackWithAuth/Views/Feedback/FeedbackForm.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentFeedbackWithAuth.Models.FeedbackQuestion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
