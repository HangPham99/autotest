#pragma checksum "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e03ae63f0260e95789e4793336be9ce1f097a6c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectdetail")]
    public partial class ProjectDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Project Detail</h3>\r\n<br>\r\n");
            __builder.OpenComponent<Blazorise.Button>(1);
            __builder.AddAttribute(2, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 8 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
               Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                                     ShowModal

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, " + Add Function");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Blazorise.Modal>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(9);
                __builder2.AddAttribute(10, "IsCentered", "true");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(12);
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalTitle>(14);
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(16, "Add Function");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(18);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(20);
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Field>(22);
                        __builder4.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.FieldLabel>(24);
                            __builder5.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(26, "Function Name");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(27, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.TextEdit>(28);
                            __builder5.AddAttribute(29, "Placeholder", "Enter name...");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n\r\n            ");
                        __builder4.OpenComponent<Blazorise.Field>(31);
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.FieldLabel>(33);
                            __builder5.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(35, "Discription");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.TextEdit>(37);
                            __builder5.AddAttribute(38, "Placeholder", "Enter discription...");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(40);
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(42);
                        __builder4.AddAttribute(43, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 28 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                           Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                                                      HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(46, "Close");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Button>(48);
                        __builder4.AddAttribute(49, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 29 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 29 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                                                    HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(52, "Save Changes");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(53, (__value) => {
#nullable restore
#line 10 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
             modalRef = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.OpenComponent<Blazorise.Table>(55);
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(59);
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(61);
                        __builder4.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(63, "Function name");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(64, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(65);
                        __builder4.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(67, "Milestones");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(68, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(69);
                        __builder4.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(71, "Date Modified");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(73);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.OpenComponent<Blazorise.TableBody>(75);
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 43 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
         foreach (var projectdetail in ListProjectDetail)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(77);
                    __builder3.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowCell>(79);
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(81, 
#nullable restore
#line 46 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                               projectdetail.FunctionName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(82, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(83);
                        __builder4.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(85, 
#nullable restore
#line 47 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                               projectdetail.Milestones

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(87);
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(89, 
#nullable restore
#line 48 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                               projectdetail.ModifiedDate

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(91);
                        __builder4.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(93, "button");
                            __builder5.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                                      NavigateToCounterComponent

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddContent(95, " Test ");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(96, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.Icon>(97);
                            __builder5.AddAttribute(98, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                                IconName.Edit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(99, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.Icon>(100);
                            __builder5.AddAttribute(101, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
                                IconName.Delete

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 55 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
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
#line 59 "D:\KhoaLuan\autotest\WebApp\BlazorApp1\Pages\ProjectDetail.razor"
       
    private List<BlazorApp1.Models.ProjectDetail> ListProjectDetail;

    protected override async Task OnInitializedAsync()
    {
        ListProjectDetail = ProjectDetailService.GetAllProject().ToList();
    }
    //modal
    private Modal modalRef;

    private void ShowModal()
    {
        modalRef.Show();
    }

    private void HideModal()
    {
        modalRef.Hide();
    }
    //link
    private void NavigateToCounterComponent() { NavigationManager.NavigateTo("functiontesting"); }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectDetailService ProjectDetailService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
