using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Components
{
    public partial class ListItemView
    {
        [Parameter]
        public ListItem ListItem { get; set; } = new ListItem();

        /// <summary>Event triggered when dragging the linked list item starts.</summary>
        [Parameter]
        public EventCallback<ListItem> OnDragItemStart { get; set; }

        private void ToggleCheckOff()
        {
            ListItem.CheckedOff = !ListItem.CheckedOff;
        }

        private async Task HandleDragEnter(DragEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("HandleDragEnter()");

            /* Setting the "content" of an HTML drag doesn't work currently. */
            //args.DataTransfer.Items = new DataTransferItem[] {
            //    new DataTransferItem()
            //    {
            //        Type ="text/plain",
            //        Kind = ListItem.Caption
            //    }
            //};

            // Raise the OnDragItemStart event.
            await OnDragItemStart.InvokeAsync(ListItem);
        }
    }
}
