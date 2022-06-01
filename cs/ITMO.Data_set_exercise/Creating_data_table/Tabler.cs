using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_data_table
{
    public partial class Tabler : Form
    {
        public Tabler()
        {
            InitializeComponent();
        }

        private DataSet data_set;
        private BindingSource binding_source_1;
        private BindingSource binding_source_2;

        private void Create_data_tables()
        {
            Creat_parent_table();
            Create_child_table();
            Create_data_relation();
            Bind_to_data_grid();
        }

        private void Creat_parent_table()
        {
            DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
#pragma warning disable CS8601 // Possible null reference assignment.
            column.DataType = Type.GetType("System.Int32");
#pragma warning restore CS8601 // Possible null reference assignment.
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
#pragma warning disable CS8601 // Possible null reference assignment.
            column.DataType = Type.GetType("System.String");
#pragma warning restore CS8601 // Possible null reference assignment.
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["id"];
            table.PrimaryKey = PrimaryKeyColumns;

            data_set = new DataSet();
            data_set.Tables.Add(table);

            for (int i = 0; i<= 2; i++)
            {
                row = table.NewRow();
                row["id"] = i;
                row["ParentItem"] = "ParentItem " + i;
                table.Rows.Add(row);
                                       }
        }

        private void Create_child_table()
        {
            DataTable table = new DataTable("childTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType= System.Type.GetType("System.Int32");
            column.ColumnName = "ChildID";
            column.AutoIncrement = true;
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType= System.Type.GetType("System.String");
            column.ColumnName = "ChildItem";
            column.AutoIncrement = false;
            column.Caption = "ChildItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType= System.Type.GetType("System.Int32");
            column.ColumnName = "ParentID";
            column.AutoIncrement = false;
            column.Caption = "ParentID";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            data_set.Tables.Add(table);

            for(int i = 0; i <= 4; i ++)
            {
                row = table.NewRow();
                row["childID"] = i;
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 0 ;
                table.Rows.Add(row);
            }
            for(int i = 0; i <= 4; i ++)
            {
                row = table.NewRow();
                row["childID"] = i + 5;
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 1 ;
                table.Rows.Add(row);
            }
            for(int i = 0; i <= 4; i ++)
            {
                row = table.NewRow();
                row["childID"] = i + 10;
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 2 ;
                table.Rows.Add(row);
            }
        }

        private void Create_data_relation()
        {
            DataColumn parentColumn =
                data_set.Tables["ParentTable"]
                        .Columns["id"];
            DataColumn childColumn =
                data_set.Tables["ChildTable"]
                        .Columns["ParentID"];
            DataRelation relation = new
                DataRelation("parent2Child", parentColumn, childColumn);
            data_set.Tables["ChildTable"].ParentRelations.Add(relation);
        }

        private void Bind_to_data_grid()
        {
            binding_source_1 = new BindingSource();
            binding_source_2 = new BindingSource();
            binding_source_1.DataSource = data_set.Tables["ParentTable"];
            binding_source_2.DataSource = data_set.Tables["childTable"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_view_child.DataSource = binding_source_1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid_view_parent.DataSource = binding_source_2;
        }

        private void Tabler_Load(object sender, EventArgs e)
        {
            Create_data_tables();
        }
    }
}
