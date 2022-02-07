using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Pages
{
    public partial class Index
    {
        [Inject]
        public IListService ListService { get; set; }

        private List? List { get; set; }

        protected override async Task<Task> OnInitializedAsync()
        {
            List = await ListService.Get("Delhaize");
            return base.OnInitializedAsync();
        }
    }
}
