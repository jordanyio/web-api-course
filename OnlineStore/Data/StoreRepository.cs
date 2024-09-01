using Microsoft.EntityFrameworkCore;
using OnlineStore.Application;
using OnlineStore.Models;

namespace OnlineStore.Data
{
    public interface IStoreRespository
    {
        Task<IEnumerable<Item>> GetStoreInventory();
        Task AddItemAsync(Item item);
    }

    internal class StoreRepository : IStoreRespository
    {
        private readonly StoreDbContext _dbContext;

        public StoreRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
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
