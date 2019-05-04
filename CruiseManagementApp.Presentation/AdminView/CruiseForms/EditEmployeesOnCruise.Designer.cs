namespace CruiseManagementApp.Presentation.AdminView.CruiseForms
{
    partial class EditEmployeesOnCruise
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
            this.selectCruiseGroupbox = new System.Windows.Forms.GroupBox();
            this.cruiseSelectCombobox = new System.Windows.Forms.ComboBox();
            this.cruiseSelectLabel = new System.Windows.Forms.Label();
            this.addEmployeeForm = new System.Windows.Forms.GroupBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.employeeAddComobox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.employeesOnCruiseListbox = new System.Windows.Forms.ListBox();
            this.employeeSelectLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.selectCruiseGroupbox.SuspendLayout();
            this.addEmployeeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectCruiseGroupbox
            // 
            this.selectCruiseGroupbox.Controls.Add(this.cruiseSelectCombobox);
            this.selectCruiseGroupbox.Controls.Add(this.cruiseSelectLabel);
            this.selectCruiseGroupbox.Location = new System.Drawing.Point(12, 12);
            this.selectCruiseGroupbox.Name = "selectCruiseGroupbox";
            this.selectCruiseGroupbox.Size = new System.Drawing.Size(227, 66);
            this.selectCruiseGroupbox.TabIndex = 12;
            this.selectCruiseGroupbox.TabStop = false;
            // 
            // cruiseSelectCombobox
            // 
            this.cruiseSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cruiseSelectCombobox.FormattingEnabled = true;
            this.cruiseSelectCombobox.Location = new System.Drawing.Point(6, 33);
            this.cruiseSelectCombobox.Name = "cruiseSelectCombobox";
            this.cruiseSelectCombobox.Size = new System.Drawing.Size(201, 21);
            this.cruiseSelectCombobox.TabIndex = 7;
            this.cruiseSelectCombobox.SelectionChangeCommitted += new System.EventHandler(this.OnCruiseChange);
            // 
            // cruiseSelectLabel
            // 
            this.cruiseSelectLabel.AutoSize = true;
            this.cruiseSelectLabel.Location = new System.Drawing.Point(12, 17);
            this.cruiseSelectLabel.Name = "cruiseSelectLabel";
            this.cruiseSelectLabel.Size = new System.Drawing.Size(102, 13);
            this.cruiseSelectLabel.TabIndex = 8;
            this.cruiseSelectLabel.Text = "Odaberite krstarenje";
            // 
            // addEmployeeForm
            // 
            this.addEmployeeForm.Controls.Add(this.addEmployeeButton);
            this.addEmployeeForm.Controls.Add(this.employeeAddComobox);
            this.addEmployeeForm.Controls.Add(this.button2);
            this.addEmployeeForm.Controls.Add(this.employeesOnCruiseListbox);
            this.addEmployeeForm.Controls.Add(this.employeeSelectLabel);
            this.addEmployeeForm.Controls.Add(this.saveButton);
            this.addEmployeeForm.Location = new System.Drawing.Point(12, 84);
            this.addEmployeeForm.Name = "addEmployeeForm";
            this.addEmployeeForm.Size = new System.Drawing.Size(227, 288);
            this.addEmployeeForm.TabIndex = 13;
            this.addEmployeeForm.TabStop = false;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(9, 46);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(198, 23);
            this.addEmployeeButton.TabIndex = 12;
            this.addEmployeeButton.Text = "Dodaj zaposlenika";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployeButton_Click);
            // 
            // employeeAddComobox
            // 
            this.employeeAddComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeAddComobox.FormattingEnabled = true;
            this.employeeAddComobox.Location = new System.Drawing.Point(9, 19);
            this.employeeAddComobox.Name = "employeeAddComobox";
            this.employeeAddComobox.Size = new System.Drawing.Size(198, 21);
            this.employeeAddComobox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Obriši odabranog zaposlenika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // employeesOnCruiseListbox
            // 
            this.employeesOnCruiseListbox.FormattingEnabled = true;
            this.employeesOnCruiseListbox.Location = new System.Drawing.Point(6, 89);
            this.employeesOnCruiseListbox.Name = "employeesOnCruiseListbox";
            this.employeesOnCruiseListbox.Size = new System.Drawing.Size(201, 108);
            this.employeesOnCruiseListbox.TabIndex = 6;
            // 
            // employeeSelectLabel
            // 
            this.employeeSelectLabel.AutoSize = true;
            this.employeeSelectLabel.Location = new System.Drawing.Point(0, 73);
            this.employeeSelectLabel.Name = "employeeSelectLabel";
            this.employeeSelectLabel.Size = new System.Drawing.Size(154, 13);
            this.employeeSelectLabel.TabIndex = 5;
            this.employeeSelectLabel.Text = "Zaposlenici na ovom krstarenju";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(132, 244);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Potvrdi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddRemoveEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 377);
            this.Controls.Add(this.addEmployeeForm);
            this.Controls.Add(this.selectCruiseGroupbox);
            this.Name = "AddRemoveEmployees";
            this.Text = "AddRemoveEmployees";
            this.selectCruiseGroupbox.ResumeLayout(false);
            this.selectCruiseGroupbox.PerformLayout();
            this.addEmployeeForm.ResumeLayout(false);
            this.addEmployeeForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectCruiseGroupbox;
        private System.Windows.Forms.ComboBox cruiseSelectCombobox;
        private System.Windows.Forms.Label cruiseSelectLabel;
        private System.Windows.Forms.GroupBox addEmployeeForm;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.ComboBox employeeAddComobox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox employeesOnCruiseListbox;
        private System.Windows.Forms.Label employeeSelectLabel;
        private System.Windows.Forms.Button saveButton;
    }
}