namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Admin Admin;
        private FrontOffice FrontOffice;
        private FrontOffice HouseKeeper;
        private HouseKeeperSupervisor HouseKeeperSupervisor;

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
            this.Admin = new WindowsFormsApp1.Admin();
            this.FrontOffice = new WindowsFormsApp1.FrontOffice();
            this.HouseKeeper = new WindowsFormsApp1.FrontOffice();
            this.HouseKeeperSupervisor = new WindowsFormsApp1.HouseKeeperSupervisor();
            this.SuspendLayout();

            // 
            // pageAdmin1
            // 
            this.Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Name = "pageAdmin1";
            this.Admin.Size = new System.Drawing.Size(1016, 541);
            this.Admin.TabIndex = 0;
            // 
            // pageFrontOffice1
            // 
            this.FrontOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrontOffice.Location = new System.Drawing.Point(0, 0);
            this.FrontOffice.Name = "pageFrontOffice1";
            this.FrontOffice.Size = new System.Drawing.Size(1016, 541);
            this.FrontOffice.TabIndex = 1;
            // 
            // pageHousekeeper1
            // 
            this.HouseKeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HouseKeeper.Location = new System.Drawing.Point(0, 0);
            this.HouseKeeper.Name = "pageHousekeeper1";
            this.HouseKeeper.Size = new System.Drawing.Size(1016, 541);
            this.HouseKeeper.TabIndex = 2;
            // 
            // pageHousekeeperSupervisor1
            // 
            this.HouseKeeperSupervisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HouseKeeperSupervisor.Location = new System.Drawing.Point(0, 0);
            this.HouseKeeperSupervisor.Name = "pageHousekeeperSupervisor1";
            this.HouseKeeperSupervisor.Size = new System.Drawing.Size(1016, 541);
            this.HouseKeeperSupervisor.TabIndex = 3;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 541);
            this.Controls.Add(this.HouseKeeperSupervisor);
            this.Controls.Add(this.HouseKeeper);
            this.Controls.Add(this.FrontOffice);
            this.Controls.Add(this.Admin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}