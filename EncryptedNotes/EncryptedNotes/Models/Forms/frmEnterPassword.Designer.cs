namespace EncryptedNotes.Models.Forms
{
    partial class frmEnterPassword
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
            this.pnlEnterPassword = new System.Windows.Forms.Panel();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnEnterPassword = new kysToolDemo.KysTools.KYSButton();
            this.txtEnterPassword = new kysToolDemo.KysTools.KYSTextBox();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.pnlEnterPassword.SuspendLayout();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEnterPassword
            // 
            this.pnlEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlEnterPassword.Controls.Add(this.pnlBar);
            this.pnlEnterPassword.Controls.Add(this.btnEnterPassword);
            this.pnlEnterPassword.Controls.Add(this.txtEnterPassword);
            this.pnlEnterPassword.Controls.Add(this.lblEnterPassword);
            this.pnlEnterPassword.Location = new System.Drawing.Point(0, 0);
            this.pnlEnterPassword.Name = "pnlEnterPassword";
            this.pnlEnterPassword.Size = new System.Drawing.Size(302, 121);
            this.pnlEnterPassword.TabIndex = 2;
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.btnClose);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(302, 28);
            this.pnlBar.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::StickyNote.Properties.Resources.miCLose;
            this.btnClose.Location = new System.Drawing.Point(278, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEnterPassword
            // 
            this.btnEnterPassword.Angles = 90F;
            this.btnEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEnterPassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnEnterPassword.BorderColor = System.Drawing.Color.Empty;
            this.btnEnterPassword.BorderRadius = 10;
            this.btnEnterPassword.BorderSize = 0;
            this.btnEnterPassword.ColorBottom = System.Drawing.Color.White;
            this.btnEnterPassword.ColorTop = System.Drawing.Color.White;
            this.btnEnterPassword.FlatAppearance.BorderSize = 0;
            this.btnEnterPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnterPassword.Location = new System.Drawing.Point(222, 64);
            this.btnEnterPassword.Name = "btnEnterPassword";
            this.btnEnterPassword.Size = new System.Drawing.Size(64, 40);
            this.btnEnterPassword.TabIndex = 4;
            this.btnEnterPassword.Text = "Enter";
            this.btnEnterPassword.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnterPassword.UseVisualStyleBackColor = false;
            this.btnEnterPassword.Click += new System.EventHandler(this.btnEnterPassword_Click);
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtEnterPassword.BorderColor = System.Drawing.Color.Empty;
            this.txtEnterPassword.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtEnterPassword.BorderRadius = 10;
            this.txtEnterPassword.BorderSize = 2;
            this.txtEnterPassword.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.txtEnterPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnterPassword.Location = new System.Drawing.Point(15, 65);
            this.txtEnterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterPassword.MultiLine = false;
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEnterPassword.PasswordChar = false;
            this.txtEnterPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEnterPassword.PlaceholderText = "Enter the Password";
            this.txtEnterPassword.Size = new System.Drawing.Size(200, 39);
            this.txtEnterPassword.TabIndex = 3;
            this.txtEnterPassword.Texts = "";
            this.txtEnterPassword.UnderlinedStyle = true;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.ForeColor = System.Drawing.Color.White;
            this.lblEnterPassword.Location = new System.Drawing.Point(11, 40);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(53, 13);
            this.lblEnterPassword.TabIndex = 1;
            this.lblEnterPassword.Text = "Password";
            // 
            // frmEnterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.pnlEnterPassword);
            this.MaximumSize = new System.Drawing.Size(300, 120);
            this.MinimumSize = new System.Drawing.Size(300, 120);
            this.Name = "frmEnterPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPasswordEnter";
            this.pnlEnterPassword.ResumeLayout(false);
            this.pnlEnterPassword.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEnterPassword;
        private kysToolDemo.KysTools.KYSButton btnEnterPassword;
        private kysToolDemo.KysTools.KYSTextBox txtEnterPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.PictureBox btnClose;
    }
}