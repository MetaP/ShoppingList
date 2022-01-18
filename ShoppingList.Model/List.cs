using System;
using System.Collections.Generic;

namespace MetaP.ShoppingList.Model
{
    public class List
    {
        public string Title { get; set; }

        public IList<ListItem> Items { get; set; }
    }
}
