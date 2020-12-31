using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoWayBinding_Blazor.Data;

namespace TwoWayBinding_Blazor.Pages
{
    public class TwoWayBindingBaseMethodBase:ComponentBase
    {
        protected EditContext editContext;
        
        protected CalcNumbers calcNumbers = new CalcNumbers();

        protected override void OnInitialized()
        {
            editContext = new EditContext(calcNumbers);
            editContext.OnFieldChanged += HandleFieldChanged;

        }

        private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
        {
            calcNumbers.Result = calcNumbers.Number1 + calcNumbers.Number2;
        }



        }
}
