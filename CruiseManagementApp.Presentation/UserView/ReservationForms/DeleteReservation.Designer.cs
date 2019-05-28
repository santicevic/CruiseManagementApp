namespace CruiseManagementApp.Presentation.UserView.ReservationForms
{
    partial class DeleteReservation
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
            this.reservationSelectorCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(58, 47);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Izbriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // reservationSelectorCombobox
            // 
            this.reservationSelectorCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reservationSelectorCombobox.FormattingEnabled = true;
            this.reservationSelectorCombobox.Location = new System.Drawing.Point(12, 12);
            this.reservationSelectorCombobox.Name = "reservationSelectorCombobox";
            this.reservationSelectorCombobox.Size = new System.Drawing.Size(121, 21);
            this.reservationSelectorCombobox.TabIndex = 2;
            // 
            // DeleteReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 78);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.reservationSelectorCombobox);
            this.Name = "DeleteReservation";
            this.Text = "RemoveReservation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox reservationSelectorCombobox;
    }
}