namespace CruiseManagementApp.Presentation.AdminView.CruiseForms
{
    partial class AddCruise
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
            this.shipCombobox = new System.Windows.Forms.ComboBox();
            this.portCombobox = new System.Windows.Forms.ComboBox();
            this.shipForm = new System.Windows.Forms.GroupBox();
            this.saveShipButton = new System.Windows.Forms.Button();
            this.portOfDepartureSelectLabel = new System.Windows.Forms.Label();
            this.shipSelectLabel = new System.Windows.Forms.Label();
            this.employeeOnCruiseForm = new System.Windows.Forms.GroupBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeListbox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.employeeSelectLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.shipForm.SuspendLayout();
            this.employeeOnCruiseForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipCombobox
            // 
            this.shipCombobox.FormattingEnabled = true;
            this.shipCombobox.Location = new System.Drawing.Point(86, 19);
            this.shipCombobox.Name = "shipCombobox";
            this.shipCombobox.Size = new System.Drawing.Size(121, 21);
            this.shipCombobox.TabIndex = 0;
            // 
            // portCombobox
            // 
            this.portCombobox.FormattingEnabled = true;
            this.portCombobox.Location = new System.Drawing.Point(86, 52);
            this.portCombobox.Name = "portCombobox";
            this.portCombobox.Size = new System.Drawing.Size(121, 21);
            this.portCombobox.TabIndex = 1;
            // 
            // shipForm
            // 
            this.shipForm.Controls.Add(this.saveShipButton);
            this.shipForm.Controls.Add(this.portOfDepartureSelectLabel);
            this.shipForm.Controls.Add(this.shipSelectLabel);
            this.shipForm.Controls.Add(this.shipCombobox);
            this.shipForm.Controls.Add(this.portCombobox);
            this.shipForm.Location = new System.Drawing.Point(12, 12);
            this.shipForm.Name = "shipForm";
            this.shipForm.Size = new System.Drawing.Size(227, 119);
            this.shipForm.TabIndex = 3;
            this.shipForm.TabStop = false;
            // 
            // saveShipButton
            // 
            this.saveShipButton.Location = new System.Drawing.Point(146, 90);
            this.saveShipButton.Name = "saveShipButton";
            this.saveShipButton.Size = new System.Drawing.Size(75, 23);
            this.saveShipButton.TabIndex = 4;
            this.saveShipButton.Text = "Potvrdi";
            this.saveShipButton.UseVisualStyleBackColor = true;
            this.saveShipButton.Click += new System.EventHandler(this.SaveShipButton_Click);
            // 
            // portOfDepartureSelectLabel
            // 
            this.portOfDepartureSelectLabel.AutoSize = true;
            this.portOfDepartureSelectLabel.Location = new System.Drawing.Point(6, 55);
            this.portOfDepartureSelectLabel.Name = "portOfDepartureSelectLabel";
            this.portOfDepartureSelectLabel.Size = new System.Drawing.Size(71, 13);
            this.portOfDepartureSelectLabel.TabIndex = 3;
            this.portOfDepartureSelectLabel.Text = "Luka polaska";
            // 
            // shipSelectLabel
            // 
            this.shipSelectLabel.AutoSize = true;
            this.shipSelectLabel.Location = new System.Drawing.Point(6, 22);
            this.shipSelectLabel.Name = "shipSelectLabel";
            this.shipSelectLabel.Size = new System.Drawing.Size(29, 13);
            this.shipSelectLabel.TabIndex = 2;
            this.shipSelectLabel.Text = "Brod";
            // 
            // employeeOnCruiseForm
            // 
            this.employeeOnCruiseForm.Controls.Add(this.startDateLabel);
            this.employeeOnCruiseForm.Controls.Add(this.employeeSelectLabel);
            this.employeeOnCruiseForm.Controls.Add(this.saveButton);
            this.employeeOnCruiseForm.Controls.Add(this.startDatePicker);
            this.employeeOnCruiseForm.Controls.Add(this.employeeListbox);
            this.employeeOnCruiseForm.Enabled = false;
            this.employeeOnCruiseForm.Location = new System.Drawing.Point(12, 137);
            this.employeeOnCruiseForm.Name = "employeeOnCruiseForm";
            this.employeeOnCruiseForm.Size = new System.Drawing.Size(227, 243);
            this.employeeOnCruiseForm.TabIndex = 4;
            this.employeeOnCruiseForm.TabStop = false;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(9, 177);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(212, 20);
            this.startDatePicker.TabIndex = 5;
            // 
            // employeeListbox
            // 
            this.employeeListbox.FormattingEnabled = true;
            this.employeeListbox.Location = new System.Drawing.Point(9, 30);
            this.employeeListbox.Name = "employeeListbox";
            this.employeeListbox.Size = new System.Drawing.Size(212, 124);
            this.employeeListbox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(146, 214);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Potvrdi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // employeeSelectLabel
            // 
            this.employeeSelectLabel.AutoSize = true;
            this.employeeSelectLabel.Location = new System.Drawing.Point(6, 14);
            this.employeeSelectLabel.Name = "employeeSelectLabel";
            this.employeeSelectLabel.Size = new System.Drawing.Size(154, 13);
            this.employeeSelectLabel.TabIndex = 5;
            this.employeeSelectLabel.Text = "Zaposlenici na ovom krstarenju";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 161);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(76, 13);
            this.startDateLabel.TabIndex = 6;
            this.startDateLabel.Text = "Datum ukrcaja";
            // 
            // AddCruise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 388);
            this.Controls.Add(this.employeeOnCruiseForm);
            this.Controls.Add(this.shipForm);
            this.Name = "AddCruise";
            this.Text = "AddCruise";
            this.shipForm.ResumeLayout(false);
            this.shipForm.PerformLayout();
            this.employeeOnCruiseForm.ResumeLayout(false);
            this.employeeOnCruiseForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox shipCombobox;
        private System.Windows.Forms.ComboBox portCombobox;
        private System.Windows.Forms.GroupBox shipForm;
        private System.Windows.Forms.Label portOfDepartureSelectLabel;
        private System.Windows.Forms.Label shipSelectLabel;
        private System.Windows.Forms.Button saveShipButton;
        private System.Windows.Forms.GroupBox employeeOnCruiseForm;
        private System.Windows.Forms.CheckedListBox employeeListbox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label employeeSelectLabel;
        private System.Windows.Forms.Button saveButton;
    }
}