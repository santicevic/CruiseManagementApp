namespace CruiseManagementApp.Presentation.UserView
{
    partial class UserViewMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.passengerMenu = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reservationsMenu = new System.Windows.Forms.GroupBox();
            this.deleteReservationButton = new System.Windows.Forms.Button();
            this.editReservationButton = new System.Windows.Forms.Button();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.passengerMenu.SuspendLayout();
            this.reservationsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddPassenger_Click);
            // 
            // passengerMenu
            // 
            this.passengerMenu.Controls.Add(this.button3);
            this.passengerMenu.Controls.Add(this.button2);
            this.passengerMenu.Controls.Add(this.button1);
            this.passengerMenu.Location = new System.Drawing.Point(12, 12);
            this.passengerMenu.Name = "passengerMenu";
            this.passengerMenu.Size = new System.Drawing.Size(92, 114);
            this.passengerMenu.TabIndex = 1;
            this.passengerMenu.TabStop = false;
            this.passengerMenu.Text = "Korisnik";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Izbriši";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uredi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditPassenger_Click);
            // 
            // reservationsMenu
            // 
            this.reservationsMenu.Controls.Add(this.deleteReservationButton);
            this.reservationsMenu.Controls.Add(this.editReservationButton);
            this.reservationsMenu.Controls.Add(this.addReservationButton);
            this.reservationsMenu.Location = new System.Drawing.Point(122, 13);
            this.reservationsMenu.Name = "reservationsMenu";
            this.reservationsMenu.Size = new System.Drawing.Size(89, 114);
            this.reservationsMenu.TabIndex = 3;
            this.reservationsMenu.TabStop = false;
            this.reservationsMenu.Text = "Rezervacije";
            // 
            // deleteReservationButton
            // 
            this.deleteReservationButton.Location = new System.Drawing.Point(6, 79);
            this.deleteReservationButton.Name = "deleteReservationButton";
            this.deleteReservationButton.Size = new System.Drawing.Size(75, 23);
            this.deleteReservationButton.TabIndex = 2;
            this.deleteReservationButton.Text = "Izbriši";
            this.deleteReservationButton.UseVisualStyleBackColor = true;
            this.deleteReservationButton.Click += new System.EventHandler(this.DeleteReservationButton_Click);
            // 
            // editReservationButton
            // 
            this.editReservationButton.Location = new System.Drawing.Point(6, 48);
            this.editReservationButton.Name = "editReservationButton";
            this.editReservationButton.Size = new System.Drawing.Size(75, 23);
            this.editReservationButton.TabIndex = 1;
            this.editReservationButton.Text = "Uredi";
            this.editReservationButton.UseVisualStyleBackColor = true;
            this.editReservationButton.Click += new System.EventHandler(this.EditReservationButton_Click);
            // 
            // addReservationButton
            // 
            this.addReservationButton.Location = new System.Drawing.Point(6, 19);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(75, 23);
            this.addReservationButton.TabIndex = 0;
            this.addReservationButton.Text = "Dodaj";
            this.addReservationButton.UseVisualStyleBackColor = true;
            this.addReservationButton.Click += new System.EventHandler(this.AddReservationButton_Click);
            // 
            // UserViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 139);
            this.Controls.Add(this.reservationsMenu);
            this.Controls.Add(this.passengerMenu);
            this.Name = "UserViewMain";
            this.Text = "Korisničko sučelje";
            this.passengerMenu.ResumeLayout(false);
            this.reservationsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox passengerMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.GroupBox reservationsMenu;
        private System.Windows.Forms.Button deleteReservationButton;
        private System.Windows.Forms.Button editReservationButton;
        private System.Windows.Forms.Button addReservationButton;
    }
}