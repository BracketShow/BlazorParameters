using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorParameters.Client.Counter.Pages
{
    public partial class CounterPage
    {
        [Parameter]
        public int? StartingCount { get; set; }

        protected override void OnInitialized()
        {
            StartingCount ??= 0;
        }
    }
}
