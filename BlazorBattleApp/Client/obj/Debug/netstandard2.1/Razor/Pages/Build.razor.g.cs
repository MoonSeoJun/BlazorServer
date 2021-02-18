#pragma checksum "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bedbd8b0e8c391942696ee3c5f2a8f280e96851"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattleApp.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/build")]
    public partial class Build : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Build</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
                   selectedUnitId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedUnitId = __value, selectedUnitId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 9 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
         foreach (var unit in UnitService.Units)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 11 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
                            unit.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 11 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
                                      unit.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " || ");
            __builder.AddContent(14, 
#nullable restore
#line 11 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
                                                     unit.BananaCost

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " Bananas");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
                  BuildUnit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddContent(23, "Eat Bananas");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\BlazorServer\BlazorBattleApp\Client\Pages\Build.razor"
       
    int selectedUnitId = 1;

    public void BuildUnit()
    {
        BlazorBattleApp.Shared.Unit selectedUnit = 
            UnitService.Units.FirstOrDefault(unit => unit.Id == selectedUnitId);
        BananaService.EatBananas(selectedUnit.BananaCost);
        UnitService.AddUnit(selectedUnitId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattleApp.Client.Services.IUnitService UnitService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattleApp.Client.Services.IBananaService BananaService { get; set; }
    }
}
#pragma warning restore 1591
