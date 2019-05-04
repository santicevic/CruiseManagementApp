namespace CruiseManagementApp.Presentation.AdminView.CabinForms
{
    partial class AddCabin
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
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.cabinNameTextbox = new System.Windows.Forms.TextBox();
            this.cabinNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.Location = new System.Drawing.Point(103, 50);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(141, 21);
            this.categoryCombobox.TabIndex = 1;
            // 
            // cabinNameTextbox
            // 
            this.cabinNameTextbox.Location = new System.Drawing.Point(104, 6);
            this.cabinNameTextbox.Name = "cabinNameTextbox";
            this.cabinNameTextbox.Size = new System.Drawing.Size(140, 20);
            this.cabinNameTextbox.TabIndex = 2;
            // 
            // cabinNameLabel
            // 
            this.cabinNameLabel.AutoSize = true;
            this.cabinNameLabel.Location = new System.Drawing.Point(12, 9);
            this.cabinNameLabel.Name = "cabinNameLabel";
            this.cabinNameLabel.Size = new System.Drawing.Size(34, 13);
            this.cabinNameLabel.TabIndex = 3;
            this.cabinNameLabel.Text = "Naziv";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(169, 170);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 53);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(54, 13);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Kategorija";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 101);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Naknada";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(12, 141);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 7;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(104, 98);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(140, 20);
            this.priceTextbox.TabIndex = 8;
            // 
            // AddCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 204);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cabinNameLabel);
            this.Controls.Add(this.cabinNameTextbox);
            this.Controls.Add(this.categoryCombobox);
            this.Name = "AddCabin";
            this.Text = "AddCabin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoryCombobox;
        private System.Windows.Forms.TextBox cabinNameTextbox;
        private System.Windows.Forms.Label cabinNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.TextBox priceTextbox;
    }
}