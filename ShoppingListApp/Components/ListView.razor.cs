using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MetaP.ShoppingList.Components
{
    public partial class ListView
    {
        [Parameter]
        public List List { get; set; } = new List();

        private ListItem EditedItem { get; set; } = new ListItem();

        /// <summary>The item that is currently being dragged.</summary>
        /// <remarks>This is necessary because Blazor currently doesn't allow to associate data with the drag operation via 
        /// the DragEventArgs's DataTransfer property.</remarks>
        private ListItem? DraggedItem { get; set; }

        private void Edit(ListItem item)
        {
            EditedItem = item;
        }

        private void Remove(ListItem item)
        {
            // ToDo: Ask for confirmation.
            List.Remove(item);
        }

        private void OnKeyUp_EditCaption(KeyboardEventArgs args)
        {
            /*
             * Use onkeyup (not onkeydown or on keypressed) because otherwise the bound value is not yet updated.
             * The update of the bound value happens (by default) when the HTML onchange event fires.
             * (See https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/onchange )
             */

            if (args.Key == "Enter")
            {
                EndEditCaption();
            }
        }

        private void EndEditCaption()
        {
            ListItem item = EditedItem;
            if (!string.IsNullOrWhiteSpace(item.Caption))
            {
                if (item.List != List) List.Add(item);
                EditedItem = new ListItem();
            }
        }

        private void HandleOnDragItemStart(ListItem listItem)
        {
            DraggedItem = listItem;
        }

        /************************************************************************************************************************
         * IMPORTANT
         * =========
         * To allow a drop, the standard behavior of both the dragenter and dragover events must be prevented.
         * (See https://developer.mozilla.org/en-US/docs/Web/API/HTML_Drag_and_Drop_API/Drag_operations#specifying_drop_targets)
         ************************************************************************************************************************/

        private void HandleDropOnEdit(DragEventArgs args)
        {
            ListItem? draggedItem = DraggedItem;
            if (draggedItem != null)
            {
                DraggedItem = null;
                Edit(draggedItem);
            }
        }

        private void HandleDropOnDelete(DragEventArgs args)
        {
            ListItem? draggedItem = DraggedItem;
            if (draggedItem != null)
            {
                DraggedItem = null;
                Remove(draggedItem);
            }
        }
    }
}
