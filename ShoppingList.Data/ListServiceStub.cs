using MetaP.ShoppingList.Model;
using System.Threading.Tasks;

namespace MetaP.ShoppingList
{
    public class ListServiceStub : IListService
    {
        public async Task<List> Get(string name)
        {
            List list = new(name);
            list.Add("Tio Pepe");
            list.Add("Chips zout");

            return list;
        }

        public async Task Save(List list)
        {
            throw new System.NotImplementedException();
        }
    }
}
