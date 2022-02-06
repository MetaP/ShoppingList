using System.Threading.Tasks;

namespace MetaP.ShoppingList.Model
{
    public interface IListService
    {
        Task<List> Get(string name);

        Task Save(List list);
    }
}
