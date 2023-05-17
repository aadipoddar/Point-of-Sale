namespace WinForms.PointOfSaleLibrary.Models;

public class ShowPurchaseModel
{
    public int PurchaseId { get; set; }
    public string TransactionNo { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal PrizePerQuantity { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
    public DateTime PurchaseDate { get; set; }
    public string PurchaseBy { get; set; }
}
