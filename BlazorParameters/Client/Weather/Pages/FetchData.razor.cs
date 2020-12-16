using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorParameters.Shared;

namespace BlazorParameters.Client.Weather.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
