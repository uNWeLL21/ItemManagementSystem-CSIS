
namespace Item_Management_System___CSIS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MSMenu = new System.Windows.Forms.MenuStrip();
            this.ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.EDIT = new System.Windows.Forms.ToolStripMenuItem();
            this.DELIVERY = new System.Windows.Forms.ToolStripMenuItem();
            this.EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.CBLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.MSMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(1);
            this.panelHeader.Size = new System.Drawing.Size(970, 35);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(935, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Parts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClose.Location = new System.Drawing.Point(936, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 33);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panelMenu.Controls.Add(this.MSMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panelMenu.Size = new System.Drawing.Size(970, 30);
            this.panelMenu.TabIndex = 1;
            // 
            // MSMenu
            // 
            this.MSMenu.AutoSize = false;
            this.MSMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.MSMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSMenu.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADD,
            this.EDIT,
            this.DELIVERY,
            this.EXIT});
            this.MSMenu.Location = new System.Drawing.Point(1, 0);
            this.MSMenu.Name = "MSMenu";
            this.MSMenu.Padding = new System.Windows.Forms.Padding(2);
            this.MSMenu.Size = new System.Drawing.Size(968, 29);
            this.MSMenu.TabIndex = 0;
            this.MSMenu.Text = "menuStrip1";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ADD.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(69, 25);
            this.ADD.Text = "&Add Parts";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // EDIT
            // 
            this.EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.EDIT.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.EDIT.ForeColor = System.Drawing.Color.White;
            this.EDIT.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(67, 25);
            this.EDIT.Text = "&Edit Parts";
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DELIVERY
            // 
            this.DELIVERY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.DELIVERY.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.DELIVERY.ForeColor = System.Drawing.Color.White;
            this.DELIVERY.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.DELIVERY.Name = "DELIVERY";
            this.DELIVERY.Size = new System.Drawing.Size(83, 25);
            this.DELIVERY.Text = "Add &Delivery";
            this.DELIVERY.Click += new System.EventHandler(this.DELIVERY_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.EXIT.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.EXIT.ForeColor = System.Drawing.Color.White;
            this.EXIT.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(38, 25);
            this.EXIT.Text = "E&xit";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.TBSearch);
            this.panel2.Controls.Add(this.CBLocation);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 385);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridViewParts);
            this.panel3.Location = new System.Drawing.Point(15, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 339);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AllowUserToResizeColumns = false;
            this.dataGridViewParts.AllowUserToResizeRows = false;
            this.dataGridViewParts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(185)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(185)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNumber,
            this.ColumnName,
            this.ColumnDescription,
            this.ColumnPrice,
            this.ColumnCategory,
            this.ColumnSupplier,
            this.ColumnStocks,
            this.ColumnLocation});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParts.EnableHeadersVisualStyles = false;
            this.dataGridViewParts.GridColor = System.Drawing.Color.Black;
            this.dataGridViewParts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewParts.RowHeadersVisible = false;
            this.dataGridViewParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParts.Size = new System.Drawing.Size(943, 339);
            this.dataGridViewParts.TabIndex = 4;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "PartID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNumber.HeaderText = "Number";
            this.ColumnNumber.MinimumWidth = 80;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 80;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 120;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 120;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.MinimumWidth = 150;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.MinimumWidth = 100;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCategory.HeaderText = "Category";
            this.ColumnCategory.MinimumWidth = 100;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            // 
            // ColumnSupplier
            // 
            this.ColumnSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSupplier.HeaderText = "Supplier";
            this.ColumnSupplier.MinimumWidth = 120;
            this.ColumnSupplier.Name = "ColumnSupplier";
            this.ColumnSupplier.ReadOnly = true;
            this.ColumnSupplier.Width = 120;
            // 
            // ColumnStocks
            // 
            this.ColumnStocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStocks.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnStocks.HeaderText = "Stocks";
            this.ColumnStocks.MinimumWidth = 100;
            this.ColumnStocks.Name = "ColumnStocks";
            this.ColumnStocks.ReadOnly = true;
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnLocation.HeaderText = "Location";
            this.ColumnLocation.MinimumWidth = 100;
            this.ColumnLocation.Name = "ColumnLocation";
            this.ColumnLocation.ReadOnly = true;
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSearch.BackColor = System.Drawing.Color.White;
            this.TBSearch.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBSearch.Location = new System.Drawing.Point(257, 9);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(701, 23);
            this.TBSearch.TabIndex = 2;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // CBLocation
            // 
            this.CBLocation.BackColor = System.Drawing.Color.White;
            this.CBLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLocation.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.CBLocation.FormattingEnabled = true;
            this.CBLocation.Items.AddRange(new object[] {
            "All Locations"});
            this.CBLocation.Location = new System.Drawing.Point(66, 9);
            this.CBLocation.Name = "CBLocation";
            this.CBLocation.Size = new System.Drawing.Size(185, 24);
            this.CBLocation.TabIndex = 1;
            this.CBLocation.SelectedIndexChanged += new System.EventHandler(this.CBLocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MSMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip MSMenu;
        private System.Windows.Forms.ToolStripMenuItem ADD;
        private System.Windows.Forms.ToolStripMenuItem EDIT;
        private System.Windows.Forms.ToolStripMenuItem DELIVERY;
        private System.Windows.Forms.ToolStripMenuItem EXIT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.ComboBox CBLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocation;
    }
}

