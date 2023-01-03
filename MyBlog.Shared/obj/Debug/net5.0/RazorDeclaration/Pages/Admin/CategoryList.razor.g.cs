// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\CategoryList.razor"
using MyBlog.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\CategoryList.razor"
using MyBlog.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\CategoryList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/categories")]
    public partial class CategoryList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Pages\Admin\CategoryList.razor"
       
    private List<Category> Items { get; set; } = new List<Category>();
    public Category Item { get; set; } = new Category();

    protected async override Task OnInitializedAsync()
    {
        Items = await api.GetCategoriesAsync();
        await base.OnInitializedAsync();
    }

    private async Task Delete(Category category)
    {
        try
        {
            await api.DeleteCategoryAsync(category);
            Items.Remove(category);
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
            await api.SaveCategoryAsync(Item);
            Item = new Category();
        }
        catch { }
    }

    private Task Select(Category category)
    {
        try
        {
            Item = category;
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
#pragma warning restore 1591
