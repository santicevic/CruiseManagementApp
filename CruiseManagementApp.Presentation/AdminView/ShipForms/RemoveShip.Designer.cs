namespace CruiseManagementApp.Presentation.AdminView.ShipForms
{
    partial class RemoveShip
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.shipSelectLabel = new System.Windows.Forms.Label();
            this.shipSelectCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(104, 69);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // shipSelectLabel
            // 
            this.shipSelectLabel.AutoSize = true;
            this.shipSelectLabel.Location = new System.Drawing.Point(9, 8);
            this.shipSelectLabel.Name = "shipSelectLabel";
            this.shipSelectLabel.Size = new System.Drawing.Size(68, 13);
            this.shipSelectLabel.TabIndex = 27;
            this.shipSelectLabel.Text = "Odabir broda";
            // 
            // shipSelectCombobox
            // 
            this.shipSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipSelectCombobox.FormattingEnabled = true;
            this.shipSelectCombobox.Location = new System.Drawing.Point(12, 24);
            this.shipSelectCombobox.Name = "shipSelectCombobox";
            this.shipSelectCombobox.Size = new System.Drawing.Size(167, 21);
            this.shipSelectCombobox.TabIndex = 26;
            // 
            // RemoveShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 106);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.shipSelectLabel);
            this.Controls.Add(this.shipSelectCombobox);
            this.Name = "RemoveShip";
            this.Text = "RemoveShip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label shipSelectLabel;
        private System.Windows.Forms.ComboBox shipSelectCombobox;
    }
}