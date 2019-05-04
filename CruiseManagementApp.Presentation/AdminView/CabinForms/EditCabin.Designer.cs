namespace CruiseManagementApp.Presentation.AdminView.CabinForms
{
    partial class EditCabin
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
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cabinNameLabel = new System.Windows.Forms.Label();
            this.cabinNameTextbox = new System.Windows.Forms.TextBox();
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.cabinSelectCombobox = new System.Windows.Forms.ComboBox();
            this.editForm = new System.Windows.Forms.GroupBox();
            this.cabinSelectLabel = new System.Windows.Forms.Label();
            this.editForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(98, 110);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(140, 20);
            this.priceTextbox.TabIndex = 16;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(6, 153);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 15;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 113);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 13);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Naknada";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(6, 65);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(54, 13);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Kategorija";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(163, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cabinNameLabel
            // 
            this.cabinNameLabel.AutoSize = true;
            this.cabinNameLabel.Location = new System.Drawing.Point(6, 21);
            this.cabinNameLabel.Name = "cabinNameLabel";
            this.cabinNameLabel.Size = new System.Drawing.Size(34, 13);
            this.cabinNameLabel.TabIndex = 11;
            this.cabinNameLabel.Text = "Naziv";
            // 
            // cabinNameTextbox
            // 
            this.cabinNameTextbox.Location = new System.Drawing.Point(98, 18);
            this.cabinNameTextbox.Name = "cabinNameTextbox";
            this.cabinNameTextbox.Size = new System.Drawing.Size(140, 20);
            this.cabinNameTextbox.TabIndex = 10;
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.Location = new System.Drawing.Point(97, 62);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(141, 21);
            this.categoryCombobox.TabIndex = 9;
            // 
            // cabinSelectCombobox
            // 
            this.cabinSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cabinSelectCombobox.FormattingEnabled = true;
            this.cabinSelectCombobox.Location = new System.Drawing.Point(12, 25);
            this.cabinSelectCombobox.Name = "cabinSelectCombobox";
            this.cabinSelectCombobox.Size = new System.Drawing.Size(249, 21);
            this.cabinSelectCombobox.TabIndex = 17;
            this.cabinSelectCombobox.SelectionChangeCommitted += new System.EventHandler(this.OnCabinChange);
            // 
            // editForm
            // 
            this.editForm.Controls.Add(this.cabinNameLabel);
            this.editForm.Controls.Add(this.categoryCombobox);
            this.editForm.Controls.Add(this.priceTextbox);
            this.editForm.Controls.Add(this.cabinNameTextbox);
            this.editForm.Controls.Add(this.warningLabel);
            this.editForm.Controls.Add(this.saveButton);
            this.editForm.Controls.Add(this.priceLabel);
            this.editForm.Controls.Add(this.categoryLabel);
            this.editForm.Location = new System.Drawing.Point(12, 52);
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(249, 213);
            this.editForm.TabIndex = 18;
            this.editForm.TabStop = false;
            // 
            // cabinSelectLabel
            // 
            this.cabinSelectLabel.AutoSize = true;
            this.cabinSelectLabel.Location = new System.Drawing.Point(9, 9);
            this.cabinSelectLabel.Name = "cabinSelectLabel";
            this.cabinSelectLabel.Size = new System.Drawing.Size(73, 13);
            this.cabinSelectLabel.TabIndex = 19;
            this.cabinSelectLabel.Text = "Odabir kabine";
            // 
            // EditCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 281);
            this.Controls.Add(this.cabinSelectLabel);
            this.Controls.Add(this.editForm);
            this.Controls.Add(this.cabinSelectCombobox);
            this.Name = "EditCabin";
            this.Text = "EditCabin";
            this.editForm.ResumeLayout(false);
            this.editForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label cabinNameLabel;
        private System.Windows.Forms.TextBox cabinNameTextbox;
        private System.Windows.Forms.ComboBox categoryCombobox;
        private System.Windows.Forms.ComboBox cabinSelectCombobox;
        private System.Windows.Forms.GroupBox editForm;
        private System.Windows.Forms.Label cabinSelectLabel;
    }
}