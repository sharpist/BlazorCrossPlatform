using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Pages
{
    public partial class Water : IDisposable
    {
        [Inject] public IJSRuntime        JSRuntime         { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // subscribe to the event
            NavigationManager.LocationChanged += LocationChanged;
            await base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("window.startWaterDemo", new object[] { "hi" });
            }
        }

        private void LocationChanged(object sender, LocationChangedEventArgs e)
        {
            // force a page reload when navigating away from the Water demo because it crashes on reload otherwise
            NavigationManager.NavigateTo(e.Location, forceLoad: true);
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= LocationChanged;
        }
    }
}
