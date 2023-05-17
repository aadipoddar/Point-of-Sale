namespace WinForms.PointOfSaleLibrary.Models;

public class PurchaseDetailModel
{
    public int PurchaseDetailId { get; set; }
    public int PurchaseId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal PrizePerQuantity { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
}
