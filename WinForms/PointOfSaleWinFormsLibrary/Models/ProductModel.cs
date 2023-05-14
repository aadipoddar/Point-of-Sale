namespace WinForms.PointOfSaleLibrary.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public BrandModel Brand { get; set; }
        public CategoryModel Category { get; set; }
        public decimal Prize { get; set; }
        public decimal Tax { get; set; }
    }
}
