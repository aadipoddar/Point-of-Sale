namespace PointOfSale;

public partial class BrandsForm : Form
{
    public BrandsForm()
    {
        InitializeComponent();

        for (int i = 0; i < 10; ++i)
        {
            dataGridViewbrands.Rows.Add(i, "1", "Brand " + i);
        }
    }
}
