using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorParameters.Client.Shared
{
    public partial class ColorCascading
    {
        [Parameter] public Color tableBackgroundColor { get; set; }
        [Parameter] public Color buttonTextColor { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}