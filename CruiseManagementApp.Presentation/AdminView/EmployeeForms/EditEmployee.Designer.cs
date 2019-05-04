namespace CruiseManagementApp.Presentation.AdminView.EmployeeForms
{
    partial class EditEmployee
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
            this.warningLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.employeeSelectCombobox = new System.Windows.Forms.ComboBox();
            this.selectEmployeeLabel = new System.Windows.Forms.Label();
            this.editForm = new System.Windows.Forms.GroupBox();
            this.editForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(6, 127);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 19;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(6, 98);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(77, 13);
            this.dateOfBirthLabel.TabIndex = 18;
            this.dateOfBirthLabel.Text = "Datum rođenja";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(6, 68);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(28, 13);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Spol";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 42);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(44, 13);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Prezime";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 16);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(24, 13);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "Ime";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(209, 171);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Spremi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(84, 92);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthPicker.TabIndex = 13;
            // 
            // genderCombobox
            // 
            this.genderCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Location = new System.Drawing.Point(84, 65);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(200, 21);
            this.genderCombobox.TabIndex = 12;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(84, 39);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextbox.TabIndex = 11;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(84, 13);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextbox.TabIndex = 10;
            // 
            // employeeSelectCombobox
            // 
            this.employeeSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeSelectCombobox.FormattingEnabled = true;
            this.employeeSelectCombobox.Location = new System.Drawing.Point(33, 34);
            this.employeeSelectCombobox.Name = "employeeSelectCombobox";
            this.employeeSelectCombobox.Size = new System.Drawing.Size(266, 21);
            this.employeeSelectCombobox.TabIndex = 20;
            this.employeeSelectCombobox.SelectionChangeCommitted += new System.EventHandler(this.OnSelectionChange);
            // 
            // selectEmployeeLabel
            // 
            this.selectEmployeeLabel.AutoSize = true;
            this.selectEmployeeLabel.Location = new System.Drawing.Point(30, 9);
            this.selectEmployeeLabel.Name = "selectEmployeeLabel";
            this.selectEmployeeLabel.Size = new System.Drawing.Size(112, 13);
            this.selectEmployeeLabel.TabIndex = 21;
            this.selectEmployeeLabel.Text = "Odaberite zaposlenika";
            // 
            // editForm
            // 
            this.editForm.Controls.Add(this.firstNameLabel);
            this.editForm.Controls.Add(this.firstNameTextbox);
            this.editForm.Controls.Add(this.lastNameTextbox);
            this.editForm.Controls.Add(this.warningLabel);
            this.editForm.Controls.Add(this.genderCombobox);
            this.editForm.Controls.Add(this.dateOfBirthLabel);
            this.editForm.Controls.Add(this.dateOfBirthPicker);
            this.editForm.Controls.Add(this.genderLabel);
            this.editForm.Controls.Add(this.saveButton);
            this.editForm.Controls.Add(this.lastNameLabel);
            this.editForm.Location = new System.Drawing.Point(15, 61);
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(301, 209);
            this.editForm.TabIndex = 22;
            this.editForm.TabStop = false;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 283);
            this.Controls.Add(this.editForm);
            this.Controls.Add(this.selectEmployeeLabel);
            this.Controls.Add(this.employeeSelectCombobox);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.editForm.ResumeLayout(false);
            this.editForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.ComboBox genderCombobox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.ComboBox employeeSelectCombobox;
        private System.Windows.Forms.Label selectEmployeeLabel;
        private System.Windows.Forms.GroupBox editForm;
    }
}