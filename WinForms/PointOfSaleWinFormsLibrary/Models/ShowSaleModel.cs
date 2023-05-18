namespace WinForms.PointOfSaleLibrary.Models;

public class ShowSaleModel
{
    public int SaleId { get; set; }
    public string TransactionNo { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Prize { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal DiscountPercent { get; set; }
    public decimal TaxPercent { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal FinalPrize { get; set; }
    public DateTime SaleDate { get; set; }
}
