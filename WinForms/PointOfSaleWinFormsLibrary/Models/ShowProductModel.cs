namespace WinForms.PointOfSaleLibrary.Models;

public class ShowProductModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string BrandName { get; set; }
    public string Categoryname { get; set; }
    public decimal Prize { get; set; }
    public int Quantity { get; set; }
    public decimal Tax { get; set; }
}
