namespace OnlineStore.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int InventoryCount { get; set; }
        public string Color { get; set; } = string.Empty;
    }
}
