using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;
using TwoWayBinding_Blazor.Data;

namespace TwoWayBinding_Blazor.Pages
{
    public partial class TwoWayBindingPartialClassMethod
    { 
        private EditContext editContext1;

        private CalcNumbers calcNumbers = new CalcNumbers();

        protected override void OnInitialized()
        {
            editContext1 = new EditContext(calcNumbers);
            editContext1.OnFieldChanged += HandleFieldChanged;

        }

        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            calcNumbers.Result = calcNumbers.Number1 + calcNumbers.Number2;
        }
        public void Dispose()
        {
            editContext1.OnFieldChanged -= HandleFieldChanged;
        }
    }
}
