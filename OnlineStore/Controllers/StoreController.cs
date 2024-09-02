using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _onlineStoreRespository;

        public StoreController(IStoreRepository onlineStoreRespository)
        {
            _onlineStoreRespository = onlineStoreRespository;
        }

        [HttpGet("GetStoreInventory")]
        public async Task<IActionResult> Get()
        {
            var inventory = await _onlineStoreRespository.GetStoreInventory();

            return Ok(inventory);
        }

        [HttpGet("GetItemsBySearchState")]
        public async Task<IActionResult> Get([FromBody] SearchState search)
        {
            var inventory = await _onlineStoreRespository.GetStoreInventory();

            return Ok(inventory);
        }

        [HttpGet("GetItemById")]
        public async Task<IActionResult> Get([FromBody] int id)
        {
            var item = await _onlineStoreRespository.GetItemById(id);

            return Ok(item);
        }

        [HttpPost("CreateItem")]
        public async Task<IActionResult> CreateItemEndpoint([FromBody] Item item)
        {
            try
            {
                Console.WriteLine(item.Name);
                await _onlineStoreRespository.AddItemAsync(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
