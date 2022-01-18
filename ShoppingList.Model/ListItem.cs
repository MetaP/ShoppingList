using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Model
{
    public class ListItem
    {
        public string Caption { get; set; }

        /// <summary>Indicates whether this item has been checked off the list or not.</summary>
        public bool CheckedOff { get; set; }
    }
}
