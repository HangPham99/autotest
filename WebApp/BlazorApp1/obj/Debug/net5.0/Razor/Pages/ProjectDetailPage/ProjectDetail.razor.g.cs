#pragma checksum "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f264b2ddadd53e554c8a210effaa5dba2fdb2ab"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.ProjectDetailPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectdetail/{ProjectId:int}")]
    public partial class ProjectDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
 if (Project != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 9 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
         Project.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " - Project detail");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<Blazorise.Button>(4);
            __builder.AddAttribute(5, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 11 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                   Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 11 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                        CreateFunction

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, " + Add Function");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenComponent<Blazorise.Table>(10);
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(16);
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(18, "Id");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(19, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(20);
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(22, "Function name");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(24);
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, "Milestones");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(28);
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(30, "Created Date");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(32);
                        __builder4.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(34, "Modified Date");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(36);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<Blazorise.TableBody>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 26 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
             if (ListFunction != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                 foreach (var function in ListFunction)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(40);
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowCell>(42);
                        __builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(44, 
#nullable restore
#line 31 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                       function.Id

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(46);
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(48, 
#nullable restore
#line 32 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                       function.FunctionName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(50);
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(52, 
#nullable restore
#line 33 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                       function.Milestones

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(54);
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(56, 
#nullable restore
#line 34 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                       function.CreateDate

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(58);
                        __builder4.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(60, 
#nullable restore
#line 35 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                       function.ModifiedDate

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                        ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(62);
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Button>(64);
                            __builder5.AddAttribute(65, "class", "btn");
                            __builder5.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                                          () => UpdateFunction(function)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(68, "<i class=\"fas fa-edit\"></i> Edit");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                            ");
                            __builder5.OpenComponent<Blazorise.Button>(70);
                            __builder5.AddAttribute(71, "class", "btn");
                            __builder5.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                                                          () => Delete_Click(function)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(74, "<i class=\"fas fa-trash\"></i> Delete");
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
#line 41 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
                 
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
#nullable restore
#line 46 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\AutoTest\WebApp\BlazorApp1\Pages\ProjectDetailPage\ProjectDetail.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    private IEnumerable<BlazorApp1.Models.ProjectDetail> ListFunction;

    [Parameter]
    public int ProjectId { get; set; }
    private BlazorApp1.Models.Project Project { get; set; }


    protected override async Task OnInitializedAsync()
    {
        Project = await ProjectService.GetProjectById(ProjectId);

        if (Project != null)
        {
            ListFunction = await ProjectDetailService.GetAllFunctionByProjectId(Project.Id);
        }
    }

    private async void CreateFunction()
    {
        var parameters = new ModalParameters();
        parameters.Add("ProjectId", ProjectId);
        var add = Modal.Show<AddFunction>("Add new function", parameters);
        var result = await add.Result;
        ListFunction = await ProjectDetailService.GetAllProject();
        StateHasChanged();
    }

    private async void UpdateFunction(BlazorApp1.Models.ProjectDetail function)
    {
        var parameters = new ModalParameters();
        parameters.Add("function", function);
        var update = Modal.Show<EditFunction>("Edit function", parameters);
        var result = await update.Result;
        ListFunction = await ProjectDetailService.GetAllProject();
        StateHasChanged();
    }

    protected async void Delete_Click(BlazorApp1.Models.ProjectDetail function)
    {
        var parameters = new ModalParameters();
        parameters.Add("project", function);
        var update = Modal.Show<DeleteFunction>("Delete confirmation", parameters);
        var result = await update.Result;
        ListFunction = await ProjectDetailService.GetAllProject();
        StateHasChanged();
    }

    //link
    private void NavigateToCounterComponent() { NavigationManager.NavigateTo("functiontesting"); }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService ProjectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectDetailService ProjectDetailService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
