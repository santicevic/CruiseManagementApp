namespace CruiseManagementApp.Presentation.AdminView
{
    partial class AdminViewMain
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
            this.cabinButton = new System.Windows.Forms.Button();
            this.shipButton = new System.Windows.Forms.Button();
            this.cruiseButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.addNewRadio = new System.Windows.Forms.RadioButton();
            this.editRadio = new System.Windows.Forms.RadioButton();
            this.removeRadio = new System.Windows.Forms.RadioButton();
            this.operationGroupbox = new System.Windows.Forms.GroupBox();
            this.operationGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cabinButton
            // 
            this.cabinButton.Location = new System.Drawing.Point(6, 80);
            this.cabinButton.Name = "cabinButton";
            this.cabinButton.Size = new System.Drawing.Size(75, 23);
            this.cabinButton.TabIndex = 2;
            this.cabinButton.Text = "Kabinu";
            this.cabinButton.UseVisualStyleBackColor = true;
            this.cabinButton.Click += new System.EventHandler(this.CabinButton_Click);
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(6, 51);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 1;
            this.shipButton.Text = "Brod";
            this.shipButton.UseVisualStyleBackColor = true;
            this.shipButton.Click += new System.EventHandler(this.ShipButton_Click);
            // 
            // cruiseButton
            // 
            this.cruiseButton.Location = new System.Drawing.Point(6, 109);
            this.cruiseButton.Name = "cruiseButton";
            this.cruiseButton.Size = new System.Drawing.Size(75, 23);
            this.cruiseButton.TabIndex = 3;
            this.cruiseButton.Text = "Krstarenje";
            this.cruiseButton.UseVisualStyleBackColor = true;
            this.cruiseButton.Click += new System.EventHandler(this.CruiseButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(6, 22);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(75, 23);
            this.employeeButton.TabIndex = 0;
            this.employeeButton.Text = "Zaposlenika";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // addNewRadio
            // 
            this.addNewRadio.AutoSize = true;
            this.addNewRadio.Location = new System.Drawing.Point(97, 22);
            this.addNewRadio.Name = "addNewRadio";
            this.addNewRadio.Size = new System.Drawing.Size(53, 17);
            this.addNewRadio.TabIndex = 0;
            this.addNewRadio.TabStop = true;
            this.addNewRadio.Text = "Dodaj";
            this.addNewRadio.UseVisualStyleBackColor = true;
            // 
            // editRadio
            // 
            this.editRadio.AutoSize = true;
            this.editRadio.Location = new System.Drawing.Point(100, 66);
            this.editRadio.Name = "editRadio";
            this.editRadio.Size = new System.Drawing.Size(50, 17);
            this.editRadio.TabIndex = 1;
            this.editRadio.TabStop = true;
            this.editRadio.Text = "Uredi";
            this.editRadio.UseVisualStyleBackColor = true;
            // 
            // removeRadio
            // 
            this.removeRadio.AutoSize = true;
            this.removeRadio.Location = new System.Drawing.Point(100, 109);
            this.removeRadio.Name = "removeRadio";
            this.removeRadio.Size = new System.Drawing.Size(51, 17);
            this.removeRadio.TabIndex = 2;
            this.removeRadio.TabStop = true;
            this.removeRadio.Text = "Obriši";
            this.removeRadio.UseVisualStyleBackColor = true;
            // 
            // operationGroupbox
            // 
            this.operationGroupbox.Controls.Add(this.removeRadio);
            this.operationGroupbox.Controls.Add(this.cruiseButton);
            this.operationGroupbox.Controls.Add(this.editRadio);
            this.operationGroupbox.Controls.Add(this.cabinButton);
            this.operationGroupbox.Controls.Add(this.addNewRadio);
            this.operationGroupbox.Controls.Add(this.employeeButton);
            this.operationGroupbox.Controls.Add(this.shipButton);
            this.operationGroupbox.Location = new System.Drawing.Point(12, 12);
            this.operationGroupbox.Name = "operationGroupbox";
            this.operationGroupbox.Size = new System.Drawing.Size(176, 145);
            this.operationGroupbox.TabIndex = 5;
            this.operationGroupbox.TabStop = false;
            // 
            // AdminViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 167);
            this.Controls.Add(this.operationGroupbox);
            this.Name = "AdminViewMain";
            this.Text = "Admin sučelje";
            this.operationGroupbox.ResumeLayout(false);
            this.operationGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cabinButton;
        private System.Windows.Forms.Button shipButton;
        private System.Windows.Forms.Button cruiseButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.RadioButton addNewRadio;
        private System.Windows.Forms.RadioButton editRadio;
        private System.Windows.Forms.RadioButton removeRadio;
        private System.Windows.Forms.GroupBox operationGroupbox;
    }
}