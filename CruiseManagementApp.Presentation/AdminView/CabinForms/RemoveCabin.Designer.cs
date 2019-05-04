namespace CruiseManagementApp.Presentation.AdminView.CabinForms
{
    partial class RemoveCabin
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
            this.cabinSelectLabel = new System.Windows.Forms.Label();
            this.cabinSelectCombobox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cabinSelectLabel
            // 
            this.cabinSelectLabel.AutoSize = true;
            this.cabinSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.cabinSelectLabel.Name = "cabinSelectLabel";
            this.cabinSelectLabel.Size = new System.Drawing.Size(73, 13);
            this.cabinSelectLabel.TabIndex = 21;
            this.cabinSelectLabel.Text = "Odabir kabine";
            // 
            // cabinSelectCombobox
            // 
            this.cabinSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cabinSelectCombobox.FormattingEnabled = true;
            this.cabinSelectCombobox.Location = new System.Drawing.Point(15, 25);
            this.cabinSelectCombobox.Name = "cabinSelectCombobox";
            this.cabinSelectCombobox.Size = new System.Drawing.Size(167, 21);
            this.cabinSelectCombobox.TabIndex = 20;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(107, 70);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // RemoveCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 108);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cabinSelectLabel);
            this.Controls.Add(this.cabinSelectCombobox);
            this.Name = "RemoveCabin";
            this.Text = "RemoveCabin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cabinSelectLabel;
        private System.Windows.Forms.ComboBox cabinSelectCombobox;
        private System.Windows.Forms.Button deleteButton;
    }
}