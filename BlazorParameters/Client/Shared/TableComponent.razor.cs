using System.Collections.Generic;
using System.Drawing;
using Microsoft.AspNetCore.Components;

namespace BlazorParameters.Client.Shared
{
    public partial class TableComponent<TItem>
    {
        [Parameter]
        public RenderFragment TableHeader { get; set; }

        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; }

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; }

        [CascadingParameter(Name = "TableBackgroundColor")]
        public Color TableBackgroundColor { get; set; }
    }
}