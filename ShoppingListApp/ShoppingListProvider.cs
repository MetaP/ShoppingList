using MetaP.ShoppingList.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MetaP.ShoppingList
{
    public class ShoppingListProvider
    {
        public Task<List> GetShoppingList()
        {
            // ToDo: Implement ShoppingListProvider.GetShoppingList()
            List list = new("Delhaize");
            list.Add("Tio Pepe");
            list.Add("Romeinse salade");

            list.Items.First().CheckedOff = true;

            // Return the list asynchronously (as if it was provided by an on-line service)
            return Task<List>.FromResult(list);
        }
    }
}
