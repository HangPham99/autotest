#pragma checksum "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63542647dd9b39aa6a66da51b4fc15c3e683f986"
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
#line 2 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using BlazorApp1.Commons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/functiontesting")]
    public partial class FunctionTesting : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FunctionTesting</h3>\r\n<br>\r\n");
            __builder.OpenComponent<Blazorise.Button>(1);
            __builder.AddAttribute(2, "disabled", 
#nullable restore
#line 22 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 22 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                                          Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 22 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                                                                UploadFile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, "Import ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.OpenComponent<Blazorise.FileEdit>(9);
            __builder.AddAttribute(10, "Changed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazorise.FileChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazorise.FileChangedEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                        OnChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<Blazorise.Table>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.TableHeader>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.TableRow>(16);
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(18);
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(20, "File name");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(22);
                        __builder4.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(24, "Date Modified");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(26);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenComponent<Blazorise.TableBody>(28);
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 35 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
         foreach (var functionTesting in ListFunctionTesting)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.TableRow>(30);
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.TableRowCell>(32);
                        __builder4.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(34, 
#nullable restore
#line 38 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                               functionTesting.FileName

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(36);
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(38, 
#nullable restore
#line 39 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                               functionTesting.ModifiedDate

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(40);
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Icon>(42);
                            __builder5.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                                    NavigateToCounterComponent

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(44, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 42 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                                                                       IconName.ArrowRight

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(45, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.Icon>(46);
                            __builder5.AddAttribute(47, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 43 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                                IconName.Delete

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(48, "\r\n                    ");
                            __builder5.OpenComponent<Blazorise.Icon>(49);
                            __builder5.AddAttribute(50, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 44 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
                                IconName.Download

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
#line 46 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
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
            __builder.AddMarkupContent(51, "\r\n");
            __builder.AddMarkupContent(52, "<h4>Log</h4>\r\n");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "style", "height:500px; width:100%; overflow-y:scroll; border:solid; border-width:1px;border-color:darkgray");
#nullable restore
#line 51 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "p");
            __builder.AddContent(56, 
#nullable restore
#line 53 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
            message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\HangPham\Documents\autotest\WebApp\BlazorApp1\Pages\FunctionTesting.razor"
       
    private IFileEntry loadedFile = null;
    private List<BlazorApp1.Models.FunctionTesting> ListFunctionTesting;
    private bool isLoading;
    private List<UploadResult> uploadResults = new();

    private HubConnection hubConnection;
    private string userInput;
    private string messageInput;
    private List<string> messages = new List<string>();

    private string _authMessage;
    private string _userId;
    private string _text;
    private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();


    protected override async Task OnInitializedAsync()
    {
        ListFunctionTesting = FunctionTestingService.GetAllProject().ToList();

        hubConnection = new HubConnectionBuilder()
           .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
           .Build();

        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            _authMessage = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        }

        await hubConnection.StartAsync();
        await hubConnection.SendAsync("Subribe", _authMessage);

        hubConnection.On<string>("ReceiveMessage", (message) =>
        {
            messages.Add(message);
            try
            {
                StateHasChanged();
            }
            catch
            {

            }
        });

    }
    string message = "";

    private void OnChanged(FileChangedEventArgs e)
    {
        if (e.Files.Count() > 0)
        {
            loadedFile = e.Files[0];
        }
    }

    private async void UploadFile()
    {

        if (loadedFile != null)
        {
            using var content = new MultipartFormDataContent();

            using (var stream = new MemoryStream())
            {
                await loadedFile.WriteToStreamAsync(stream);
                stream.Seek(0, SeekOrigin.Begin);

                content.Add(
                   content: new StreamContent(stream),
                   name: "\"files\"",
                   fileName: loadedFile.Name);
                content.Add(
                    content: new StringContent(_authMessage),
                    name: "\"userid\""
                );

                var client = ClientFactory.CreateClient();

                var response =
                    await client.PostAsync("https://localhost:5001/Filesave",
                    content);

                if (response.IsSuccessStatusCode)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    };
                    using var responseStream =
                        await response.Content.ReadAsStreamAsync();

                    var newUploadResults = await JsonSerializer
                        .DeserializeAsync<IList<UploadResult>>(responseStream, options);

                    uploadResults = uploadResults.Concat(newUploadResults).ToList();
                }
            }
        }
    }
    //file
    string fileContent;

    //link
    private void NavigateToCounterComponent() { NavigationManager.NavigateTo("testscreen"); }

    public bool IsConnected =>
       hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFunctionTesting FunctionTestingService { get; set; }
    }
}
#pragma warning restore 1591
