using MetaP.ShoppingList.Model;
using System.Threading.Tasks;

namespace MetaP.ShoppingList
{
    public class ShoppingListProvider
    {
        public Task<List> GetShoppingList()
        {
            // ToDo: Implement ShoppingListProvider.GetShoppingList()
            List list =  new List()
            {
                Title = "Delhaize",
                Items = new ListItem[]
                {
                    new ListItem { Caption = "Tio Pepe"},
                    new ListItem { Caption = "Romeinse salade"}
                }
            };

            // Return the list asynchronously (as if it was provided by an on-line service)
            return Task<List>.FromResult(list);
        }
    }
}
