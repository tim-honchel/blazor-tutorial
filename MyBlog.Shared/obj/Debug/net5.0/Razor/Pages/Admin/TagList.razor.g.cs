#pragma checksum "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efb54ead4adecf25930e1be0e909471a8671f66d"
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
#line 4 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
using MyBlog.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
using MyBlog.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/tags")]
    public partial class TagList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TagList</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                         Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 9 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                                      Item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "CustomCssClassProvider");
                __builder2.AddAttribute(8, "ProviderType", "BootstrapFieldCssClassProvider");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 12 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                             Item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item.Name = __value, Item.Name))));
                __builder2.AddAttribute(13, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Item.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                global::__Blazor.MyBlog.Shared.Pages.Admin.TagList.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 13 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                              ()=>Item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.AddMarkupContent(18, "<button class=\"btn btn-success\" type=\"submit\"> Save </button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<global::MyBlog.Shared.Components.ItemList<Tag>>(20);
            __builder.AddAttribute(21, "Items", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<Tag>>(
#nullable restore
#line 17 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                 Items

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "DeleteEvent", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<Tag>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Tag>(this, 
#nullable restore
#line 17 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                                      Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "SelectEvent", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<Tag>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Tag>(this, 
#nullable restore
#line 17 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                                                           Select

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ItemTemplate", (global::Microsoft.AspNetCore.Components.RenderFragment<Tag>)((context) => (__builder2) => {
#nullable restore
#line 19 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
          
            var item = context as Tag;
            if (item != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
__builder2.AddContent(25, item.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
                          ;
            }
        

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\TagList.razor"
       
    private List<Tag> Items { get; set; } = new
List<Tag>();
    public Tag Item { get; set; } = new Tag();
    protected async override Task OnInitializedAsync()
    {
        Items = await api.GetTagsAsync();
        await base.OnInitializedAsync();
    }

    private async Task Delete(Tag tag)
    {
        try
        {
            await api.DeleteTagAsync(tag);
            Items.Remove(tag);
        }
        catch { }
    }

    private async Task Save()
    {
        try
        {
            if (Item.Id == 0)
            {
                Items.Add(Item);
            }
            await api.SaveTagAsync(Item);
            Item = new Tag();
        }
        catch { }
    }

    private Task Select(Tag tag)
    {
        try
        {
            Item = tag;
        }
        catch { }
        return Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMyBlogApi api { get; set; }
    }
}
namespace __Blazor.MyBlog.Shared.Pages.Admin.TagList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
