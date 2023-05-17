namespace WinForms.PointOfSaleLibrary.Data;

public class ProductData
{
    SqlDataAccess sqlDataAccess = new();

    public async Task<IEnumerable<ShowProductModel>> GetProducts() =>
        await sqlDataAccess.LoadData<ShowProductModel, dynamic>("dbo.spProduct_GetAll", new { });

    public async Task<IEnumerable<ShowProductModel>> GetProductsBySearch(string ProductName) =>
        await sqlDataAccess.LoadData<ShowProductModel, dynamic>("dbo.spProduct_GetBySearch", new { ProductName });

    public async Task<ProductModel> GetProductById(int ProductId) =>
        (await sqlDataAccess.LoadData<ProductModel, dynamic>("dbo.spProduct_GetById", new { ProductId })).FirstOrDefault();

    public async Task InsertProduct(ProductModel product) =>
        await sqlDataAccess.SaveData("dbo.spProduct_Insert", new { product.ProductName, product.Brand.BrandId, product.Category.CategoryId, product.Prize, product.Tax });

    public async Task UpdateProduct(ProductModel product) =>
        await sqlDataAccess.SaveData("dbo.spProduct_Update", new { product.ProductId, product.ProductName, product.Brand.BrandId, product.Category.CategoryId, product.Prize, product.Tax });

    public async Task DeleteProduct(int ProductId) =>
        await sqlDataAccess.SaveData("dbo.spProduct_Delete", new { ProductId });
}
