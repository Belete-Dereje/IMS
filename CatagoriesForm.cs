namespace IMS
{
    public partial class CatagoriesForm : Form
    {
        private string editingCategoryName = "";

        public CatagoriesForm()
        {
            InitializeComponent();
            RefreshCategoryList();
        }

        private void CatagoriesForm_Load(object sender, EventArgs e)
        {
            RefreshCategoryList();
        }

        private void RefreshCategoryList()
        {
            string searchText = txtSearchCategories.Text.Trim();

            lvCategories.Items.Clear();

            foreach (string category in InventoryData.Categories)
            {
                if (category.IndexOf(
                        searchText,
                        StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }

                lvCategories.Items.Add(new ListViewItem(category));
            }
        }

        private void txtSearchCategories_TextChanged(object sender, EventArgs e)
        {
            RefreshCategoryList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (categoryName == "")
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            string? existingCategory = InventoryData.Categories.Find(
                category => category.Equals(
                    categoryName,
                    StringComparison.OrdinalIgnoreCase));

            if (editingCategoryName == "")
            {
                if (existingCategory != null)
                {
                    MessageBox.Show("This category already exists.");
                    return;
                }

                InventoryData.Categories.Add(categoryName);

                MessageBox.Show(
                    "Category added successfully!",
                    "Inventory Management System");
            }
            else
            {
                string? categoryBeingEdited = InventoryData.Categories.Find(
                    category => category.Equals(
                        editingCategoryName,
                        StringComparison.OrdinalIgnoreCase));

                if (categoryBeingEdited == null)
                {
                    MessageBox.Show("The category being edited was not found.");
                    return;
                }

                if (existingCategory != null &&
                    !existingCategory.Equals(
                        categoryBeingEdited,
                        StringComparison.Ordinal))
                {
                    MessageBox.Show("This category already exists.");
                    return;
                }

                int categoryIndex =
                    InventoryData.Categories.IndexOf(categoryBeingEdited);

                InventoryData.Categories[categoryIndex] = categoryName;

                foreach (Product product in InventoryData.Products)
                {
                    if (product.Category.Equals(
                        editingCategoryName,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        product.Category = categoryName;
                    }
                }

                MessageBox.Show(
                    "Category updated successfully!",
                    "Inventory Management System");
            }

            ClearCategoryForm();
            RefreshCategoryList();
        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            ClearCategoryForm();
        }

        private void ClearCategoryForm()
        {
            txtCategoryName.Clear();
            editingCategoryName = "";
            btnAddCategory.Text = "Add Category";
            lvCategories.SelectedItems.Clear();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a category first.");
                return;
            }

            string selectedCategory = lvCategories.SelectedItems[0].Text;

            string? category = InventoryData.Categories.Find(
                item => item.Equals(
                    selectedCategory,
                    StringComparison.OrdinalIgnoreCase));

            if (category == null)
            {
                MessageBox.Show("Category not found.");
                return;
            }

            txtCategoryName.Text = category;
            editingCategoryName = category;
            btnAddCategory.Text = "Update Category";
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a category first.");
                return;
            }

            string selectedCategory = lvCategories.SelectedItems[0].Text;

            bool categoryIsUsed = InventoryData.Products.Exists(
                product => product.Category.Equals(
                    selectedCategory,
                    StringComparison.OrdinalIgnoreCase));

            if (categoryIsUsed)
            {
                MessageBox.Show(
                    "This category cannot be deleted because it is assigned to a product.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            string? categoryToDelete = InventoryData.Categories.Find(
                category => category.Equals(
                    selectedCategory,
                    StringComparison.OrdinalIgnoreCase));

            if (categoryToDelete == null)
            {
                MessageBox.Show("Category not found.");
                return;
            }

            InventoryData.Categories.Remove(categoryToDelete);
            ClearCategoryForm();
            RefreshCategoryList();

            MessageBox.Show("Category deleted successfully.");
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}