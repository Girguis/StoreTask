namespace StoreTask.Models
{
    public class AddProductModel
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Stock { get; set; }
        public decimal TotalCostOfStock { get; set; }
        public string Description { get; set; }
    }
    public class ProductViewModel : AddProductModel
    {
        public int ID { get; set; }
        public string Category { get; set; }
    }
    public class ProductSearchModel
    {
        public string Name { get; set; }
        public int? CategoryID { get; set; }
        public int? Stock { get; set; }
        public decimal? TotalCostOfStock { get; set; }
    }
}
