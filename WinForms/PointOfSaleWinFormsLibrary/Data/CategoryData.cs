namespace WinForms.PointOfSaleLibrary.Data;

public class CategoryData
{
    SqlDataAccess sqlDataAccess = new SqlDataAccess();

    public async Task<IEnumerable<CategoryModel>> GetCategories() =>
        await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetAll", new { });

    public async Task<CategoryModel> GetCategory(int id) =>
        (await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetById", new { Id = id })).FirstOrDefault();

    public Task InsertCategory(CategoryModel category) =>
        sqlDataAccess.SaveData("dbo.spCategory_Insert", new { category.Category });

    public Task UpdateCategory(CategoryModel category) =>
        sqlDataAccess.SaveData("dbo.spCategory_Update", category);

    public Task DeleteCategory(int id) =>
        sqlDataAccess.SaveData("dbo.spCategory_Delete", new { Id = id });
}
