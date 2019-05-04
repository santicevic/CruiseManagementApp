namespace CruiseManagementApp.Presentation.UserView.PassengerForms
{
    partial class EditPassenger
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
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.editForm = new System.Windows.Forms.GroupBox();
            this.passengerSelectorCombobox = new System.Windows.Forms.ComboBox();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.editForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(9, 139);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(28, 13);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Spol";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(9, 100);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(9, 61);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(44, 13);
            this.lastNameLabel.TabIndex = 15;
            this.lastNameLabel.Text = "Prezime";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(9, 22);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(24, 13);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "Ime";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(167, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // genderCombobox
            // 
            this.genderCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Location = new System.Drawing.Point(102, 136);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(140, 21);
            this.genderCombobox.TabIndex = 12;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(102, 97);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(140, 20);
            this.addressTextbox.TabIndex = 11;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(102, 58);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(140, 20);
            this.lastNameTextbox.TabIndex = 10;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(102, 19);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(140, 20);
            this.firstNameTextbox.TabIndex = 9;
            // 
            // editForm
            // 
            this.editForm.Controls.Add(this.warningLabel);
            this.editForm.Controls.Add(this.firstNameLabel);
            this.editForm.Controls.Add(this.genderLabel);
            this.editForm.Controls.Add(this.firstNameTextbox);
            this.editForm.Controls.Add(this.addressLabel);
            this.editForm.Controls.Add(this.lastNameTextbox);
            this.editForm.Controls.Add(this.lastNameLabel);
            this.editForm.Controls.Add(this.addressTextbox);
            this.editForm.Controls.Add(this.genderCombobox);
            this.editForm.Controls.Add(this.saveButton);
            this.editForm.Location = new System.Drawing.Point(3, 68);
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(248, 264);
            this.editForm.TabIndex = 18;
            this.editForm.TabStop = false;
            this.editForm.Text = "Uredi";
            // 
            // passengerSelectorCombobox
            // 
            this.passengerSelectorCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passengerSelectorCombobox.FormattingEnabled = true;
            this.passengerSelectorCombobox.Location = new System.Drawing.Point(9, 29);
            this.passengerSelectorCombobox.Name = "passengerSelectorCombobox";
            this.passengerSelectorCombobox.Size = new System.Drawing.Size(242, 21);
            this.passengerSelectorCombobox.TabIndex = 19;
            this.passengerSelectorCombobox.SelectedIndexChanged += new System.EventHandler(this.OnPassengerSelectChange);
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Location = new System.Drawing.Point(9, 13);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(44, 13);
            this.passengerLabel.TabIndex = 20;
            this.passengerLabel.Text = "Korisnik";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(6, 176);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 18;
            // 
            // EditPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 344);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.passengerSelectorCombobox);
            this.Controls.Add(this.editForm);
            this.Name = "EditPassenger";
            this.Text = "Uredi";
            this.editForm.ResumeLayout(false);
            this.editForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox genderCombobox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.GroupBox editForm;
        private System.Windows.Forms.ComboBox passengerSelectorCombobox;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.Label warningLabel;
    }
}