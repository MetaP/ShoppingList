using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;

namespace MetaP.ShoppingList.Components
{
    public partial class ListView
    {
        [Parameter]
        public List List { get; set; } = new List();

        private string NewCaption { get; set; } = string.Empty;

        private void OnKeyUp_NewCaption(KeyboardEventArgs args)
        {
            /*
             * Use onkeyup (not onkeydown or on keypressed) because otherwise the bound value is not yet updated.
             * The update of the bound value happens (by default) when the HTML onchange event fires.
             * (See https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onchange )
             */

            if (args.Key == "Enter")
            {
                ProcessNewCaption();
            }
        }

        private void ProcessNewCaption()
        {
            string caption = NewCaption;
            NewCaption = string.Empty;

            if (!string.IsNullOrWhiteSpace(caption)) List?.Add(caption);
        }
    }
}
