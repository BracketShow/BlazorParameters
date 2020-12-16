using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorParameters.Client.Counter.Components
{
    public partial class Counter
    {
        private int currentCount = 0;

        [Parameter] public int? CounterIncrement { get; set; }

        [Parameter] public int StartingCount { get; set; }

        protected override void OnInitialized()
        {
            currentCount = StartingCount;
        }

        private void IncrementCount()
        {
            currentCount += GetIncrementValue();
        }

        private int GetIncrementValue() => CounterIncrement ?? 1;
    }
}