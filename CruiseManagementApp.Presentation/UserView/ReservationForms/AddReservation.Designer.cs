namespace CruiseManagementApp.Presentation.UserView.ReservationForms
{
    partial class AddReservation
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
            this.passengerSelectCombobox = new System.Windows.Forms.ComboBox();
            this.cruiseSelectCombobox = new System.Windows.Forms.ComboBox();
            this.cabinSelectCombobox = new System.Windows.Forms.ComboBox();
            this.passengerSelectLabel = new System.Windows.Forms.Label();
            this.cruiseSelectLabel = new System.Windows.Forms.Label();
            this.cabinSelectLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passengerSelectCombobox
            // 
            this.passengerSelectCombobox.FormattingEnabled = true;
            this.passengerSelectCombobox.Location = new System.Drawing.Point(15, 25);
            this.passengerSelectCombobox.Name = "passengerSelectCombobox";
            this.passengerSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.passengerSelectCombobox.TabIndex = 0;
            this.passengerSelectCombobox.Click += new System.EventHandler(this.OnPassengerSelectionChange);
            // 
            // cruiseSelectCombobox
            // 
            this.cruiseSelectCombobox.FormattingEnabled = true;
            this.cruiseSelectCombobox.Location = new System.Drawing.Point(15, 66);
            this.cruiseSelectCombobox.Name = "cruiseSelectCombobox";
            this.cruiseSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.cruiseSelectCombobox.TabIndex = 1;
            // 
            // cabinSelectCombobox
            // 
            this.cabinSelectCombobox.FormattingEnabled = true;
            this.cabinSelectCombobox.Location = new System.Drawing.Point(15, 109);
            this.cabinSelectCombobox.Name = "cabinSelectCombobox";
            this.cabinSelectCombobox.Size = new System.Drawing.Size(121, 21);
            this.cabinSelectCombobox.TabIndex = 2;
            // 
            // passengerSelectLabel
            // 
            this.passengerSelectLabel.AutoSize = true;
            this.passengerSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.passengerSelectLabel.Name = "passengerSelectLabel";
            this.passengerSelectLabel.Size = new System.Drawing.Size(76, 13);
            this.passengerSelectLabel.TabIndex = 3;
            this.passengerSelectLabel.Text = "Odabir putnika";
            // 
            // cruiseSelectLabel
            // 
            this.cruiseSelectLabel.AutoSize = true;
            this.cruiseSelectLabel.Location = new System.Drawing.Point(12, 50);
            this.cruiseSelectLabel.Name = "cruiseSelectLabel";
            this.cruiseSelectLabel.Size = new System.Drawing.Size(87, 13);
            this.cruiseSelectLabel.TabIndex = 4;
            this.cruiseSelectLabel.Text = "Odabir krstarenja";
            // 
            // cabinSelectLabel
            // 
            this.cabinSelectLabel.AutoSize = true;
            this.cabinSelectLabel.Location = new System.Drawing.Point(12, 93);
            this.cabinSelectLabel.Name = "cabinSelectLabel";
            this.cabinSelectLabel.Size = new System.Drawing.Size(73, 13);
            this.cabinSelectLabel.TabIndex = 5;
            this.cabinSelectLabel.Text = "Odabir kabine";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(61, 145);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 180);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cabinSelectLabel);
            this.Controls.Add(this.cruiseSelectLabel);
            this.Controls.Add(this.passengerSelectLabel);
            this.Controls.Add(this.cabinSelectCombobox);
            this.Controls.Add(this.cruiseSelectCombobox);
            this.Controls.Add(this.passengerSelectCombobox);
            this.Name = "AddReservation";
            this.Text = "AddReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox passengerSelectCombobox;
        private System.Windows.Forms.ComboBox cruiseSelectCombobox;
        private System.Windows.Forms.ComboBox cabinSelectCombobox;
        private System.Windows.Forms.Label passengerSelectLabel;
        private System.Windows.Forms.Label cruiseSelectLabel;
        private System.Windows.Forms.Label cabinSelectLabel;
        private System.Windows.Forms.Button saveButton;
    }
}