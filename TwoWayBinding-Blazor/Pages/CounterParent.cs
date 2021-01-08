using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoWayBinding_Blazor.Pages
{
    public partial class CounterParent
    {
        [Parameter]
        public string CounterStart { get; set; }

        private int currentCount = 10;

        protected override void OnInitialized()
        {
            if (!string.IsNullOrEmpty(CounterStart))
            {
                currentCount = Convert.ToInt32(CounterStart);
            }
        }

        private void UpdateCounter(int countValue)
        {
            currentCount = countValue;
        }
    }
}