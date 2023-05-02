using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinForms.PointOfSaleLibrary.DataAccess;
using WinForms.PointOfSaleLibrary.Models;

namespace WinForms.PointOfSaleLibrary.Data
{
    public class BrandData
    {
        SqlDataAccess sqlDataAccess = new SqlDataAccess();

        public async Task<IEnumerable<BrandModel>> GetBrands()
        {
            return await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetAll", new { });
        }

        public async Task<BrandModel> GetBrand(int id)
        {
            var results = await sqlDataAccess.LoadData<BrandModel, dynamic>("dbo.spBrand_GetById", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertBrand(BrandModel brand)
        {
            return sqlDataAccess.SaveData("dbo.spBrand_Insert", new { brand.Brand });
        }

        public Task UpdateBrand(BrandModel brand)
        {
            return sqlDataAccess.SaveData("dbo.spBrand_Update", brand);
        }

        public Task DeleteBrand(int id)
        {
            return sqlDataAccess.SaveData("dbo.spBrand_Delete", new { Id = id });
        }
    }
}
