#pragma checksum "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\Pages\ElementUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "802efa08036fca0110df2c57b3032919297eb8a9"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/elementupdate")]
    public partial class ElementUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Elemenet Update</h3>\r\n");
            __builder.AddMarkupContent(1, "<p>This pages demonstrates using a button to trigger a method that in turn updates an elements contents</p>\r\n<br>\r\n");
            __builder.OpenElement(2, "h5");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\Pages\ElementUpdate.razor"
     _time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\Pages\ElementUpdate.razor"
                                          SetTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Update Element");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\joshua\Desktop\Projects\Web\BlazorExperiments\BlazorExperiments\Client\Pages\ElementUpdate.razor"
       
    private DateTime _time = DateTime.Now;

    private void SetTime() 
    {
        _time = DateTime.Now;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
