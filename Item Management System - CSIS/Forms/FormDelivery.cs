using Item_Management_System___CSIS.DB_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item_Management_System___CSIS.Forms
{
    public partial class FormDelivery : Form
    {
        #region"Variables"
        Database DB = new Database();
        private List<string> supName = new List<string>();
        private List<string> supID = new List<string>();
        private double stocks = 0;
        public string PartID = "";
        #endregion

        public FormDelivery()
        {
            InitializeComponent();
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {
            TBDate.Text = DateTime.Now.ToString("yyyy-dd-MM");
            TBPart_ID.Text = PartID;
            GetData();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            // validate input
            foreach (Control control in this.panel1.Controls)
            {
                if (control is TextBox text)
                {
                    if (text.Text == "") // validate if empty
                    {
                        if(text.Tag.ToString() == "WHO")
                        {
                            MessageBox.Show($"Enter the {text.Name.Replace("TB", "").Replace("_", " ")}!");
                            text.Focus();
                            return;
                        }
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
                    else if (text.Tag.ToString() == "Date" && !IsValidDate(text.Text)) // validate if numeric
                    {
                        MessageBox.Show($"Enter a valid date!");
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

            // calculate total stock
            stocks += double.Parse(TBQuantity.Text);

            // generate sql script
            string sqlADD = $"INSERT INTO `deliveries` (`PartsID`, `SupplierID`, `DeliveryDate`, `DeliveredBy`, `ReceivedBy`, `Notes`,`SotcksDelivered`, `UserID`)" +
                             $"VALUE('{PartID}', '{DB.getNumber(CBSupplier.Text, supName, supID)}', '{TBDate.Text}', '{TBDeliver_Name.Text}', " +
                             $"'{TBReceiver_Name.Text}', '{TBNote.Text}', '{TBQuantity.Text}', '{UserInfo.Instance.UserID}')";
            string sqlEDIT = $"UPDATE `parts`  SET `QuantityInStock` = {stocks}" +
                            $" WHERE `PartID` = '{PartID}'";

            // execute query
            if (DB.ExecuteQuery(sqlADD) && DB.ExecuteQuery(sqlEDIT))
            {
                MessageBox.Show("Delivery Successfully Recorded!");
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

        private void GetStock()
        {
            List<string> column = new List<string>()
            {
                "QuantityInStock"
            }; 
            List<string> filterAND = new List<string>()
            {
                $"PartID = {PartID}"
            };
            DB.OpenDB();
            DB.Columns = column;
            DB.WhereAND = filterAND;
            DB.WhereOR = null;
            DB.Join = "";
            DB.Columns = column;
            DB.OrderBy = "";

            DB.TableName = "parts";
            DataTable product = DB.GetRows();
            foreach (DataRow row in product.Rows)
            {
                stocks = double.Parse(row[0].ToString());
            }
            DB.CloseDB();
        }

        private void GetData()
        {
            List<string> column = new List<string>();
            column.Add("SupplierID");
            column.Add("SupplierName");
            DB.OpenDB();
            DB.Columns = column;
            DB.WhereAND = null;
            DB.WhereOR = null;
            DB.Join = "";
            DB.Columns = column;
            DB.OrderBy = "SupplierName";

            DB.TableName = "suppliers";
            DataTable product = DB.GetRows();
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

        private bool IsValidDate(string value)
        {
            return DateTime.TryParse(value, out _);
        }

        #endregion

        private void TBPart_ID_TextChanged(object sender, EventArgs e)
        {
            GetData();
            GetStock();
        }
    }
}
