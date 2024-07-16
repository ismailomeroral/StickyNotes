namespace EncryptedNotes.Models.Forms
{
    partial class frmOldStickyNote
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
            this.txtBody = new System.Windows.Forms.TextBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.chboxHide = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnterPassword = new System.Windows.Forms.Button();
            this.pnlEnterPassword = new System.Windows.Forms.Panel();
            this.pnlSettings.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlEnterPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.Color.White;
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBody.Location = new System.Drawing.Point(0, 32);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(347, 152);
            this.txtBody.TabIndex = 0;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSettings.Controls.Add(this.chboxHide);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.txtPassword);
            this.pnlSettings.Controls.Add(this.txtKey);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettings.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.pnlSettings.Location = new System.Drawing.Point(0, 184);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(347, 16);
            this.pnlSettings.TabIndex = 1;
            this.pnlSettings.Click += new System.EventHandler(this.pnlSettings_Click);
            // 
            // chboxHide
            // 
            this.chboxHide.AutoSize = true;
            this.chboxHide.Location = new System.Drawing.Point(30, 93);
            this.chboxHide.Name = "chboxHide";
            this.chboxHide.Size = new System.Drawing.Size(60, 24);
            this.chboxHide.TabIndex = 2;
            this.chboxHide.Text = "Hide";
            this.chboxHide.UseVisualStyleBackColor = true;
            this.chboxHide.CheckedChanged += new System.EventHandler(this.chboxHide_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(119, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 32);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(119, 19);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(201, 32);
            this.txtKey.TabIndex = 0;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(347, 32);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.txtBody);
            this.pnlBody.Controls.Add(this.txtTitle);
            this.pnlBody.Controls.Add(this.pnlSettings);
            this.pnlBody.Location = new System.Drawing.Point(0, 80);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(347, 200);
            this.pnlBody.TabIndex = 2;
            this.pnlBody.Visible = false;
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.Location = new System.Drawing.Point(15, 35);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.Size = new System.Drawing.Size(253, 32);
            this.txtEnterPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter the Password";
            // 
            // btnEnterPassword
            // 
            this.btnEnterPassword.Location = new System.Drawing.Point(274, 35);
            this.btnEnterPassword.Name = "btnEnterPassword";
            this.btnEnterPassword.Size = new System.Drawing.Size(58, 32);
            this.btnEnterPassword.TabIndex = 5;
            this.btnEnterPassword.Text = "Enter";
            this.btnEnterPassword.UseVisualStyleBackColor = true;
            this.btnEnterPassword.Click += new System.EventHandler(this.btnEnterPassword_Click);
            // 
            // pnlEnterPassword
            // 
            this.pnlEnterPassword.Controls.Add(this.txtEnterPassword);
            this.pnlEnterPassword.Controls.Add(this.btnEnterPassword);
            this.pnlEnterPassword.Controls.Add(this.label4);
            this.pnlEnterPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEnterPassword.Location = new System.Drawing.Point(0, 0);
            this.pnlEnterPassword.Name = "pnlEnterPassword";
            this.pnlEnterPassword.Size = new System.Drawing.Size(347, 74);
            this.pnlEnterPassword.TabIndex = 6;
            // 
            // frmOldStickyNote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 282);
            this.Controls.Add(this.pnlEnterPassword);
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.Name = "frmOldStickyNote";
            this.Text = "frmStickyNote";
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlEnterPassword.ResumeLayout(false);
            this.pnlEnterPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chboxHide;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnterPassword;
        private System.Windows.Forms.Panel pnlEnterPassword;
    }
}