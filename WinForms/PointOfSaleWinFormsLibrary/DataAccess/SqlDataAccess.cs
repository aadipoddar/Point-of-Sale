using System.Configuration;

using Dapper;

namespace WinForms.PointOfSaleLibrary.DataAccess;

public class SqlDataAccess
{
    public string GetConnectionString() =>
        ConfigurationManager.ConnectionStrings["PointOfSale.Properties.Settings.PointOfSaleConnectionString"].ConnectionString;

    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters)
    {
        using IDbConnection connection = new SqlConnection(GetConnectionString());

        return await connection.QueryAsync<T>(storedProcedure,
                                              parameters,
                                              commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(string storedProcedure, T parameters)
    {
        using IDbConnection connection = new SqlConnection(GetConnectionString());

        await connection.ExecuteAsync(storedProcedure,
                                      parameters,
                                      commandType: CommandType.StoredProcedure);
    }
}
