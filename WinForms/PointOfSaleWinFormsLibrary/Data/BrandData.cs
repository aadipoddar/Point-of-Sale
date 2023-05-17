namespace WinForms.PointOfSaleLibrary.Data;

public class BrandData
{
    SqlDataAccess sqlDataAccess = new();

    public async Task<IEnumerable<BrandModel>> GetBrands() =>
        await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetAll", new { });

    public async Task<IEnumerable<BrandModel>> GetBrandsBySearch(string BrandName) =>
        await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetBySearch", new { BrandName });

    public async Task<BrandModel> GetBrandById(int BrandId) =>
        (await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetById", new { BrandId })).FirstOrDefault();

    public async Task InsertBrand(BrandModel brand) =>
        await sqlDataAccess.SaveData("dbo.spBrand_Insert", new { brand.BrandName });

    public async Task UpdateBrand(BrandModel brand) =>
        await sqlDataAccess.SaveData("dbo.spBrand_Update", brand);

    public async Task DeleteBrand(int BrandId) =>
        await sqlDataAccess.SaveData("dbo.spBrand_Delete", new { BrandId });
}
