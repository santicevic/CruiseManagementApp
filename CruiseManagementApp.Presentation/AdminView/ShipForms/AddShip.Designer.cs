namespace CruiseManagementApp.Presentation.AdminView.ShipForms
{
    partial class AddShip
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
            this.yearOfAssemblyPicker = new System.Windows.Forms.DateTimePicker();
            this.shipNameTextbox = new System.Windows.Forms.TextBox();
            this.shipNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.yearOfAssemblyLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearOfAssemblyPicker
            // 
            this.yearOfAssemblyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearOfAssemblyPicker.Location = new System.Drawing.Point(113, 50);
            this.yearOfAssemblyPicker.Name = "yearOfAssemblyPicker";
            this.yearOfAssemblyPicker.ShowUpDown = true;
            this.yearOfAssemblyPicker.Size = new System.Drawing.Size(147, 20);
            this.yearOfAssemblyPicker.TabIndex = 0;
            // 
            // shipNameTextbox
            // 
            this.shipNameTextbox.Location = new System.Drawing.Point(113, 14);
            this.shipNameTextbox.Name = "shipNameTextbox";
            this.shipNameTextbox.Size = new System.Drawing.Size(147, 20);
            this.shipNameTextbox.TabIndex = 1;
            // 
            // shipNameLabel
            // 
            this.shipNameLabel.AutoSize = true;
            this.shipNameLabel.Location = new System.Drawing.Point(12, 17);
            this.shipNameLabel.Name = "shipNameLabel";
            this.shipNameLabel.Size = new System.Drawing.Size(24, 13);
            this.shipNameLabel.TabIndex = 2;
            this.shipNameLabel.Text = "Ime";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(185, 139);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // yearOfAssemblyLabel
            // 
            this.yearOfAssemblyLabel.AutoSize = true;
            this.yearOfAssemblyLabel.Location = new System.Drawing.Point(12, 56);
            this.yearOfAssemblyLabel.Name = "yearOfAssemblyLabel";
            this.yearOfAssemblyLabel.Size = new System.Drawing.Size(98, 13);
            this.yearOfAssemblyLabel.TabIndex = 4;
            this.yearOfAssemblyLabel.Text = "Godina proizvodnje";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(12, 83);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 5;
            // 
            // AddShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 174);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.yearOfAssemblyLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.shipNameLabel);
            this.Controls.Add(this.shipNameTextbox);
            this.Controls.Add(this.yearOfAssemblyPicker);
            this.Name = "AddShip";
            this.Text = "AddShip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker yearOfAssemblyPicker;
        private System.Windows.Forms.TextBox shipNameTextbox;
        private System.Windows.Forms.Label shipNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label yearOfAssemblyLabel;
        private System.Windows.Forms.Label warningLabel;
    }
}