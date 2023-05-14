namespace WinForms.PointOfSaleLibrary.Data;

public class BrandData
{
    SqlDataAccess sqlDataAccess = new SqlDataAccess();

    public async Task<IEnumerable<BrandModel>> GetBrands() =>
        await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetAll", new { });

    public async Task<BrandModel> GetBrand(int BrandId) =>
        (await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetById", new { BrandId })).FirstOrDefault();

    public Task InsertBrand(BrandModel brand) =>
        sqlDataAccess.SaveData("dbo.spBrand_Insert", new { brand.BrandName });

    public Task UpdateBrand(BrandModel brand) =>
        sqlDataAccess.SaveData("dbo.spBrand_Update", brand);

    public Task DeleteBrand(int BrandId) =>
        sqlDataAccess.SaveData("dbo.spBrand_Delete", new { BrandId });
}
