// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorExperiments.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using BlazorExperiments.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\_Imports.razor"
using BlazorExperiments.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/oninitoverride")]
    public partial class OnInit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\Pages\OnInit.razor"
       
    public string testVal = "Initial value";

    protected override async Task OnInitializedAsync()
    {
        await Task.Run(() => { testVal = "Overridden value"; });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
