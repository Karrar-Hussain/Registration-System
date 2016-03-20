namespace Reg_Sys
{
    partial class Registration
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
            this.MainPnl = new System.Windows.Forms.Panel();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblimage = new System.Windows.Forms.Label();
            this.MainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPnl
            // 
            this.MainPnl.Controls.Add(this.lblimage);
            this.MainPnl.Controls.Add(this.label1);
            this.MainPnl.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPnl.Location = new System.Drawing.Point(85, 1);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(558, 371);
            this.MainPnl.TabIndex = 0;
            this.MainPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPnl_Paint);
            // 
            // BtnReg
            // 
            this.BtnReg.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.Location = new System.Drawing.Point(4, 62);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(81, 32);
            this.BtnReg.TabIndex = 1;
            this.BtnReg.Text = "Registration";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(4, 100);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(81, 32);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to The Registration System";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblimage
            // 
            this.lblimage.Image = global::Reg_Sys.Properties.Resources._1458248771_fireworks_2;
            this.lblimage.Location = new System.Drawing.Point(156, 97);
            this.lblimage.Name = "lblimage";
            this.lblimage.Size = new System.Drawing.Size(165, 153);
            this.lblimage.TabIndex = 1;
            // 
            // Registration
            // 
            this.ClientSize = new System.Drawing.Size(645, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.MainPnl);
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.MainPnl.ResumeLayout(false);
            this.MainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MainPnl;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblimage;
    }
}

