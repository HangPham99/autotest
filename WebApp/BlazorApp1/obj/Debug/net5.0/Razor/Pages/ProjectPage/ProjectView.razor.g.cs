#pragma checksum "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d0eaa9e350e3dc66720d2cb0c6b316a2748226"
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
#line 3 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public partial class ProjectView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Project</h3>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<Blazorise.Button>(1);
            __builder.AddAttribute(2, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 10 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
               Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                    CreateProject

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, " + Add Project");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<Blazorise.Table>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(13);
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(15, "Id");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(16, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(17);
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(19, "Project name");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(21);
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(23, "Link");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(25);
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(27, "Created Date");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(29);
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, "Modified Date");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(33);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenComponent<Blazorise.TableBody>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 25 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
         if (ListProject != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
             foreach (var project in ListProject)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(37);
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowCell>(39);
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(41, 
#nullable restore
#line 30 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                   project.Id

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(43);
                        __builder4.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(45, 
#nullable restore
#line 31 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                   project.ProjectName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(47);
                        __builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(49, 
#nullable restore
#line 32 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                   project.Link

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(51);
                        __builder4.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(53, 
#nullable restore
#line 33 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                   project.CreateDate

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(55);
                        __builder4.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(57, 
#nullable restore
#line 34 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                   project.ModifiedDate

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(59);
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Button>(61);
                            __builder5.AddAttribute(62, "class", "btn");
                            __builder5.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                                      () => UpdateProject(project)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(65, "<i class=\"fas fa-edit\"></i> Edit");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(66, "\r\n                        ");
                            __builder5.OpenComponent<Blazorise.Button>(67);
                            __builder5.AddAttribute(68, "class", "btn");
                            __builder5.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
                                                      () => Delete_Click(project)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(71, "<i class=\"fas fa-trash\"></i> Delete");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 40 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
             
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectPage\ProjectView.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    private IEnumerable<BlazorApp1.Models.Project> ListProject;


    protected override async Task OnInitializedAsync()
    {
        ListProject = await ProjectService.GetAllProject();
    }

    private async void CreateProject()
    {
        var add = Modal.Show<AddProject>("Add new project");
        var result = await add.Result;
        ListProject = await ProjectService.GetAllProject();
        StateHasChanged();
    }

    private async void UpdateProject(BlazorApp1.Models.Project project)
    {
        var parameters = new ModalParameters();
        parameters.Add("project", project);
        var update = Modal.Show<EditProject>("Edit project", parameters);
        var result = await update.Result;
        ListProject = await ProjectService.GetAllProject();
        StateHasChanged();
    }

    protected async void Delete_Click(BlazorApp1.Models.Project project)
    {
        var parameters = new ModalParameters();
        parameters.Add("project", project);
        var update = Modal.Show<DeleteProject>("Delete confirmation", parameters);
        var result = await update.Result;
        ListProject = await ProjectService.GetAllProject();
        StateHasChanged();
    }

    private void NavigateToCounterComponent() { NavigationManager.NavigateTo("functiontesting"); }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService ProjectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
