using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;

namespace MetaP.ShoppingList.Components
{
    public partial class ListItemView
    {
        [Parameter]
        public ListItem ListItem { get; set; } = new ListItem();

        private void ToggleCheckOff()
        {
            ListItem.CheckedOff = !ListItem.CheckedOff;
        }
    }
}
