namespace WinForms.PointOfSaleLibrary.Models;

public class InventoryModel
{
    public int InventoryId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string BillNo { get; set; }
    public decimal Prize { get; set; }
}
