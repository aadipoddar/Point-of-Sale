using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WinForms.PointOfSaleLibrary.DataAccess;
using WinForms.PointOfSaleLibrary.Models;

namespace WinForms.PointOfSaleLibrary.Data
{
    public class CategoryData
    {
        SqlDataAccess sqlDataAccess = new SqlDataAccess();

        public async Task<IEnumerable<CategoryModel>> GetCategories()
        {
            return await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetAll", new { });
        }

        public async Task<CategoryModel> GetCategory(int id)
        {
            var results = await sqlDataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetById", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertCategory(CategoryModel category)
        {
            return sqlDataAccess.SaveData("dbo.spCategory_Insert", new { category.Category });
        }

        public Task UpdateCategory(CategoryModel category)
        {
            return sqlDataAccess.SaveData("dbo.spCategory_Update", category);
        }

        public Task DeleteCategory(int id)
        {
            return sqlDataAccess.SaveData("dbo.spCategory_Delete", new { Id = id });
        }
    }
}
