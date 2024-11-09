
namespace Item_Management_System___CSIS.Forms
{
    partial class FormAdd
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.TBPart_Number = new System.Windows.Forms.TextBox();
            this.TBPart_Name = new System.Windows.Forms.TextBox();
            this.TBDesciption = new System.Windows.Forms.TextBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.TBStocks = new System.Windows.Forms.TextBox();
            this.CBLocation = new System.Windows.Forms.ComboBox();
            this.CBSupplier = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(578, 35);
            this.panelHeader.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(543, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Parts";
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
            this.buttonClose.Location = new System.Drawing.Point(544, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 33);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TBPart_Number
            // 
            this.TBPart_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPart_Number.BackColor = System.Drawing.Color.White;
            this.TBPart_Number.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBPart_Number.Location = new System.Drawing.Point(111, 29);
            this.TBPart_Number.Name = "TBPart_Number";
            this.TBPart_Number.Size = new System.Drawing.Size(189, 23);
            this.TBPart_Number.TabIndex = 4;
            this.TBPart_Number.Tag = "String";
            this.TBPart_Number.TextChanged += new System.EventHandler(this.TBPart_Number_TextChanged);
            // 
            // TBPart_Name
            // 
            this.TBPart_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPart_Name.BackColor = System.Drawing.Color.White;
            this.TBPart_Name.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBPart_Name.Location = new System.Drawing.Point(111, 58);
            this.TBPart_Name.Name = "TBPart_Name";
            this.TBPart_Name.Size = new System.Drawing.Size(427, 23);
            this.TBPart_Name.TabIndex = 6;
            this.TBPart_Name.Tag = "String";
            this.TBPart_Name.TextChanged += new System.EventHandler(this.TBPart_Name_TextChanged);
            // 
            // TBDesciption
            // 
            this.TBDesciption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDesciption.BackColor = System.Drawing.Color.White;
            this.TBDesciption.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBDesciption.Location = new System.Drawing.Point(111, 87);
            this.TBDesciption.Name = "TBDesciption";
            this.TBDesciption.Size = new System.Drawing.Size(427, 23);
            this.TBDesciption.TabIndex = 8;
            this.TBDesciption.Tag = "String";
            // 
            // TBPrice
            // 
            this.TBPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPrice.BackColor = System.Drawing.Color.White;
            this.TBPrice.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBPrice.Location = new System.Drawing.Point(111, 116);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(132, 23);
            this.TBPrice.TabIndex = 10;
            this.TBPrice.Tag = "Number";
            // 
            // CBCategory
            // 
            this.CBCategory.BackColor = System.Drawing.Color.White;
            this.CBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategory.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(111, 145);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(180, 24);
            this.CBCategory.TabIndex = 15;
            // 
            // TBStocks
            // 
            this.TBStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBStocks.BackColor = System.Drawing.Color.White;
            this.TBStocks.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBStocks.Location = new System.Drawing.Point(109, 175);
            this.TBStocks.Name = "TBStocks";
            this.TBStocks.Size = new System.Drawing.Size(134, 23);
            this.TBStocks.TabIndex = 14;
            this.TBStocks.Tag = "Number";
            // 
            // CBLocation
            // 
            this.CBLocation.BackColor = System.Drawing.Color.White;
            this.CBLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLocation.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.CBLocation.FormattingEnabled = true;
            this.CBLocation.Location = new System.Drawing.Point(358, 116);
            this.CBLocation.Name = "CBLocation";
            this.CBLocation.Size = new System.Drawing.Size(180, 24);
            this.CBLocation.TabIndex = 17;
            // 
            // CBSupplier
            // 
            this.CBSupplier.BackColor = System.Drawing.Color.White;
            this.CBSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSupplier.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.CBSupplier.FormattingEnabled = true;
            this.CBSupplier.Location = new System.Drawing.Point(358, 146);
            this.CBSupplier.Name = "CBSupplier";
            this.CBSupplier.Size = new System.Drawing.Size(180, 24);
            this.CBSupplier.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TBPart_Number);
            this.panel1.Controls.Add(this.TBPart_Name);
            this.panel1.Controls.Add(this.TBDesciption);
            this.panel1.Controls.Add(this.TBPrice);
            this.panel1.Controls.Add(this.CBCategory);
            this.panel1.Controls.Add(this.TBStocks);
            this.panel1.Controls.Add(this.CBLocation);
            this.panel1.Controls.Add(this.CBSupplier);
            this.panel1.Controls.Add(this.BTNCancel);
            this.panel1.Controls.Add(this.BTNSave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 282);
            this.panel1.TabIndex = 2;
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.Color.White;
            this.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BTNCancel.FlatAppearance.BorderSize = 2;
            this.BTNCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancel.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.BTNCancel.Location = new System.Drawing.Point(352, 217);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(90, 30);
            this.BTNCancel.TabIndex = 21;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = false;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.BackColor = System.Drawing.Color.White;
            this.BTNSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BTNSave.FlatAppearance.BorderSize = 2;
            this.BTNSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(73)))));
            this.BTNSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(73)))));
            this.BTNSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSave.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.BTNSave.Location = new System.Drawing.Point(448, 217);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(90, 30);
            this.BTNSave.TabIndex = 20;
            this.BTNSave.Text = "Save";
            this.BTNSave.UseVisualStyleBackColor = false;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label9.Location = new System.Drawing.Point(299, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Supplier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label8.Location = new System.Drawing.Point(299, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label5.Location = new System.Drawing.Point(34, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stocks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label6.Location = new System.Drawing.Point(34, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label7.Location = new System.Drawing.Point(34, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Desciption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Part Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Part Number";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPart";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBStocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBDesciption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPart_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPart_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.ComboBox CBSupplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNSave;
    }
}