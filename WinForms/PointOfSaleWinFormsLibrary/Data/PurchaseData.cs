namespace WinForms.PointOfSaleLibrary.Data;

public class PurchaseData
{
    SqlDataAccess sqlDataAccess = new();

    public async Task<string> GetTransactionNo(string PurchaseDate) =>
        (await sqlDataAccess.LoadData<string, dynamic>("dbo.spPurchase_GetTransactionNo", new { PurchaseDate })).FirstOrDefault();

    public async Task<int> GetPurchaseId(string TransactionNo) =>
        (await sqlDataAccess.LoadData<int, dynamic>("dbo.spPurchase_GetPurchaseId", new { TransactionNo })).FirstOrDefault();

    public async Task InsertPurchase(PurchaseModel purchase) =>
        await sqlDataAccess.SaveData("dbo.spPurchase_Insert",
            new { purchase.TransactionNo, purchase.PurchaseBy, purchase.PurchaseDate, purchase.SubTotal, purchase.Tax, purchase.Total });

    public async Task InsertPurchaseDetail(PurchaseDetailModel purchaseDetail) =>
        await sqlDataAccess.SaveData("dbo.spPurchaseDetail_Insert",
                       new { purchaseDetail.PurchaseId, purchaseDetail.ProductId, purchaseDetail.Quantity, purchaseDetail.PrizePerQuantity, purchaseDetail.SubTotal, purchaseDetail.Tax, purchaseDetail.Total });

    public async Task InsertInventory(InventoryModel inventory) =>
        await sqlDataAccess.SaveData("dbo.spInventory_Insert",
                       new { inventory.ProductId, inventory.Quantity, inventory.BillNo, inventory.Prize });
}
