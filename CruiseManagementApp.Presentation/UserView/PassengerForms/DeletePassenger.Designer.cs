namespace CruiseManagementApp.Presentation.UserView.PassengerForms
{
    partial class DeletePassenger
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
            this.passengerSelectorCombobox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passengerSelectorCombobox
            // 
            this.passengerSelectorCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passengerSelectorCombobox.FormattingEnabled = true;
            this.passengerSelectorCombobox.Location = new System.Drawing.Point(12, 12);
            this.passengerSelectorCombobox.Name = "passengerSelectorCombobox";
            this.passengerSelectorCombobox.Size = new System.Drawing.Size(121, 21);
            this.passengerSelectorCombobox.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(58, 47);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Izbriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeletePassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 82);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.passengerSelectorCombobox);
            this.Name = "DeletePassenger";
            this.Text = "DeletePassenger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox passengerSelectorCombobox;
        private System.Windows.Forms.Button deleteButton;
    }
}