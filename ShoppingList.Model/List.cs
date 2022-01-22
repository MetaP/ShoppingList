using System.Collections.Generic;

namespace MetaP.ShoppingList.Model
{
    public class List
    {
        public List() : this (string.Empty) { }

        public List(string title)
        {
            Title = title;
            _items = new List<ListItem>();
        }

        public string Title { get; set; }

        public IList<ListItem> Items => _items;

        /// <summary>Adds a new item with the specified caption.</summary>
        /// <param name="caption"></param>
        public void Add(string caption)
        {
            _items.Add(new ListItem(caption));
        }

        private IList<ListItem> _items;
    }
}
