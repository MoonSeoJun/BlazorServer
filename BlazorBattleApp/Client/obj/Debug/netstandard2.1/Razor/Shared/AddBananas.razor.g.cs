#pragma checksum "D:\BlazorServer\BlazorBattleApp\Client\Shared\AddBananas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2c3a5f85eb72c6b0b5e1063713b8d2f715ca7c3"
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
#nullable restore
#line 10 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\BlazorServer\BlazorBattleApp\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class AddBananas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\BlazorServer\BlazorBattleApp\Client\Shared\AddBananas.razor"
                  IncreaseBananaCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-info");
            __builder.AddContent(3, "+");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "D:\BlazorServer\BlazorBattleApp\Client\Shared\AddBananas.razor"
       

    public void IncreaseBananaCount()
    {
        BananaService.AddBananas(10);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattleApp.Client.Services.IBananaService BananaService { get; set; }
    }
}
#pragma warning restore 1591
