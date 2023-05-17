namespace WinForms.PointOfSaleLibrary.Data;

public class CategoryData
{
    SqlDataAccess sqlDataAccess = new();

    public async Task<IEnumerable<CategoryModel>> GetCategories() =>
        await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetAll", new { });

    public async Task<IEnumerable<CategoryModel>> GetCategoriesBySearch(string CategoryName) =>
        await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetBySearch", new { CategoryName });

    public async Task<CategoryModel> GetCategoryById(int CategoryId) =>
        (await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetById", new { CategoryId })).FirstOrDefault();

    public async Task InsertCategory(CategoryModel category) =>
        await sqlDataAccess.SaveData("dbo.spCategory_Insert", new { category.CategoryName });

    public async Task UpdateCategory(CategoryModel category) =>
        await sqlDataAccess.SaveData("dbo.spCategory_Update", category);

    public async Task DeleteCategory(int CategoryId) =>
        await sqlDataAccess.SaveData("dbo.spCategory_Delete", new { CategoryId });
}
