namespace WinForms.PointOfSaleLibrary.Data;

public class SaleData
{
    SqlDataAccess sqlDataAccess = new();

    public async Task<IEnumerable<ShowSaleModel>> GetSale() =>
       await sqlDataAccess.LoadData<ShowSaleModel, dynamic>("dbo.spSale_GetAll", new { });

    public async Task<IEnumerable<ShowSaleModel>> GetSaleByDate(string StartDate, string EndDate) =>
       await sqlDataAccess.LoadData<ShowSaleModel, dynamic>("dbo.spSale_GetByDate", new { StartDate, EndDate });

    public async Task<string> GetTransactionNo(string SaleDate) =>
        (await sqlDataAccess.LoadData<string, dynamic>("dbo.spSale_GetTransactionNo", new { SaleDate })).FirstOrDefault();

    public async Task<int> GetSaleId(string TransactionNo) =>
        (await sqlDataAccess.LoadData<int, dynamic>("dbo.spSale_GetSaleId", new { TransactionNo })).FirstOrDefault();

    public async Task InsertSale(SaleModel sale) =>
        await sqlDataAccess.SaveData("dbo.spSale_Insert",
            new { sale.TransactionNo, sale.SaleDate, sale.SubTotal, sale.Discount, sale.Tax, sale.Total, sale.CashGiven, sale.Change });

    public async Task InsertSaleDetail(SaleDetailModel saleDetail) =>
        await sqlDataAccess.SaveData("dbo.spSaleDetail_Insert",
            new { saleDetail.SaleId, saleDetail.ProductId, saleDetail.Quantity, saleDetail.Prize, saleDetail.DiscountAmount, saleDetail.DiscountPercent, saleDetail.TaxPercent, saleDetail.TaxAmount, saleDetail.FinalPrize });

    public async Task InsertInventory(InventoryModel inventory) =>
        await sqlDataAccess.SaveData("dbo.spInventory_Insert",
            new { inventory.ProductId, inventory.Quantity, inventory.BillNo, inventory.Prize });
}
