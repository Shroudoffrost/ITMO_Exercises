using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_adapter_tinkering
{
    public partial class Main_window : Form
    {
        DataSet               Northwind_ds = new DataSet("Northwind");
        static SqlDataAdapter data_adapter = new SqlDataAdapter(
                                Sql_tools.Query, Sql_tools.DB_credentials);
        SqlCommandBuilder commands = new SqlCommandBuilder(data_adapter);

        public Main_window()
        {
            InitializeComponent();
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            data_adapter.Fill(Northwind_ds, "Customers");
            main_grid_view.DataSource = Northwind_ds.Tables["Customers"];
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Northwind_ds.EndInit();
            data_adapter.Update(Northwind_ds.Tables["Customers"]);
        }

        private void btn_add_row_Click(object sender, EventArgs e)
        {
            DataRow T_customers_row = Northwind_ds.Tables["Customers"].NewRow();
            Object[] Customers_record = {"AAAAA", "Alfreds Futterkiste",
                                         "Maria Anders", "Sales Representative",
                                         "Obere Str. 57", "Berlin", null,
                                         "12209", "Germany", "030-0074321","030-0076545"};
            T_customers_row.ItemArray = Customers_record;
            Northwind_ds.Tables["Customers"].Rows.Add(T_customers_row);
        }

        private void btn_delete_row_Click(object sender, EventArgs e)
        {
            Northwind_ds.EndInit();
            var index = main_grid_view.CurrentRow.Index;
            Northwind_ds.Tables["Customers"].Rows[index].Delete();
            data_adapter.Update(Northwind_ds.Tables["Customers"]);
        }
    }
}
