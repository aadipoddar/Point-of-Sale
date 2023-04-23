namespace PointOfSale;

class DBConnection
{
    public string MyConnection()
    {
        string con = "Data Source=AADILAPI\\SQLEXPRESS;Initial Catalog=PointOfSale;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        return con;
    }
}
