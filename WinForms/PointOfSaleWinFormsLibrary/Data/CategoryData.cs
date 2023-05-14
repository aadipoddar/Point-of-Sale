namespace WinForms.PointOfSaleLibrary.Data;

public class CategoryData
{
    SqlDataAccess sqlDataAccess = new SqlDataAccess();

    public async Task<IEnumerable<CategoryModel>> GetCategories() =>
        await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetAll", new { });

    public async Task<CategoryModel> GetCategory(int CategoryId) =>
        (await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetById", new { CategoryId })).FirstOrDefault();

    public Task InsertCategory(CategoryModel category) =>
        sqlDataAccess.SaveData("dbo.spCategory_Insert", new { category.CategoryName });

    public Task UpdateCategory(CategoryModel category) =>
        sqlDataAccess.SaveData("dbo.spCategory_Update", category);

    public Task DeleteCategory(int CategoryId) =>
        sqlDataAccess.SaveData("dbo.spCategory_Delete", new { CategoryId });
}
