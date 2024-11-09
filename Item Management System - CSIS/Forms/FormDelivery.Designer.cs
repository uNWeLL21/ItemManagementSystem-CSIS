
namespace Item_Management_System___CSIS.Forms
{
    partial class FormDelivery
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
            this.TBPart_ID = new System.Windows.Forms.TextBox();
            this.TBDeliver_Name = new System.Windows.Forms.TextBox();
            this.TBNote = new System.Windows.Forms.TextBox();
            this.TBDate = new System.Windows.Forms.TextBox();
            this.CBSupplier = new System.Windows.Forms.ComboBox();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBReceiver_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBPart_ID
            // 
            this.TBPart_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPart_ID.BackColor = System.Drawing.Color.White;
            this.TBPart_ID.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBPart_ID.Location = new System.Drawing.Point(111, 29);
            this.TBPart_ID.Name = "TBPart_ID";
            this.TBPart_ID.ReadOnly = true;
            this.TBPart_ID.Size = new System.Drawing.Size(189, 23);
            this.TBPart_ID.TabIndex = 4;
            this.TBPart_ID.Tag = "String";
            this.TBPart_ID.TextChanged += new System.EventHandler(this.TBPart_ID_TextChanged);
            // 
            // TBDeliver_Name
            // 
            this.TBDeliver_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDeliver_Name.BackColor = System.Drawing.Color.White;
            this.TBDeliver_Name.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBDeliver_Name.Location = new System.Drawing.Point(111, 87);
            this.TBDeliver_Name.Name = "TBDeliver_Name";
            this.TBDeliver_Name.Size = new System.Drawing.Size(293, 23);
            this.TBDeliver_Name.TabIndex = 8;
            this.TBDeliver_Name.Tag = "WHO";
            // 
            // TBNote
            // 
            this.TBNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBNote.BackColor = System.Drawing.Color.White;
            this.TBNote.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBNote.Location = new System.Drawing.Point(111, 116);
            this.TBNote.Multiline = true;
            this.TBNote.Name = "TBNote";
            this.TBNote.Size = new System.Drawing.Size(427, 58);
            this.TBNote.TabIndex = 10;
            this.TBNote.Tag = "String";
            // 
            // TBDate
            // 
            this.TBDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDate.BackColor = System.Drawing.Color.White;
            this.TBDate.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBDate.Location = new System.Drawing.Point(410, 29);
            this.TBDate.Name = "TBDate";
            this.TBDate.Size = new System.Drawing.Size(134, 23);
            this.TBDate.TabIndex = 14;
            this.TBDate.Tag = "Date";
            // 
            // CBSupplier
            // 
            this.CBSupplier.BackColor = System.Drawing.Color.White;
            this.CBSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSupplier.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.CBSupplier.FormattingEnabled = true;
            this.CBSupplier.Location = new System.Drawing.Point(111, 58);
            this.CBSupplier.Name = "CBSupplier";
            this.CBSupplier.Size = new System.Drawing.Size(189, 24);
            this.CBSupplier.TabIndex = 19;
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
            this.BTNCancel.Location = new System.Drawing.Point(352, 229);
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
            this.BTNSave.Location = new System.Drawing.Point(448, 229);
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
            this.label9.Location = new System.Drawing.Point(57, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label5.Location = new System.Drawing.Point(374, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label7.Location = new System.Drawing.Point(75, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label4.Location = new System.Drawing.Point(36, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delivered by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label2.Location = new System.Drawing.Point(63, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Part ID";
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
            this.label1.Text = "Add Part Delivery";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TBReceiver_Name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBQuantity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TBPart_ID);
            this.panel1.Controls.Add(this.TBDeliver_Name);
            this.panel1.Controls.Add(this.TBNote);
            this.panel1.Controls.Add(this.TBDate);
            this.panel1.Controls.Add(this.CBSupplier);
            this.panel1.Controls.Add(this.BTNCancel);
            this.panel1.Controls.Add(this.BTNSave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 291);
            this.panel1.TabIndex = 4;
            // 
            // TBReceiver_Name
            // 
            this.TBReceiver_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBReceiver_Name.BackColor = System.Drawing.Color.White;
            this.TBReceiver_Name.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBReceiver_Name.Location = new System.Drawing.Point(111, 180);
            this.TBReceiver_Name.Name = "TBReceiver_Name";
            this.TBReceiver_Name.Size = new System.Drawing.Size(293, 23);
            this.TBReceiver_Name.TabIndex = 25;
            this.TBReceiver_Name.Tag = "WHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label3.Location = new System.Drawing.Point(36, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Received by";
            // 
            // TBQuantity
            // 
            this.TBQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBQuantity.BackColor = System.Drawing.Color.White;
            this.TBQuantity.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.TBQuantity.Location = new System.Drawing.Point(410, 58);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(134, 23);
            this.TBQuantity.TabIndex = 23;
            this.TBQuantity.Tag = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label6.Location = new System.Drawing.Point(357, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quantity";
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
            this.panelHeader.TabIndex = 3;
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDelivery";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBPart_ID;
        private System.Windows.Forms.TextBox TBDeliver_Name;
        private System.Windows.Forms.TextBox TBNote;
        private System.Windows.Forms.TextBox TBDate;
        private System.Windows.Forms.ComboBox CBSupplier;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox TBReceiver_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Label label6;
    }
}