namespace CruiseManagementApp.Presentation.AdminView.EmployeeForms
{
    partial class RemoveEmployee
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
            this.employeeSelectLabel = new System.Windows.Forms.Label();
            this.employeeSelectCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(107, 70);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // employeeSelectLabel
            // 
            this.employeeSelectLabel.AutoSize = true;
            this.employeeSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.employeeSelectLabel.Name = "employeeSelectLabel";
            this.employeeSelectLabel.Size = new System.Drawing.Size(97, 13);
            this.employeeSelectLabel.TabIndex = 24;
            this.employeeSelectLabel.Text = "Odabir zaposlenika";
            // 
            // employeeSelectCombobox
            // 
            this.employeeSelectCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeSelectCombobox.FormattingEnabled = true;
            this.employeeSelectCombobox.Location = new System.Drawing.Point(15, 25);
            this.employeeSelectCombobox.Name = "employeeSelectCombobox";
            this.employeeSelectCombobox.Size = new System.Drawing.Size(167, 21);
            this.employeeSelectCombobox.TabIndex = 23;
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 102);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.employeeSelectLabel);
            this.Controls.Add(this.employeeSelectCombobox);
            this.Name = "RemoveEmployee";
            this.Text = "RemoveEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label employeeSelectLabel;
        private System.Windows.Forms.ComboBox employeeSelectCombobox;
    }
}