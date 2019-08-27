using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPageLoadingOverlay.Data
{
    public class CounterService : ComponentBase
    {
        public int currentCount { get; set; }

        public bool wait { get; set; }

        public async Task Delay()
        {
            wait = false;
            await Task.Delay(2000);
            wait = true;
        }

        public async Task IncrementCount()
        {
            await Task.Delay(3000);
            currentCount++;
        }

        protected override async Task OnInitAsync()
        {
            wait = false;
            await Task.Delay(5000);
            wait = true;
        }
    }
}