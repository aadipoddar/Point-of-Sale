namespace PointOfSale;

class DBConnection
{
    public string MyConnection()
    {
        string con = "Data Source=AADILAPI\\SQLEXPRESS;Initial Catalog=POS_DEMO_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        return con;
    }
}
