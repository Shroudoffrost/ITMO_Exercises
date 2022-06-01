using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_set_design.Northwind_data_setTableAdapters;


namespace Data_set_design
{
    public partial class Form_1 : Form
    {
        Northwind_data_set data_set            = new Northwind_data_set();
        CustomersTableAdapter customer_adapter = new CustomersTableAdapter();
        
        public Form_1()
        {
            InitializeComponent();
        }

        private void btn_get_customers_Click(object sender, EventArgs e)
        {
            customer_adapter.Fill(data_set.Customers);

            foreach(Northwind_data_set.CustomersRow row in data_set.Customers.Rows)
            {
                listbox_customers.Items.Add(row.CompanyName);
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
