using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Components
{
    public partial class ListView
    {
        [Inject]
        public ShoppingListProvider ShoppingListProvider { get; set; }

        private List List { get; set; }

        protected override async Task OnInitializedAsync()
        {
            List = await ShoppingListProvider.GetShoppingList();
        }
    }
}
