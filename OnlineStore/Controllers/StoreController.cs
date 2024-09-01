using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly StoreRepository _onlineStoreRespository;

        public StoreController()
        {
            _onlineStoreRespository = new();
        }

        [HttpGet(Name = "GetStoreInventory")]
        public IEnumerable<Item> Get()
        {
            return _onlineStoreRespository.GetItems();
        }
    }
}
