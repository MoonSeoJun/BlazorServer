#pragma checksum "D:\BlazorServer\BlazorBattleApp\Client\Shared\TopMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78047165f65da20fba991338122f94f6e02aa37"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattleApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using BlazorBattleApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using BlazorBattleApp.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-menu");
            __builder.AddMarkupContent(2, "\r\n    <img src=\"~/incons/I_C_Banana.png\">");
            __builder.AddContent(3, 
#nullable restore
#line 2 "D:\BlazorServer\BlazorBattleApp\Client\Shared\TopMenu.razor"
                                          Bananas

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\BlazorServer\BlazorBattleApp\Client\Shared\TopMenu.razor"
       
    public int Bananas { get; set; } = 100;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
