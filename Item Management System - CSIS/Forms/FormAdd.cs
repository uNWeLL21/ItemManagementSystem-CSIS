using Item_Management_System___CSIS.DB_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Item_Management_System___CSIS.Forms
{
    public partial class FormAdd : Form
    {
        #region"Variables"
        Database DB = new Database();
        public bool EDIT = false;
        public string PartID = "";
        private List<string> supName = new List<string>();
        private List<string> supID = new List<string>();
        private List<string> catName = new List<string>();
        private List<string> catID = new List<string>();
        #endregion

        public FormAdd()
        {
            InitializeComponent();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            GetData();
            if (EDIT)
            {
                loadData();
                BTNSave.Text = "Update";
            }
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.panel1.Controls)
            {
                if(control is TextBox text)
                {
                    if (text.Text == "") // validate if empty
                    {
                        MessageBox.Show($"Enter a {text.Name.Replace("TB", "").Replace("_", " ")}!");
                        text.Focus();
                        return;
                    }
                    else if (text.Tag.ToString() == "Number" && !IsDouble(text.Text)) // validate if numeric
                    {
                        MessageBox.Show($"Enter a valid {text.Name.Replace("TB", "").Replace("_", " ")}!");
                        text.Focus();
                        return;
                    }
                }

                if (control is ComboBox cb)
                {
                    if (cb.SelectedIndex == -1) // validate selection
                    {
                        MessageBox.Show($"Select a {cb.Name.Replace("CB", "")}!");
                        cb.DroppedDown = true;
                        return;
                    }
                }
            }

            string sqlADD = $"INSERT INTO `parts` (`PartName`, `PartNumber`, `Description`, `CategoryID`, `SupplierID`, `UnitPrice`," +
                             $"`QuantityInStock`, `MinimumQuantity`, `Location`, `DateAdded`, `DateModified`)" +
                             $"VALUE('{TBPart_Name.Text}', '{TBPart_Number.Text}', '{TBDesciption.Text}', '{DB.getNumber(CBCategory.Text, catName, catID)}', " +
                             $"'{DB.getNumber(CBSupplier.Text, supName, supID)}', '{TBPrice.Text}', '{TBStocks.Text}', '{TBStocks.Text}', '{CBLocation.Text}', " +
                             $"'{DateTime.Now.Date}','{DateTime.Now.Date}')";
            string sqlEDIT = $"UPDATE `parts`  SET `PartName` = '{TBPart_Name.Text}', `PartNumber`= '{TBPart_Number.Text}', `Description`= '{TBDesciption.Text}', " +
                            $"`CategoryID` = '{DB.getNumber(CBCategory.Text, catName, catID)}', `SupplierID` = '{DB.getNumber(CBSupplier.Text, supName, supID)}', " +
                            $"`UnitPrice` = '{TBPrice.Text}', `QuantityInStock`= '{TBStocks.Text}', `Location`= '{CBLocation.Text}', `DateModified` = '{DateTime.Now.Date}' " +
                            $" WHERE `PartID` = '{PartID}'";

            if (EDIT && DB.ExecuteQuery(sqlEDIT))
            {
                MessageBox.Show("Part details Successfully Updated!");
            }
            else if (!EDIT && DB.ExecuteQuery(sqlADD))
            {
                MessageBox.Show("Part details Successfully Added!");
            }
            else
            {
                MessageBox.Show("Unsuccessful Request!");
            }
            this.Dispose();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                "parts.QuantityInStock",
                "parts.Location",
                "categories.CategoryName",
                "suppliers.SupplierName",
            };

            List<string> filterAND = new List<string>()
            {
                $"{column[0]} = {PartID}"
            };

            DB.TableName = "parts";
            DB.Columns = column;
            DB.WhereAND = filterAND;
            DB.WhereOR = null;
            DB.Join = "INNER JOIN suppliers ON suppliers.SupplierID = parts.SupplierID " +
                "INNER JOIN categories ON categories.CategoryID = parts.CategoryID";
            DB.OrderBy = "";

            DB.OpenDB();
            DataTable product = new DataTable();
            product = DB.GetRows();
            foreach (DataRow row in product.Rows)
            {
                TBPart_Number.Text = row[1].ToString();
                TBPart_Name.Text = row[2].ToString();
                TBDesciption.Text = row[3].ToString();
                TBPrice.Text = row[4].ToString();
                TBStocks.Text = row[5].ToString();
                CBLocation.SelectedItem = row[6].ToString();
                CBCategory.SelectedItem = row[7].ToString();
                CBSupplier.SelectedItem = row[8].ToString();
            }
        }

        private void GetData()
        {
            List<string> column = new List<string>
            {
                "DISTINCT Location",
            };

            DB.OpenDB();
            DB.Columns = column;
            DB.WhereAND = null;
            DB.WhereOR = null;
            DB.Join = "";
            DB.OrderBy = "Location";

            // get distinct location
            DB.TableName = "parts";
            DataTable product = new DataTable();
            product = DB.GetRows();
            foreach (DataRow row in product.Rows)
            {
                CBLocation.Items.Add(row[0]);
            }

            // get all categories
            column.Clear();
            column.Add("CategoryID");
            column.Add("CategoryName");
            DB.Columns = column;
            DB.OrderBy = "CategoryName";

            DB.TableName = "categories";
            product = DB.GetRows();
            foreach (DataRow row in product.Rows)
            {
                CBCategory.Items.Add(row[1]);
                catID.Add(row[0].ToString());
                catName.Add(row[1].ToString());
            }

            // get all suppliers
            column.Clear();
            column.Add("SupplierID");
            column.Add("SupplierName");
            DB.Columns = column;
            DB.OrderBy = "SupplierName";

            DB.TableName = "suppliers";
            product = DB.GetRows();
            foreach (DataRow row in product.Rows)
            {
                CBSupplier.Items.Add(row[1]);
                supID.Add(row[0].ToString());
                supName.Add(row[1].ToString());
            }

            DB.CloseDB();
        }

        private bool IsDouble(string value)
        {
            return double.TryParse(value, out _);
        }

        #endregion

        private void TBPart_Name_TextChanged(object sender, EventArgs e)
        {
            if(!EDIT && DB.Unique(TBPart_Name.Text, "PartName", "parts"))
            {
                MessageBox.Show("Part is already exist!");
            }
        }

        private void TBPart_Number_TextChanged(object sender, EventArgs e)
        {
            if (!EDIT && DB.Unique(TBPart_Number.Text, "PartNumber", "parts"))
            {
                MessageBox.Show("Part Number is already exist!");
            }
        }
    }
}
