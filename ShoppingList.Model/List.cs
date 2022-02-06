using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MetaP.ShoppingList.Model
{
    public class List
    {
        public List() : this (string.Empty) { }

        public List(string title) : this(title, Array.Empty<ListItem>()) { }

        [JsonConstructor] /* Parameter types must be exactly the same as those of the serialized properties! */
        public List(string title, IEnumerable<ListItem> items)
        {
            Title = title;

            // "Bind" all items to this List.
            foreach (ListItem item in items) item.List = this;

            _items = new List<ListItem>(items);
        }

        public string Title { get; set; }

        public IEnumerable<ListItem> Items => _items;

        /// <summary>Adds a new item with the specified caption.</summary>
        /// <param name="caption"></param>
        public void Add(string caption)
        {
            Add(new ListItem(caption));
        }

        public void Add(ListItem item)
        {
            _items.Add(item);
            item.List = this;
        }

        public void Remove(ListItem item)
        {
            _items.Remove(item);
        }

        private readonly IList<ListItem> _items;
    }
}
