using System.Configuration;

namespace WinForms.PointOfSale;

public class DBConnection
{
    public string MyConnection()
    {
        return ConfigurationManager.ConnectionStrings["PointOfSale.Properties.Settings.PointOfSaleConnectionString"].ConnectionString;
    }
}
