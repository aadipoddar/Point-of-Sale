namespace WinForms.PointOfSale.Products;

public partial class ProductsEditForm : Form
{
    CategoryData categoryData = new();
    List<CategoryModel> categories = new();

    BrandData brandData = new();
    List<BrandModel> brands = new();

    ProductData productData = new();
    ProductModel productModel = new();

    ProductsListForm productsListForm;

    public int productId;
    public string brnadName = "";
    public string categoryName = "";

    public ProductsEditForm(ProductsListForm productsListForm)
    {
        InitializeComponent();

        this.productsListForm = productsListForm;

        _ = LoadComboBox();
    }

    public async Task LoadComboBox()
    {
        brands = (await brandData.GetBrands()).ToList();
        brandComboBox.DataSource = brands;
        brandComboBox.DisplayMember = "BrandName";
        brandComboBox.ValueMember = "BrandId";

        categories = (await categoryData.GetCategories()).ToList();
        categoryComboBox.DataSource = categories;
        categoryComboBox.DisplayMember = "CategoryName";
        categoryComboBox.ValueMember = "CategoryId";

        if (brnadName != "" && categoryName != "")
        {
            brandComboBox.Text = brnadName;
            categoryComboBox.Text = categoryName;
        }
    }

    private void TextBoxClear()
    {
        saveButton.Enabled = true;
        saveButton.Visible = true;

        updateButton.Enabled = false;
        updateButton.Visible = false;

        descriptionTextBox.Clear();
        brandComboBox.SelectedIndex = 0;
        categoryComboBox.SelectedIndex = 0;
        priceNumericUpDown.Value = 0;
        taxNumericUpDown.Value = 0;

        descriptionTextBox.Focus();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to save this Product", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            productModel.ProductName = descriptionTextBox.Text;

            productModel.Brand = new();
            productModel.Brand.BrandId = Convert.ToInt32(brandComboBox.SelectedValue);

            productModel.Category = new();
            productModel.Category.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);

            productModel.Prize = Convert.ToDecimal(priceNumericUpDown.Text);
            productModel.Tax = Convert.ToDecimal(taxNumericUpDown.Text);

            productData.InsertProduct(productModel);

            TextBoxClear();

            _ = productsListForm.DataGridRefresh();
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to update this Product", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            productModel.ProductId = productId;
            productModel.ProductName = descriptionTextBox.Text;

            productModel.Brand = new();
            productModel.Brand.BrandId = Convert.ToInt32(brandComboBox.SelectedValue);

            productModel.Category = new();
            productModel.Category.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);

            productModel.Prize = Convert.ToDecimal(priceNumericUpDown.Text);
            productModel.Tax = Convert.ToDecimal(taxNumericUpDown.Text);

            productData.UpdateProduct(productModel);

            cancelButton_Click(sender, e);
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();

        _ = productsListForm.DataGridRefresh();
    }
}
