#pragma checksum "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7d592a1e52c120a1802059ede86509333df80f"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlog.Shared.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using MyBlog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\_Imports.razor"
using MyBlog.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
using MyBlog.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
using MyBlog.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
using Markdig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/blogposts/new")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/blogposts/{Id:int}")]
    public partial class BlogPostEdit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 10 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                 Post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                                      SavePost

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "CustomCssClassProvider");
                __builder2.AddAttribute(7, "ProviderType", "BootstrapFieldCssClassProvider");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                            Post.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Post.Title = __value, Post.Title))));
                __builder2.AddAttribute(12, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Post.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                global::__Blazor.MyBlog.Shared.Pages.Admin.BlogPostEdit.TypeInference.CreateInputDate_0(__builder2, 14, 15, 
#nullable restore
#line 14 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                            Post.PublishDate

#line default
#line hidden
#nullable disable
                , 16, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Post.PublishDate = __value, Post.PublishDate)), 17, () => Post.PublishDate);
                __builder2.AddMarkupContent(18, "\r\n    ");
                global::__Blazor.MyBlog.Shared.Pages.Admin.BlogPostEdit.TypeInference.CreateInputSelect_1(__builder2, 19, 20, 
#nullable restore
#line 15 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                              selectedCategory

#line default
#line hidden
#nullable disable
                , 21, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedCategory = __value, selectedCategory)), 22, () => selectedCategory, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "<option value=\"0\" disabled>None selected</option>");
#nullable restore
#line 17 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
         foreach (var category in Categories)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 19 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                            category.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 19 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
__builder3.AddContent(27, category.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 20 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "ul");
#nullable restore
#line 23 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
         foreach (var tag in Tags)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "li");
#nullable restore
#line 26 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
__builder2.AddContent(31, tag.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                 if (Post.Tags.Any(t => t.Id == tag.Id))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "type", "button");
                __builder2.AddAttribute(34, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                                                      () => {Post.Tags.Remove(Post.Tags.Single(t=>t.Id==tag.Id)); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, "Remove");
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "type", "button");
                __builder2.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                                                      ()=> { Post.Tags.Add(tag); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(39, "Add");
                __builder2.CloseElement();
#nullable restore
#line 34 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(41);
                __builder2.AddAttribute(42, "onkeyup", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                                                    UpdateHTML

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 38 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
                                Post.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Post.Text = __value, Post.Text))));
                __builder2.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Post.Text));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.AddMarkupContent(47, "<button type=\"submit\" class=\"btn btn-success\">Save</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n\r\n");
#nullable restore
#line 42 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
__builder.AddContent(49, (MarkupString)markDownAsHTML);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\BlogPostEdit.razor"
       
    public async Task SavePost()
    {
        if (selectedCategory != 0 && Categories != null)
        {
            var category = Categories.FirstOrDefault(c =>
            c.Id == selectedCategory);
            if (category != null)
            {
                Post.Category = category;
            }
        }
        await api.SaveBlogPostAsync(Post);
        manager.NavigateTo("/admin/blogposts");
    }

    [Parameter]
    public int? Id { get; set; }

    BlogPost Post { get; set; } = new BlogPost();
    List<Category>? Categories { get; set; }
    List<Tag>? Tags { get; set; }
    int selectedCategory = 0;
    string? markDownAsHTML { get; set; }

    MarkdownPipeline pipeline;

    protected override Task OnInitializedAsync()
    {
        pipeline = new MarkdownPipelineBuilder().UseEmojiAndSmiley().Build();
        return base.OnInitializedAsync();
    }

    protected void UpdateHTML()
    {
        markDownAsHTML =Markdig.Markdown.ToHtml(Post.Text, pipeline);
    }
    bool hasTag(MyBlog.Data.Models.Tag tag)
    {
        return Post.Tags.Contains(tag);
    }
    protected override async Task OnParametersSetAsync()
    {
        if (Id != null)
        {
            Post = await api.GetBlogPostAsync(Id.Value);
            if (Post.Category != null)
            {
                selectedCategory = Post.Category.Id;
            }
            UpdateHTML();
        }
        Categories = await api.GetCategoriesAsync();
        Tags = await api.GetTagsAsync();
        base.OnParametersSet();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager manager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMyBlogApi api { get; set; }
    }
}
namespace __Blazor.MyBlog.Shared.Pages.Admin.BlogPostEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591