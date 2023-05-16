namespace WinForms.PointOfSaleLibrary.Data;

public class PurchaseData
{
    SqlDataAccess sqlDataAccess = new();

    public async Task<TransactionNoModel> GetTransactionNo(string PurchaseDate) =>
        (await sqlDataAccess.LoadData<TransactionNoModel, dynamic>("dbo.spPurchase_GetTransactionNo", new { PurchaseDate })).FirstOrDefault();
}
