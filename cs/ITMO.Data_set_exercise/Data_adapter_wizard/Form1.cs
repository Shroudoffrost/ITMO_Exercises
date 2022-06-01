using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Data_adapter_wizard;

namespace Data_adapter_wizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main_grid_view.DataSource = northwind_ds.Customers;
            sql_adapter.Fill(northwind_ds.Customers);
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            sql_adapter.Update(northwind_ds);
        }

        private void sql_adapter_RowUpdating(
                object sender, SqlRowUpdatingEventArgs e)
        {
            Northwind_ds.CustomersRow row_customers =
                (Northwind_ds.CustomersRow)e.Row;

            DialogResult response = MessageBox.Show(
            "Continue updating " + row_customers.CustomerID.ToString() +
            "?", "Continue update",
            MessageBoxButtons.YesNo);

            if (response == DialogResult.No)
            {   e.Status = UpdateStatus.SkipCurrentRow;}

            MessageBox.Show(
            row_customers.CustomerID.ToString() + "has been updated");
        }

        private void sql_adapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            Northwind_ds.CustomersRow row_customers = (
                Northwind_ds.CustomersRow)e.Row;
            MessageBox.Show(row_customers.CustomerID.ToString() + " updated");
            northwind_ds.Customers.Clear();
            sql_adapter.Fill(northwind_ds.Customers);
        }

        private void sql_adapter_FillError(object sender, FillErrorEventArgs e)
        {
            DialogResult response = MessageBox.Show(
            "The following error occurred while Filling the DataSet: " +
            e.Errors.Message.ToString() +
            " Continue attempting to fill?", "FillError Encountered",
            MessageBoxButtons.YesNo);

            if(response == DialogResult.Yes)
            {   e.Continue = true;}
            else
            {   e.Continue = false;}
        }
    }
}
