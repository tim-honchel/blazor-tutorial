#pragma checksum "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Components\Alert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0423a7d12a15aa6583511ef3941a1cbb222e965d"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlog.Shared.Components
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
    public partial class Alert : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Alert</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 3 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Components\Alert.razor"
              $"alert alert-{Style.ToString().ToLower()}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "role", "alert");
#nullable restore
#line 4 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Components\Alert.razor"
__builder.AddContent(4, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Components\Alert.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; } =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(5, "<b>This is a default value</b>");
        }
#nullable restore
#line 9 "C:\Users\thonchel\source\repos\MyBlog\MyBlog.Shared\Components\Alert.razor"
                                                                                     ;
    public enum AlertStyle
    {
        Primary,
        Secondary,
        Success,
        Danger,
        Warning,
        Info,
        Light,
        Dark
    }
    [Parameter]
    public AlertStyle Style { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591