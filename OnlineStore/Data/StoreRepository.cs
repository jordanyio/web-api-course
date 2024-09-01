using OnlineStore.Models;

namespace OnlineStore.Data
{
    public class StoreRepository
    {
        public List<Item> GetItems()
        {
            var item1 = new Item
            {
                Id = 1,
                Name = "Running Shoe",
                Description = "Mens Running Shoe.",
                InventoryCount = 10,
                Color = "Black and White."
            };

            var item2 = new Item
            {
                Id = 2,
                Name = "Hoodie",
                Description = "Very soft unisex hoodie.",
                InventoryCount = 507,
                Color = "Blue"
            };

            var item3 = new Item
            {
                Id = 3,
                Name = "Hockey Stick",
                Description = "Rebok O stick.",
                InventoryCount = 14,
                Color = "Black"
            };

            return [item1, item2, item3];
        }
    }
}
