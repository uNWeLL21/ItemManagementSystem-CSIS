using Item_Management_System___CSIS.DB_Connection;
using Item_Management_System___CSIS.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Item_Management_System___CSIS
{
    public partial class Form1 : Form
    {
        #region"Variables"
        Database DB = new Database();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            GetLocation();
        }

        #region"Method"

        private void loadData()
        {
            List<string> column = new List<string>
            {
                "parts.PartID",
                "parts.PartNumber",
                "parts.PartName",
                "parts.Description",
                "parts.UnitPrice",
                "categories.CategoryName",
                "suppliers.SupplierName",
                "parts.QuantityInStock",
                "parts.Location",
                "parts.MinimumQuantity",
            };

            List<string> filterAND = new List<string>();
            List<string> filterOR = new List<string>();

            if (CBLocation.SelectedIndex > 0)
            {
                filterAND.Add($"{column[8]} = '{CBLocation.Text}' ");
            }
            if(TBSearch.Text != string.Empty)
            {
                filterOR.Add($"{column[1]} LIKE '%{TBSearch.Text.Trim()}%' ");
                filterOR.Add($"{column[2]} LIKE '%{TBSearch.Text.Trim()}%' ");
                filterOR.Add($"{column[3]} LIKE '%{TBSearch.Text.Trim()}%' ");
                filterOR.Add($"{column[5]} LIKE '%{TBSearch.Text.Trim()}%' ");
                filterOR.Add($"{column[6]} LIKE '%{TBSearch.Text.Trim()}%' ");
            }

            DB.TableName = "parts";
            DB.Columns = column;
            DB.WhereAND = filterAND;
            DB.WhereOR = filterOR;
            DB.Join = "INNER JOIN suppliers ON suppliers.SupplierID = parts.SupplierID " +
                "INNER JOIN categories ON categories.CategoryID = parts.CategoryID";
            DB.OrderBy = "parts.PartName ASC";

            DB.OpenDB();
            DataTable product = new DataTable();
            product = DB.GetRows();
            dataGridViewParts.Rows.Clear();
            foreach (DataRow row in product.Rows)
            {
                dataGridViewParts.Rows.Add(row[0], row[1], row[2], row[3], double.Parse(row[4].ToString()).ToString("N2"), row[5], row[6], row[7], row[8]);
                if(double.Parse(row[7].ToString()) <= double.Parse(row[9].ToString()))
                {
                    dataGridViewParts.Rows[dataGridViewParts.RowCount - 1].DefaultCellStyle.BackColor = Color.FromArgb(254, 208, 73);
                }
            }
            DB.CloseDB();
        }

        private void GetLocation()
        {
            List<string> column = new List<string>
            {
                "DISTINCT Location",
            };
            //SELECT DISTINCT Country FROM Customers;

            DB.TableName = "parts";
            DB.Columns = column;
            DB.WhereAND = null;
            DB.WhereOR = null;
            DB.Join = "";
            DB.OrderBy = "";

            DB.OpenDB();
            DataTable product = new DataTable();
            product = DB.GetRows();
            foreach (DataRow row in product.Rows)
            {
                CBLocation.Items.Add(row[0]);
            }
            DB.CloseDB();
        }

        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            FormAdd addPart = new FormAdd();
            addPart.ShowDialog();
            loadData();
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            FormAdd addPart = new FormAdd();
            addPart.EDIT = true;
            addPart.PartID = dataGridViewParts.CurrentRow.Cells[0].Value.ToString();
            addPart.ShowDialog();
            loadData();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DELIVERY_Click(object sender, EventArgs e)
        {
            FormDelivery delivery = new FormDelivery();
            delivery.PartID = dataGridViewParts.CurrentRow.Cells[0].Value.ToString();
            delivery.ShowDialog();
            loadData();
        }
    }
}
