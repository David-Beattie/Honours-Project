// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
{
    #line hidden
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using honsProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Players")]
    public partial class Players : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\David\OneDrive\Desktop\Hons project\Project\Blazor\Pages\Players.razor"
       



       Player[] players;

       protected override async Task OnInitializedAsync()
     {
        await loadPlayers();

      }

       protected async Task loadPlayers()
       {
          players=await Http.GetFromJsonAsync<Player[]>("https://localhost:5001/Players");

       }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
