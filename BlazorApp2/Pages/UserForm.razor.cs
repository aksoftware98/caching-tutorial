using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorApp2;
using BlazorApp2.Shared;
using BlazorComponentUtilities;

namespace BlazorApp2.Pages
{
    public partial class UserForm
    {

        private string _inputStyle => new StyleBuilder()
                                            .AddStyle("width", "100%")
                                            .AddStyle("height", "40px")
                                            .AddStyle("padding", "4px")
                                            .AddStyle("border", "1px dashed gray")
                                            .AddStyle("border-radius", "6px")
                                            .Build();

    }
}