using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.Data
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Item>> GetStoreInventory();
        Task<Item> GetItemById(int id);
        Task AddItemAsync(Item item);
    }

    internal class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _dbContext;

        public StoreRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Item> GetItemById(int id)
        {
            var item =  await _dbContext.Items.FindAsync(id);
            return item ?? new Item();
        }

        public async Task<IEnumerable<Item>> GetStoreInventory()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public async Task AddItemAsync(Item item)
        {
            await _dbContext.AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }
    }
}
