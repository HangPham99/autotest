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
#line 15 "D:\AutoTest\WebApp\BlazorApp1\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using BlazorApp1.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using Blazorise.RichTextEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using BlazorApp1.Commons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testscreen/{TestCaseFileId}")]
    public partial class TestScreen : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\AutoTest\WebApp\BlazorApp1\Pages\TestScreen.razor"
       
    private BlazorApp1.Models.FunctionTesting FunctionTesting;
    private List<TestCaseFileContent> FileContent;

    private HubConnection hubConnection;
    private string userInput;
    private string messageInput;
    private List<string> messages = new List<string>();

    private string _authMessage;
    private string _userId;
    private string _text;
    private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

    private RichTextEdit richTextEditRef;
    private bool readOnly;
    private string contentAsHtml;
    private string contentAsDeltaJson;
    private string contentAsText;
    private string savedContent;

    private bool IsDisableButton;

    [Parameter]
    public string TestCaseFileId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        FunctionTesting = await FunctionTestingService.FindById(Convert.ToInt32(TestCaseFileId));
        IsDisableButton = false;

        var result = await File.ReadAllLinesAsync(FunctionTesting.FilePath);
        this.FileContent = result.Skip(1)
                                 .Select(v => TestCaseFileContent.FromCsv(v))
                                 .ToList();

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
            if (message == "Automation test session is started.")
                this.IsDisableButton = true;

            if (message == "Automation test session is completed.")
                this.IsDisableButton = false;

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

    public async Task RunTestSession()
    {
        using var content = new MultipartFormDataContent();
        content.Add(
            content: new StringContent(_authMessage),
            name: "\"userid\""
        );
        content.Add(
            content: new StringContent(FunctionTesting.FilePath),
            name: "\"testcaseFilePath\""
        );

        var client = ClientFactory.CreateClient();

        var response = await client.PostAsync("https://localhost:5001/Filesave/runtest", content);
    }

    public async Task OnContentChanged()
    {
        contentAsHtml = await richTextEditRef.GetHtmlAsync();
        contentAsDeltaJson = await richTextEditRef.GetDeltaAsync();
        contentAsText = await richTextEditRef.GetTextAsync();
    }

    public async Task OnSave()
    {
        savedContent = await richTextEditRef.GetHtmlAsync();
        await richTextEditRef.ClearAsync();
    }

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFunctionTesting FunctionTestingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITestScreenService TestScreenService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment Environment { get; set; }
    }
}
#pragma warning restore 1591
