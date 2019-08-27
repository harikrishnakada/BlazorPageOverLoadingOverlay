using BlazorPageLoadingOverlay.Helpers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPageLoadingOverlay.Data
{
    public class Index : ComponentBase
    {
        /// <summary>
        /// The <see cref="LoadStateManager" /> for this view
        /// </summary>
        /// <remarks>
        /// Since this is the parent view that contains the loading overlay, we new up an instance of the <see
        /// cref="LoadStateManager" /> here, and pass it to child components.
        /// </remarks>
        public LoadStateManager LoadStateManager { get; } = new LoadStateManager();
    }
}