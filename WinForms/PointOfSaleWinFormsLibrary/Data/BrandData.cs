namespace WinForms.PointOfSaleLibrary.Data;

public class BrandData
{
    SqlDataAccess sqlDataAccess = new SqlDataAccess();

    public async Task<IEnumerable<BrandModel>> GetBrands() =>
        await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetAll", new { });

    public async Task<BrandModel> GetBrand(int id) =>
        (await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetById", new { Id = id })).FirstOrDefault();

    public Task InsertBrand(BrandModel brand) =>
        sqlDataAccess.SaveData("dbo.spBrand_Insert", new { brand.Brand });

    public Task UpdateBrand(BrandModel brand) =>
        sqlDataAccess.SaveData("dbo.spBrand_Update", brand);

    public Task DeleteBrand(int id) =>
        sqlDataAccess.SaveData("dbo.spBrand_Delete", new { Id = id });
}
