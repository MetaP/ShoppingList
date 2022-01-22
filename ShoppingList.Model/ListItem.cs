namespace MetaP.ShoppingList.Model
{
    public class ListItem
    {
        public ListItem() : this(string.Empty, false) { }

        public ListItem(string caption) : this (caption, false) { }

        public ListItem(string caption, bool checkedOff)
        {
            Caption = caption;
            CheckedOff = checkedOff;
        }

        public string Caption { get; set; }

        /// <summary>Indicates whether this item has been checked off the list or not.</summary>
        public bool CheckedOff { get; set; }
    }
}
