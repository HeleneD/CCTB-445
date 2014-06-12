namespace DesktopApp
{
    partial class ViewShippers
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
            this.btnLookupShipper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboShippers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.AddShipper = new System.Windows.Forms.Button();
            this.UpdateShipper = new System.Windows.Forms.Button();
            this.DeleteShipper = new System.Windows.Forms.Button();
            this.ClearShipper = new System.Windows.Forms.Button();
            this.ShipperId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLookupShipper
            // 
            this.btnLookupShipper.Location = new System.Drawing.Point(235, 12);
            this.btnLookupShipper.Name = "btnLookupShipper";
            this.btnLookupShipper.Size = new System.Drawing.Size(159, 23);
            this.btnLookupShipper.TabIndex = 0;
            this.btnLookupShipper.Text = "Lookup Shipper";
            this.btnLookupShipper.UseVisualStyleBackColor = true;
            this.btnLookupShipper.Click += new System.EventHandler(this.btnLookupShipper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shippers";
            // 
            // cboShippers
            // 
            this.cboShippers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippers.FormattingEnabled = true;
            this.cboShippers.Location = new System.Drawing.Point(101, 13);
            this.cboShippers.Name = "cboShippers";
            this.cboShippers.Size = new System.Drawing.Size(121, 21);
            this.cboShippers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shipper ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(101, 85);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(100, 20);
            this.CompanyName.TabIndex = 7;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(101, 125);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 8;
            // 
            // AddShipper
            // 
            this.AddShipper.Location = new System.Drawing.Point(19, 176);
            this.AddShipper.Name = "AddShipper";
            this.AddShipper.Size = new System.Drawing.Size(75, 23);
            this.AddShipper.TabIndex = 9;
            this.AddShipper.Text = "Add";
            this.AddShipper.UseVisualStyleBackColor = true;
            this.AddShipper.Click += new System.EventHandler(this.Add_Click);
            // 
            // UpdateShipper
            // 
            this.UpdateShipper.Location = new System.Drawing.Point(109, 176);
            this.UpdateShipper.Name = "UpdateShipper";
            this.UpdateShipper.Size = new System.Drawing.Size(75, 23);
            this.UpdateShipper.TabIndex = 10;
            this.UpdateShipper.Text = "Update";
            this.UpdateShipper.UseVisualStyleBackColor = true;
            this.UpdateShipper.Click += new System.EventHandler(this.UpdateShipper_Click);
            // 
            // DeleteShipper
            // 
            this.DeleteShipper.Location = new System.Drawing.Point(199, 176);
            this.DeleteShipper.Name = "DeleteShipper";
            this.DeleteShipper.Size = new System.Drawing.Size(75, 23);
            this.DeleteShipper.TabIndex = 11;
            this.DeleteShipper.Text = "Delete";
            this.DeleteShipper.UseVisualStyleBackColor = true;
            this.DeleteShipper.Click += new System.EventHandler(this.DeleteShipper_Click);
            // 
            // ClearShipper
            // 
            this.ClearShipper.Location = new System.Drawing.Point(289, 176);
            this.ClearShipper.Name = "ClearShipper";
            this.ClearShipper.Size = new System.Drawing.Size(75, 23);
            this.ClearShipper.TabIndex = 12;
            this.ClearShipper.Text = "Clear";
            this.ClearShipper.UseVisualStyleBackColor = true;
            this.ClearShipper.Click += new System.EventHandler(this.ClearShipper_Click);
            // 
            // ShipperId
            // 
            this.ShipperId.AutoSize = true;
            this.ShipperId.Location = new System.Drawing.Point(101, 52);
            this.ShipperId.Name = "ShipperId";
            this.ShipperId.Size = new System.Drawing.Size(52, 13);
            this.ShipperId.TabIndex = 13;
            this.ShipperId.Text = "shipper-id";
            // 
            // ViewShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.ShipperId);
            this.Controls.Add(this.ClearShipper);
            this.Controls.Add(this.DeleteShipper);
            this.Controls.Add(this.UpdateShipper);
            this.Controls.Add(this.AddShipper);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboShippers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLookupShipper);
            this.Name = "ViewShippers";
            this.Text = "View/Edit Shippers";
            this.Load += new System.EventHandler(this.ViewShippers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLookupShipper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboShippers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button AddShipper;
        private System.Windows.Forms.Button UpdateShipper;
        private System.Windows.Forms.Button DeleteShipper;
        private System.Windows.Forms.Button ClearShipper;
        private System.Windows.Forms.Label ShipperId;
    }
}