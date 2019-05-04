namespace CruiseManagementApp.Presentation.AdminView.CruiseForms
{
    partial class RemoveCruise
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
            this.cruiseSelectLabel = new System.Windows.Forms.Label();
            this.cruiseSelectCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(108, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cruiseSelectLabel
            // 
            this.cruiseSelectLabel.AutoSize = true;
            this.cruiseSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.cruiseSelectLabel.Name = "cruiseSelectLabel";
            this.cruiseSelectLabel.Size = new System.Drawing.Size(87, 13);
            this.cruiseSelectLabel.TabIndex = 24;
            this.cruiseSelectLabel.Text = "Odabir krstarenja";
            // 
            // cruiseSelectCombobox
            // 
            this.cruiseSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cruiseSelectCombobox.FormattingEnabled = true;
            this.cruiseSelectCombobox.Location = new System.Drawing.Point(12, 25);
            this.cruiseSelectCombobox.Name = "cruiseSelectCombobox";
            this.cruiseSelectCombobox.Size = new System.Drawing.Size(167, 21);
            this.cruiseSelectCombobox.TabIndex = 23;
            // 
            // RemoveCruise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 86);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cruiseSelectLabel);
            this.Controls.Add(this.cruiseSelectCombobox);
            this.Name = "RemoveCruise";
            this.Text = "RemoveCruise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label cruiseSelectLabel;
        private System.Windows.Forms.ComboBox cruiseSelectCombobox;
    }
}