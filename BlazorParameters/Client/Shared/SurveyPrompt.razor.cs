using Microsoft.AspNetCore.Components;

namespace BlazorParameters.Client.Shared
{
    public partial class SurveyPrompt
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
