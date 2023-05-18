namespace WinForms.PointOfSaleLibrary.Models;

public class SaleModel
{
    public int SaleId { get; set; }
    public string TransactionNo { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
    public decimal CashGiven { get; set; }
    public decimal Change { get; set; }
}
