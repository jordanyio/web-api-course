using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Application
{
    public class SearchHandler
    {
        private readonly IStoreRepository _storeRepository;

        public SearchHandler(IStoreRepository repository)
        {
            _storeRepository = repository;
        }

        public async Task<IEnumerable<Item>> FindItemsWithSearchState(SearchState search)
        {
            var items = await _storeRepository.GetStoreInventory();
        }
    }
}
