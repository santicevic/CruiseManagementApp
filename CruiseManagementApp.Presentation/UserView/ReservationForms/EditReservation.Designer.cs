namespace CruiseManagementApp.Presentation.UserView.ReservationForms
{
    partial class EditReservation
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cabinSelectLabel = new System.Windows.Forms.Label();
            this.cruiseSelectLabel = new System.Windows.Forms.Label();
            this.passengerSelectLabel = new System.Windows.Forms.Label();
            this.cabinSelectCombobox = new System.Windows.Forms.ComboBox();
            this.cruiseSelectCombobox = new System.Windows.Forms.ComboBox();
            this.passengerSelectCombobox = new System.Windows.Forms.ComboBox();
            this.editForm = new System.Windows.Forms.GroupBox();
            this.reservationSelectCombobox = new System.Windows.Forms.ComboBox();
            this.reservationPickLabel = new System.Windows.Forms.Label();
            this.editForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 146);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 13);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Cijena:";
            // 
            // priceTextbox
            // 
            this.priceTextbox.Enabled = false;
            this.priceTextbox.Location = new System.Drawing.Point(74, 143);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(57, 20);
            this.priceTextbox.TabIndex = 16;
            this.priceTextbox.Text = "0";
            this.priceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(58, 174);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // cabinSelectLabel
            // 
            this.cabinSelectLabel.AutoSize = true;
            this.cabinSelectLabel.Location = new System.Drawing.Point(6, 100);
            this.cabinSelectLabel.Name = "cabinSelectLabel";
            this.cabinSelectLabel.Size = new System.Drawing.Size(73, 13);
            this.cabinSelectLabel.TabIndex = 14;
            this.cabinSelectLabel.Text = "Odabir kabine";
            // 
            // cruiseSelectLabel
            // 
            this.cruiseSelectLabel.AutoSize = true;
            this.cruiseSelectLabel.Location = new System.Drawing.Point(6, 57);
            this.cruiseSelectLabel.Name = "cruiseSelectLabel";
            this.cruiseSelectLabel.Size = new System.Drawing.Size(87, 13);
            this.cruiseSelectLabel.TabIndex = 13;
            this.cruiseSelectLabel.Text = "Odabir krstarenja";
            // 
            // passengerSelectLabel
            // 
            this.passengerSelectLabel.AutoSize = true;
            this.passengerSelectLabel.Location = new System.Drawing.Point(6, 16);
            this.passengerSelectLabel.Name = "passengerSelectLabel";
            this.passengerSelectLabel.Size = new System.Drawing.Size(76, 13);
            this.passengerSelectLabel.TabIndex = 12;
            this.passengerSelectLabel.Text = "Odabir putnika";
            // 
            // cabinSelectCombobox
            // 
            this.cabinSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cabinSelectCombobox.FormattingEnabled = true;
            this.cabinSelectCombobox.Location = new System.Drawing.Point(9, 116);
            this.cabinSelectCombobox.Name = "cabinSelectCombobox";
            this.cabinSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.cabinSelectCombobox.TabIndex = 11;
            this.cabinSelectCombobox.SelectionChangeCommitted += new System.EventHandler(this.OnCabinChange);
            // 
            // cruiseSelectCombobox
            // 
            this.cruiseSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cruiseSelectCombobox.FormattingEnabled = true;
            this.cruiseSelectCombobox.Location = new System.Drawing.Point(9, 73);
            this.cruiseSelectCombobox.Name = "cruiseSelectCombobox";
            this.cruiseSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.cruiseSelectCombobox.TabIndex = 10;
            // 
            // passengerSelectCombobox
            // 
            this.passengerSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passengerSelectCombobox.FormattingEnabled = true;
            this.passengerSelectCombobox.Location = new System.Drawing.Point(9, 32);
            this.passengerSelectCombobox.Name = "passengerSelectCombobox";
            this.passengerSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.passengerSelectCombobox.TabIndex = 9;
            // 
            // editForm
            // 
            this.editForm.Controls.Add(this.passengerSelectLabel);
            this.editForm.Controls.Add(this.priceLabel);
            this.editForm.Controls.Add(this.passengerSelectCombobox);
            this.editForm.Controls.Add(this.priceTextbox);
            this.editForm.Controls.Add(this.cruiseSelectCombobox);
            this.editForm.Controls.Add(this.saveButton);
            this.editForm.Controls.Add(this.cabinSelectCombobox);
            this.editForm.Controls.Add(this.cabinSelectLabel);
            this.editForm.Controls.Add(this.cruiseSelectLabel);
            this.editForm.Location = new System.Drawing.Point(12, 56);
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(141, 207);
            this.editForm.TabIndex = 18;
            this.editForm.TabStop = false;
            // 
            // reservationSelectCombobox
            // 
            this.reservationSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reservationSelectCombobox.FormattingEnabled = true;
            this.reservationSelectCombobox.Location = new System.Drawing.Point(12, 29);
            this.reservationSelectCombobox.Name = "reservationSelectCombobox";
            this.reservationSelectCombobox.Size = new System.Drawing.Size(141, 21);
            this.reservationSelectCombobox.TabIndex = 19;
            this.reservationSelectCombobox.SelectionChangeCommitted += new System.EventHandler(this.OnReservationChange);
            // 
            // reservationPickLabel
            // 
            this.reservationPickLabel.AutoSize = true;
            this.reservationPickLabel.Location = new System.Drawing.Point(9, 9);
            this.reservationPickLabel.Name = "reservationPickLabel";
            this.reservationPickLabel.Size = new System.Drawing.Size(107, 13);
            this.reservationPickLabel.TabIndex = 20;
            this.reservationPickLabel.Text = "Odaberite rezervaciju";
            // 
            // EditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 279);
            this.Controls.Add(this.reservationPickLabel);
            this.Controls.Add(this.reservationSelectCombobox);
            this.Controls.Add(this.editForm);
            this.Name = "EditReservation";
            this.Text = "EditReservation";
            this.editForm.ResumeLayout(false);
            this.editForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label cabinSelectLabel;
        private System.Windows.Forms.Label cruiseSelectLabel;
        private System.Windows.Forms.Label passengerSelectLabel;
        private System.Windows.Forms.ComboBox cabinSelectCombobox;
        private System.Windows.Forms.ComboBox cruiseSelectCombobox;
        private System.Windows.Forms.ComboBox passengerSelectCombobox;
        private System.Windows.Forms.GroupBox editForm;
        private System.Windows.Forms.ComboBox reservationSelectCombobox;
        private System.Windows.Forms.Label reservationPickLabel;
    }
}