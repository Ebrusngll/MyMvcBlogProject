#pragma checksum "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d71f0aa5c5309344dd9950d8a44b0434c137fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePageViewModel_Index), @"mvc.1.0.view", @"/Views/HomePageViewModel/Index.cshtml")]
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
#line 1 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\_ViewImports.cshtml"
using MyMvcBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\_ViewImports.cshtml"
using MyMvcBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d71f0aa5c5309344dd9950d8a44b0434c137fe", @"/Views/HomePageViewModel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd2ee932fa72514454ef5a27cf3c7ea7aecef7c", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePageViewModel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMvcBlog.ViewModels.HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomePage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<meta charset=\"utf-8\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12d71f0aa5c5309344dd9950d8a44b0434c137fe4782", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.6.1/css/all.css""
	  integrity=""sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"">

<title>Home Page</title>


<header>

	<div class=""jumbotron bg-dark text-white"">
		<div class=""container"">
			<div class=""col-md-6 px-0"">
				<h1 class=""display-4 font-italic"">
					Where Goog ideas<span> find you...</span>
				</h1>

				<p class=""lead my-3"">
					Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam non illum sequi velit vero
					excepturi facere tenetur perspiciatis necessitatibus recusandae.
				</p>
				<p class=""lead mb-0"">
					<a href=""#"" class=""text-white font-weight-bold"">Learn more  ...</a>

				</p>
				<br />
				<button type=""button"" class=""btn btn-success"">Get Started</button>
			</div>
		</div>
	</div>
</header>



<div class=""conta");
            WriteLiteral(@"iner"">

	<hr>
	<div class=""row"">
		<aside class=""col-md-6"">
			<p>Trending On medium</p>

			<div id=""carousel1_indicator"" class=""carousel slide"" data-ride=""carousel"">
				<ol class=""carousel-indicators"">
					<li data-target=""#carousel1_indicator"" data-slide-to=""0"" class=""active""></li>
					<li data-target=""#carousel1_indicator"" data-slide-to=""1""></li>
					<li data-target=""#carousel1_indicator"" data-slide-to=""2""></li>
				</ol>
				<div class=""carousel-inner"">
					<div class=""carousel-item active"">
						<img class=""d-block w-100"" src=""https://image.elitema.com.tr/db_images/186/CKEditor/image/Kedilerde%20Depresyon/Ekran%20Resmi%202020-03-24%2012_19_47.jpg"" alt=""First slide"">
					</div>
					<div class=""carousel-item"">
						<img class=""d-block w-100"" src=""https://image.elitema.com.tr/db_images/186/CKEditor/image/Kedilerde%20Depresyon/Ekran%20Resmi%202020-03-24%2012_19_47.jpg"" alt=""Second slide"">
					</div>
					<div class=""carousel-item"">
						<img class=""d-block w-100"" src=""https:/");
            WriteLiteral(@"/image.elitema.com.tr/db_images/186/CKEditor/image/Kedilerde%20Depresyon/Ekran%20Resmi%202020-03-24%2012_19_47.jpg"" alt=""Third slide"">
					</div>
				</div>
				<a class=""carousel-control-prev"" href=""#carousel1_indicator"" role=""button"" data-slide=""prev"">
					<span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
					<span class=""sr-only"">Previous</span>
				</a>
				<a class=""carousel-control-next"" href=""#carousel1_indicator"" role=""button"" data-slide=""next"">
					<span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
					<span class=""sr-only"">Next</span>
				</a>
			</div>

		</aside>


	</div>
</div>

<br />
<br />

<main>

	<div class=""container"">
		<div class=""row"">

			<div class=""col-md-8"">

");
#nullable restore
#line 93 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                 foreach (var article in Model.articles)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"card mb-4\">\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=", 3072, "", 3091, 1);
#nullable restore
#line 96 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
WriteAttributeValue("", 3077, article.Photo, 3077, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 3126, "\"", 3132, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t<h4 class=\"card-title\">");
#nullable restore
#line 98 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                                              Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t<p class=\"card-text\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 100 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                           Write(Html.Raw(article.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</p>\t\t\t\t\t\t\t\r\n\r\n");
            WriteLiteral("\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3392, "\"", 3428, 1);
#nullable restore
#line 104 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
WriteAttributeValue("", 3399, Url.Action("Index","Makale"), 3399, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link active\">\r\n\t\t\t\t\t\t\t\t<h4>Read More...</h4>\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"card-footer text-muted\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 109 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                       Write(article.DateOfWriting);

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>");
#nullable restore
#line 109 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                                                Write(article.ReadingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 110 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                       Write(article.ReadingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 114 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t\t<div class=\"card mb-4\">\r\n\t\t\t\t\t\t<div class=\"card-header\">\r\n\t\t\t\t\t\t\t<h5>Search</h5>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d71f0aa5c5309344dd9950d8a44b0434c137fe12385", async() => {
                WriteLiteral(@"
							<div class=""card-body"">
								<div class=""input-group"">
									<input type=""text"" class=""form-control"" placeholder=""Search for..."">
									<span class=""input-group-btn"">
										<button type=""submit"" class=""btn btn-success"">
											Go!
										</button>
									</span>
								</div>
							</div>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"card mb-4\">\r\n\t\t\t\t\t\t<div class=\"card-header\">\r\n\t\t\t\t\t\t\t<h5>Topic to follow</h5>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col\">\r\n");
#nullable restore
#line 143 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                                     foreach (var topic in Model.topics)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<ul class=\"list-unstyled\">\r\n\t\t\t\t\t\t\t\t\t\t\t<li><a href=\"#\">");
#nullable restore
#line 146 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
                                                       Write(topic.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t</ul>\r\n");
#nullable restore
#line 149 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 4625, "\"", 4660, 1);
#nullable restore
#line 153 "C:\Users\Ebrus\source\Workspaces\MyMvcBlog2\MyMvcBlog\Views\HomePageViewModel\Index.cshtml"
WriteAttributeValue("", 4632, Url.Action("Index","Topic"), 4632, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"> See All Topics</a>
						</div>
					</div>
				</div>
			</div>
		</div>


	</div>
</main>



<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js""></script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMvcBlog.ViewModels.HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
