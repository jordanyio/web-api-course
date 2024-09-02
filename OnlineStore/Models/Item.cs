namespace OnlineStore.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int InventoryCount { get; set; }
        public string? Color { get; set; }
       
    }

    public enum Gender
    {
        Male,
        Female,
        Unisex,
        Other
    } 

    public enum Size
    {
        // General Clothing Sizes
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL,

        // Men's Shoe Sizes (US)
        US_Mens_6,
        US_Mens_6_5,
        US_Mens_7,
        US_Mens_7_5,
        US_Mens_8,
        US_Mens_8_5,
        US_Mens_9,
        US_Mens_9_5,
        US_Mens_10,
        US_Mens_10_5,
        US_Mens_11,
        US_Mens_11_5,
        US_Mens_12,
        US_Mens_12_5,
        US_Mens_13,
        US_Mens_14,

        // Women's Shoe Sizes (US)
        US_Womens_5,
        US_Womens_5_5,
        US_Womens_6,
        US_Womens_6_5,
        US_Womens_7,
        US_Womens_7_5,
        US_Womens_8,
        US_Womens_8_5,
        US_Womens_9,
        US_Womens_9_5,
        US_Womens_10,
        US_Womens_10_5,
        US_Womens_11
    }
}
