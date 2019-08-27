using System.Threading.Tasks;
using BlazorPageLoadingOverlay.Helpers;
using Microsoft.AspNetCore.Components;

namespace BlazorPageLoadingOverlay.LoadingOverlay
{
    /// <summary>
    /// Model class for <see cref="LoadingOverlayView" />
    /// </summary>
    public class LoadingOverlayModel : ComponentBase
    {
        /// <summary>
        /// The <see cref="LoadStateManager" /> for this <see cref="LoadingOverlayModel" />
        /// </summary>
        [Parameter] public static LoadStateManager LoadStateManager => new LoadStateManager() { IsLoadingComplete = true };

        protected override async Task OnInitAsync()
        {
            // When LoadStateManager indicates that all components are loaded, notify this component of the state change
            LoadStateManager.LoadingComplete += (sender, args) => StateHasChanged();

            await Task.CompletedTask;
        }
    }
}