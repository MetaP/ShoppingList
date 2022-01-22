using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Pages
{
    public partial class Index
    {
        [Inject]
        public ShoppingListProvider? ShoppingListProvider { get; set; }

        private List? List { get; set; }

        protected override async Task<Task> OnInitializedAsync()
        {
            if (ShoppingListProvider is not null)
            {
                List = await ShoppingListProvider.GetShoppingList();
            }
            return base.OnInitializedAsync();
        }
    }
}
