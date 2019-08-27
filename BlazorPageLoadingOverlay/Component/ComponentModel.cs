using Microsoft.AspNetCore.Components;
using BlazorPageLoadingOverlay.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPageLoadingOverlay.Component
{
    public class ComponentModel : ComponentBase, ILoadableComponent
    {
        public ComponentLoadState LoadState { get; } = new ComponentLoadState();

        public string Status { get; private set; }

        public string Title => $"Component {Number}";

        [Parameter] protected int Delay { get; set; }

        [Parameter] protected LoadStateManager LoadStateManager { get; set; }

        [Parameter] protected int Number { get; set; }

        protected override async Task OnInitAsync()
        {
            // Simulate a web service call to get data
            await Task.Delay(Delay);

            Status = StringConstants.RandomText;

            // Ok - we're done loading. Notify the LoadStateManager!
            LoadState.OnLoadingComplete();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            // Register this component with the LoadStateManager
            LoadStateManager.Register(this);
        }
    }
}