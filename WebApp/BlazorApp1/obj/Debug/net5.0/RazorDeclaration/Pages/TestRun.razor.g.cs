// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/functiontesting")]
    public partial class FunctionTesting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
       
    private List<BlazorApp1.Models.FunctionTesting> ListFunctionTesting;

    protected override async Task OnInitializedAsync()
    {
        ListFunctionTesting = FunctionTestingService.GetAllProject().ToList();
    }

    //file
    string fileContent;

    void OnWritten(FileWrittenEventArgs e)
    {
        Console.WriteLine($"File: {e.File.Name} Position: {e.Position} Data: {Convert.ToBase64String(e.Data)}");
    }

    void OnProgressed(FileProgressedEventArgs e)
    {
        Console.WriteLine($"File: {e.File.Name} Progress: {e.Percentage}");
    }
    //link
    private void NavigateToCounterComponent() { NavigationManager.NavigateTo("testscreen"); }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFunctionTesting FunctionTestingService { get; set; }
    }
}
#pragma warning restore 1591