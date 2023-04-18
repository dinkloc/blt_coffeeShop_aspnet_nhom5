using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopMangement.ModelViews
{
    public partial class ProductAPI 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CatId { get; set; }
        public int? Price { get; set; }
        public string? Thumb { get; set; }
    }
}
