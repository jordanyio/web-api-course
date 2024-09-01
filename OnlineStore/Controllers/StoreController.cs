using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRespository _onlineStoreRespository;

        public StoreController(IStoreRespository onlineStoreRespository)
        {
            _onlineStoreRespository = onlineStoreRespository;
        }

        [HttpGet("GetStoreInventory")]
        public async Task<IActionResult> Get()
        {
            var inventory = await _onlineStoreRespository.GetStoreInventory();

            return Ok(inventory);
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
