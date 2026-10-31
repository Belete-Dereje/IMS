using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class SuppliersForm : Form
    {
        private string editingSupplierCode = "";
        public SuppliersForm()
        {
            InitializeComponent();

            RefreshSupplierList();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // Read the input fields
            string code = txtSupplierCode.Text.Trim();
            string name = txtSupplierName.Text.Trim();

            // Check required fields
            if (code == "" || name == "")
            {
                MessageBox.Show("Please enter the Supplier Code and Supplier Name.");
                return;
            }

            // Find the supplier being edited
            Supplier supplierToUpdate = null;

            if (editingSupplierCode != "")
            {
                foreach (Supplier supplier in InventoryData.Suppliers)
                {
                    if (supplier.SupplierCode.Equals(
                        editingSupplierCode, StringComparison.OrdinalIgnoreCase))
                    {
                        supplierToUpdate = supplier;
                        break;
                    }
                }

                if (supplierToUpdate == null)
                {
                    MessageBox.Show("Supplier not found.");
                    return;
                }
            }

            // Check whether the code is already used
            foreach (Supplier supplier in InventoryData.Suppliers)
            {
                if (supplier.SupplierCode.Equals(
                    code, StringComparison.OrdinalIgnoreCase))
                {
                    if (supplierToUpdate == null || supplier != supplierToUpdate)
                    {
                        MessageBox.Show("This supplier code already exists.");
                        return;
                    }
                }
            }

            // Add a new supplier or update the selected supplier
            if (supplierToUpdate == null)
            {
                Supplier newSupplier = new Supplier();

                newSupplier.SupplierCode = code;
                newSupplier.SupplierName = name;
                newSupplier.Phone = txtSupplierPhone.Text.Trim();
                newSupplier.Email = txtSupplierEmail.Text.Trim();
                newSupplier.Address = txtSupplierAddress.Text.Trim();

                InventoryData.Suppliers.Add(newSupplier);

                MessageBox.Show("Supplier added successfully!");
            }
            else
            {
                supplierToUpdate.SupplierCode = code;
                supplierToUpdate.SupplierName = name;
                supplierToUpdate.Phone = txtSupplierPhone.Text.Trim();
                supplierToUpdate.Email = txtSupplierEmail.Text.Trim();
                supplierToUpdate.Address = txtSupplierAddress.Text.Trim();

                MessageBox.Show("Supplier updated successfully!");
            }

            // Refresh the supplier table
            RefreshSupplierList();

            // Reset the form
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtSupplierPhone.Clear();
            txtSupplierEmail.Clear();
            txtSupplierAddress.Clear();

            editingSupplierCode = "";
            btnAddSupplier.Text = "Add Supplier";
        }
        private void RefreshSupplierList()
        {
            string searchText = txtSearchSuppliers.Text.Trim();

            // Clear the current table
            lvSuppliers.Items.Clear();

            // Check every supplier
            foreach (Supplier supplier in InventoryData.Suppliers)
            {
                // Match supplier code or supplier name
                if (supplier.SupplierCode.IndexOf(
                        searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    supplier.SupplierName.IndexOf(
                        searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Create a row
                    ListViewItem item =
                        new ListViewItem(supplier.SupplierCode);

                    item.SubItems.Add(supplier.SupplierName);
                    item.SubItems.Add(supplier.Phone);
                    item.SubItems.Add(supplier.Email);
                    item.SubItems.Add(supplier.Address);

                    // Display the supplier
                    lvSuppliers.Items.Add(item);
                }
            }
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            // Check whether a supplier is selected
            if (lvSuppliers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a supplier first.");
                return;
            }

            // Get the selected supplier code
            string code = lvSuppliers.SelectedItems[0].Text;

            // Find the supplier
            foreach (Supplier supplier in InventoryData.Suppliers)
            {
                if (supplier.SupplierCode.Equals(
                    code, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the supplier details in the input fields
                    txtSupplierCode.Text = supplier.SupplierCode;
                    txtSupplierName.Text = supplier.SupplierName;
                    txtSupplierPhone.Text = supplier.Phone;
                    txtSupplierEmail.Text = supplier.Email;
                    txtSupplierAddress.Text = supplier.Address;

                    // Remember which supplier is being edited
                    editingSupplierCode = supplier.SupplierCode;

                    // Change the button text
                    btnAddSupplier.Text = "Update Supplier";

                    return;
                }
            }

            MessageBox.Show("Supplier not found.");
        }

        private void btnAddSupplier_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            // Check whether a supplier is selected
            if (lvSuppliers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            // Get the selected supplier code
            string code = lvSuppliers.SelectedItems[0].Text;

            // Ask for confirmation
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this supplier?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            // Find the supplier
            Supplier supplierToDelete = null;

            foreach (Supplier supplier in InventoryData.Suppliers)
            {
                if (supplier.SupplierCode.Equals(
                    code, StringComparison.OrdinalIgnoreCase))
                {
                    supplierToDelete = supplier;
                    break;
                }
            }

            // Check whether the supplier was found
            if (supplierToDelete == null)
            {
                MessageBox.Show("Supplier not found.");
                return;
            }

            // Remove the supplier
            InventoryData.Suppliers.Remove(supplierToDelete);

            // Clear the form if this supplier was being edited
            if (editingSupplierCode.Equals(
                code, StringComparison.OrdinalIgnoreCase))
            {
                txtSupplierCode.Clear();
                txtSupplierName.Clear();
                txtSupplierPhone.Clear();
                txtSupplierEmail.Clear();
                txtSupplierAddress.Clear();

                editingSupplierCode = "";
                btnAddSupplier.Text = "Add Supplier";
            }

            // Refresh the supplier table
            RefreshSupplierList();

            MessageBox.Show("Supplier deleted successfully.");
        }

        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            RefreshSupplierList();
        }

        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtSupplierPhone.Clear();
            txtSupplierEmail.Clear();
            txtSupplierAddress.Clear();

            editingSupplierCode = "";
            btnAddSupplier.Text = "Add Supplier";
        }
    }

}
