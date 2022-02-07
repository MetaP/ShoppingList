using MetaP.ShoppingList.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetaP.ShoppingList.Controllers
{
    [ApiController]
    [Route("api/list")]
    public class ShoppingListController : ControllerBase
    {
        public ShoppingListController(IListService listService)
        {
            _listService = listService;
        }

        //[Inject] ** Does not work here. Constructor injection used instead. **
        private readonly IListService _listService;

        //// GET: api/<ShoppingListController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ShoppingListController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ShoppingListController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ShoppingListController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ShoppingListController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        // GET api/list/Delhaize
        [HttpGet("{name}")]
        public async Task<List> GetList(string name)
        {
            return await _listService.Get(name);
        }

        // POST api/list
        [HttpPut("")]
        public async Task SaveList([FromBody] List list)
        {
            await _listService.Save(list);
        }
    }
}
