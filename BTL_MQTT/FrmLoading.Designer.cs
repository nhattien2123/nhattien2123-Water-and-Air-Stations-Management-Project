namespace BTL_MQTT
{
    partial class FrmLoading
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
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pnLoadingBackground = new System.Windows.Forms.Panel();
            this.pnLoading = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 1500;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pnLoadingBackground
            // 
            this.pnLoadingBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnLoadingBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLoadingBackground.Location = new System.Drawing.Point(0, 388);
            this.pnLoadingBackground.Name = "pnLoadingBackground";
            this.pnLoadingBackground.Size = new System.Drawing.Size(763, 23);
            this.pnLoadingBackground.TabIndex = 0;
            // 
            // pnLoading
            // 
            this.pnLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnLoading.Location = new System.Drawing.Point(0, 388);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(0, 23);
            this.pnLoading.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading...";
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotice.ForeColor = System.Drawing.Color.White;
            this.lbNotice.Location = new System.Drawing.Point(0, 363);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(0, 25);
            this.lbNotice.TabIndex = 3;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(763, 411);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnLoading);
            this.Controls.Add(this.pnLoadingBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Panel pnLoadingBackground;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNotice;
    }
}

