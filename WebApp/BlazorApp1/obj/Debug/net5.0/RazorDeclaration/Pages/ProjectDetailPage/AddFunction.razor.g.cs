// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.ProjectDetailPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\AddFunction.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\AddFunction.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
    public partial class AddFunction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Gia Nhung\Documents\GitHub\autotest\WebApp\BlazorApp1\Pages\ProjectDetailPage\AddFunction.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public int ProjectId { get; set; }

    private BlazorApp1.Models.ProjectDetail NewFunction { get; set; }

    protected override void OnInitialized()
    {
        NewFunction = new BlazorApp1.Models.ProjectDetail();
    }

    async void SaveFunction()
    {
        NewFunction.CreateDate = DateTime.UtcNow;
        NewFunction.ModifiedDate = DateTime.UtcNow;
        NewFunction.ProjectId = ProjectId;
        try
        {
            await _service.AddFunction(NewFunction);
            await ModalInstance.CloseAsync(ModalResult.Ok<BlazorApp1.Models.ProjectDetail>(NewFunction));
        }
        catch
        {
            await JsRuntime.InvokeVoidAsync("Error", "Something when wrong");
        }

    }

    async void Cancel()
    {
        await ModalInstance.CancelAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectDetailService _service { get; set; }
    }
}
#pragma warning restore 1591
