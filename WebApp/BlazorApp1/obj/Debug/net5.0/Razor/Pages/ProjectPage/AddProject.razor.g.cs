#pragma checksum "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c8f78c665c7927e32384bde86e52e82656cb81c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.ProjectPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
    public partial class AddProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "simple-form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "<label for=\"movie-name\">Project Name</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "project-name");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
                       NewProject.ProjectName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProject.ProjectName = __value, NewProject.ProjectName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddMarkupContent(14, "<label for=\"year\">Link</label>\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "id", "project-link");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
                       NewProject.Link

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProject.Link = __value, NewProject.Link));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
                      SaveProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddContent(25, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-secondary");
            __builder.AddContent(30, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Hikari\Documents\autotest\WebApp\BlazorApp1\Pages\ProjectPage\AddProject.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

    private BlazorApp1.Models.Project NewProject { get; set; }

    protected override void OnInitialized()
    {
        NewProject = new Project();
    }

    async void SaveProject()
    {
        NewProject.CreateDate = DateTime.UtcNow;
        NewProject.ModifiedDate = DateTime.UtcNow;
        try
        {
            await _service.AddProject(NewProject);
            await ModalInstance.CloseAsync(ModalResult.Ok<Project>(NewProject));
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService _service { get; set; }
    }
}
#pragma warning restore 1591
