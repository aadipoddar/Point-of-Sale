namespace WinForms.PointOfSaleLibrary.Models;

public class PurchaseModel
{
    public int PurchaseId { get; set; }
    public string TransactionNo { get; set; }
    public string PurchaseBy { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
}