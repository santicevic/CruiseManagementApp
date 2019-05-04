namespace CruiseManagementApp.Presentation.AdminView.ShipForms
{
    partial class EditShip
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
            this.editForm = new System.Windows.Forms.GroupBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.yearOfAssemblyLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.shipNameLabel = new System.Windows.Forms.Label();
            this.shipNameTextbox = new System.Windows.Forms.TextBox();
            this.yearOfAssemblyPicker = new System.Windows.Forms.DateTimePicker();
            this.shipSelectCombobox = new System.Windows.Forms.ComboBox();
            this.shipSelectLabel = new System.Windows.Forms.Label();
            this.editForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // editForm
            // 
            this.editForm.Controls.Add(this.warningLabel);
            this.editForm.Controls.Add(this.yearOfAssemblyLabel);
            this.editForm.Controls.Add(this.saveButton);
            this.editForm.Controls.Add(this.shipNameLabel);
            this.editForm.Controls.Add(this.shipNameTextbox);
            this.editForm.Controls.Add(this.yearOfAssemblyPicker);
            this.editForm.Location = new System.Drawing.Point(12, 72);
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(270, 181);
            this.editForm.TabIndex = 0;
            this.editForm.TabStop = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(9, 88);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 11;
            // 
            // yearOfAssemblyLabel
            // 
            this.yearOfAssemblyLabel.AutoSize = true;
            this.yearOfAssemblyLabel.Location = new System.Drawing.Point(9, 61);
            this.yearOfAssemblyLabel.Name = "yearOfAssemblyLabel";
            this.yearOfAssemblyLabel.Size = new System.Drawing.Size(98, 13);
            this.yearOfAssemblyLabel.TabIndex = 10;
            this.yearOfAssemblyLabel.Text = "Godina proizvodnje";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(182, 144);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // shipNameLabel
            // 
            this.shipNameLabel.AutoSize = true;
            this.shipNameLabel.Location = new System.Drawing.Point(9, 22);
            this.shipNameLabel.Name = "shipNameLabel";
            this.shipNameLabel.Size = new System.Drawing.Size(24, 13);
            this.shipNameLabel.TabIndex = 8;
            this.shipNameLabel.Text = "Ime";
            // 
            // shipNameTextbox
            // 
            this.shipNameTextbox.Location = new System.Drawing.Point(110, 19);
            this.shipNameTextbox.Name = "shipNameTextbox";
            this.shipNameTextbox.Size = new System.Drawing.Size(147, 20);
            this.shipNameTextbox.TabIndex = 7;
            // 
            // yearOfAssemblyPicker
            // 
            this.yearOfAssemblyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearOfAssemblyPicker.Location = new System.Drawing.Point(110, 55);
            this.yearOfAssemblyPicker.Name = "yearOfAssemblyPicker";
            this.yearOfAssemblyPicker.ShowUpDown = true;
            this.yearOfAssemblyPicker.Size = new System.Drawing.Size(147, 20);
            this.yearOfAssemblyPicker.TabIndex = 6;
            // 
            // shipSelectCombobox
            // 
            this.shipSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipSelectCombobox.FormattingEnabled = true;
            this.shipSelectCombobox.Location = new System.Drawing.Point(12, 45);
            this.shipSelectCombobox.Name = "shipSelectCombobox";
            this.shipSelectCombobox.Size = new System.Drawing.Size(270, 21);
            this.shipSelectCombobox.TabIndex = 12;
            this.shipSelectCombobox.SelectionChangeCommitted += new System.EventHandler(this.OnShipSelectChange);
            // 
            // shipSelectLabel
            // 
            this.shipSelectLabel.AutoSize = true;
            this.shipSelectLabel.Location = new System.Drawing.Point(9, 20);
            this.shipSelectLabel.Name = "shipSelectLabel";
            this.shipSelectLabel.Size = new System.Drawing.Size(29, 13);
            this.shipSelectLabel.TabIndex = 13;
            this.shipSelectLabel.Text = "Brod";
            // 
            // EditShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 267);
            this.Controls.Add(this.shipSelectLabel);
            this.Controls.Add(this.shipSelectCombobox);
            this.Controls.Add(this.editForm);
            this.Name = "EditShip";
            this.Text = "EditShip";
            this.editForm.ResumeLayout(false);
            this.editForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox editForm;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label yearOfAssemblyLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label shipNameLabel;
        private System.Windows.Forms.TextBox shipNameTextbox;
        private System.Windows.Forms.DateTimePicker yearOfAssemblyPicker;
        private System.Windows.Forms.ComboBox shipSelectCombobox;
        private System.Windows.Forms.Label shipSelectLabel;
    }
}