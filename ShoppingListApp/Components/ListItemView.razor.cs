using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Components
{
    public partial class ListItemView
    {
        [Parameter]
        public ListItem ListItem { get; set; }
    }
}
