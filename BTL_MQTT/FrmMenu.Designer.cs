namespace BTL_MQTT
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btHelp = new System.Windows.Forms.Button();
            this.btnStations = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnForm = new System.Windows.Forms.Panel();
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnMenu.Controls.Add(this.btHelp);
            this.pnMenu.Controls.Add(this.btnStations);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(171, 603);
            this.pnMenu.TabIndex = 1;
            // 
            // btHelp
            // 
            this.btHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHelp.FlatAppearance.BorderSize = 0;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btHelp.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btHelp.Location = new System.Drawing.Point(0, 323);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(171, 110);
            this.btHelp.TabIndex = 5;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click_1);
            // 
            // btnStations
            // 
            this.btnStations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStations.FlatAppearance.BorderSize = 0;
            this.btnStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStations.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStations.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnStations.Location = new System.Drawing.Point(0, 213);
            this.btnStations.Name = "btnStations";
            this.btnStations.Size = new System.Drawing.Size(171, 110);
            this.btnStations.TabIndex = 3;
            this.btnStations.Text = "Stations";
            this.btnStations.UseVisualStyleBackColor = true;
            this.btnStations.Click += new System.EventHandler(this.btnStations_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 103);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 110);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(171, 103);
            this.pnLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Support Team";
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnTitleBar.Controls.Add(this.btnExit);
            this.pnTitleBar.Controls.Add(this.lbTime);
            this.pnTitleBar.Controls.Add(this.lbTitle);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(171, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(924, 103);
            this.pnTitleBar.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(884, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(680, 78);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 25);
            this.lbTime.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(409, 39);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(98, 32);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "HOME";
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(171, 103);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(924, 500);
            this.pnForm.TabIndex = 4;
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Enabled = true;
            this.timerTimeNow.Interval = 1000;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTimeNow_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 603);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmStation_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btnStations;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.Button btnExit;
    }
}