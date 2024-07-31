namespace EncryptedNotes.Models.Forms
{
    partial class frmStickyNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStickyNote));
            this.kysPanel1 = new kysToolDemo.KysTools.KYSPanel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.kysPanel2 = new kysToolDemo.KysTools.KYSPanel();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTitle = new kysToolDemo.KysTools.KYSTextBox();
            this.pnlEnterPassword = new System.Windows.Forms.Panel();
            this.btnEnterPassword = new kysToolDemo.KysTools.KYSButton();
            this.txtEnterPassword = new kysToolDemo.KysTools.KYSTextBox();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnNoteList = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.txtPassword = new kysToolDemo.KysTools.KYSTextBox();
            this.txtKey = new kysToolDemo.KysTools.KYSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chboxHide = new kysToolDemo.KysTools.KYSToggleButton();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.pctColor6 = new EncryptedNotes.Models.Tools.KYSPictureBox();
            this.pctColor5 = new EncryptedNotes.Models.Tools.KYSPictureBox();
            this.pctColor4 = new EncryptedNotes.Models.Tools.KYSPictureBox();
            this.pctColor3 = new EncryptedNotes.Models.Tools.KYSPictureBox();
            this.pctColor2 = new EncryptedNotes.Models.Tools.KYSPictureBox();
            this.pctColor1 = new EncryptedNotes.Models.Tools.KYSPictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.kysPanel1.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.kysPanel2.SuspendLayout();
            this.pnlEnterPassword.SuspendLayout();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoteList)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.pnlColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // kysPanel1
            // 
            this.kysPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kysPanel1.Angles = 90F;
            this.kysPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.kysPanel1.BorderRadius = 0;
            this.kysPanel1.BorderSize = 0;
            this.kysPanel1.Controls.Add(this.pnlBody);
            this.kysPanel1.Controls.Add(this.pnlEnterPassword);
            this.kysPanel1.Controls.Add(this.pnlBar);
            this.kysPanel1.Location = new System.Drawing.Point(2, 2);
            this.kysPanel1.Name = "kysPanel1";
            this.kysPanel1.Size = new System.Drawing.Size(302, 450);
            this.kysPanel1.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlBody.Controls.Add(this.kysPanel2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 111);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(302, 339);
            this.pnlBody.TabIndex = 5;
            // 
            // kysPanel2
            // 
            this.kysPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kysPanel2.Angles = 90F;
            this.kysPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.kysPanel2.BorderRadius = 25;
            this.kysPanel2.BorderSize = 0;
            this.kysPanel2.Controls.Add(this.txtBody);
            this.kysPanel2.Controls.Add(this.txtTitle);
            this.kysPanel2.Location = new System.Drawing.Point(12, 18);
            this.kysPanel2.Name = "kysPanel2";
            this.kysPanel2.Size = new System.Drawing.Size(281, 305);
            this.kysPanel2.TabIndex = 0;
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBody.Location = new System.Drawing.Point(0, 39);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(281, 266);
            this.txtBody.TabIndex = 3;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtTitle.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtTitle.BorderRadius = 0;
            this.txtTitle.BorderSize = 2;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.txtTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MultiLine = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTitle.PasswordChar = false;
            this.txtTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.Size = new System.Drawing.Size(281, 39);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Texts = "";
            this.txtTitle.UnderlinedStyle = true;
            this.txtTitle._TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // pnlEnterPassword
            // 
            this.pnlEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlEnterPassword.Controls.Add(this.btnEnterPassword);
            this.pnlEnterPassword.Controls.Add(this.txtEnterPassword);
            this.pnlEnterPassword.Controls.Add(this.lblEnterPassword);
            this.pnlEnterPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEnterPassword.Location = new System.Drawing.Point(0, 24);
            this.pnlEnterPassword.Name = "pnlEnterPassword";
            this.pnlEnterPassword.Size = new System.Drawing.Size(302, 87);
            this.pnlEnterPassword.TabIndex = 4;
            this.pnlEnterPassword.Visible = false;
            // 
            // btnEnterPassword
            // 
            this.btnEnterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnEnterPassword.Location = new System.Drawing.Point(232, 32);
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
            this.txtEnterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtEnterPassword.BorderColor = System.Drawing.Color.Empty;
            this.txtEnterPassword.BorderFocusColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnterPassword.BorderRadius = 10;
            this.txtEnterPassword.BorderSize = 2;
            this.txtEnterPassword.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.txtEnterPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnterPassword.Location = new System.Drawing.Point(17, 33);
            this.txtEnterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterPassword.MultiLine = false;
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEnterPassword.PasswordChar = false;
            this.txtEnterPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEnterPassword.PlaceholderText = "Enter the Password";
            this.txtEnterPassword.Size = new System.Drawing.Size(208, 39);
            this.txtEnterPassword.TabIndex = 3;
            this.txtEnterPassword.Texts = "";
            this.txtEnterPassword.UnderlinedStyle = true;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.ForeColor = System.Drawing.Color.White;
            this.lblEnterPassword.Location = new System.Drawing.Point(13, 8);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(77, 20);
            this.lblEnterPassword.TabIndex = 1;
            this.lblEnterPassword.Text = "Password";
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBar.Controls.Add(this.btnNoteList);
            this.pnlBar.Controls.Add(this.pnlSettings);
            this.pnlBar.Controls.Add(this.btnClose);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(302, 24);
            this.pnlBar.TabIndex = 3;
            this.pnlBar.DoubleClick += new System.EventHandler(this.pnlBar_Click);
            // 
            // btnNoteList
            // 
            this.btnNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoteList.Image = global::StickyNote.Properties.Resources.list;
            this.btnNoteList.Location = new System.Drawing.Point(254, 0);
            this.btnNoteList.Name = "btnNoteList";
            this.btnNoteList.Size = new System.Drawing.Size(24, 24);
            this.btnNoteList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNoteList.TabIndex = 6;
            this.btnNoteList.TabStop = false;
            this.btnNoteList.Click += new System.EventHandler(this.btnNoteList_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.txtPassword);
            this.pnlSettings.Controls.Add(this.txtKey);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.chboxHide);
            this.pnlSettings.Controls.Add(this.pnlColor);
            this.pnlSettings.Controls.Add(this.lblPassword);
            this.pnlSettings.Controls.Add(this.lblKey);
            this.pnlSettings.Location = new System.Drawing.Point(1, 24);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(304, 165);
            this.pnlSettings.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPassword.Location = new System.Drawing.Point(125, 43);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(165, 31);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword._TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtKey.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtKey.BorderRadius = 10;
            this.txtKey.BorderSize = 2;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtKey.Location = new System.Drawing.Point(126, 4);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.MultiLine = false;
            this.txtKey.Name = "txtKey";
            this.txtKey.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtKey.PasswordChar = false;
            this.txtKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKey.PlaceholderText = "";
            this.txtKey.Size = new System.Drawing.Size(165, 31);
            this.txtKey.TabIndex = 12;
            this.txtKey.Texts = "";
            this.txtKey.UnderlinedStyle = true;
            this.txtKey._TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hide";
            // 
            // chboxHide
            // 
            this.chboxHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxHide.AutoSize = true;
            this.chboxHide.Location = new System.Drawing.Point(245, 88);
            this.chboxHide.MinimumSize = new System.Drawing.Size(45, 22);
            this.chboxHide.Name = "chboxHide";
            this.chboxHide.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.chboxHide.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chboxHide.OnBackColor = System.Drawing.Color.White;
            this.chboxHide.OnToggleColor = System.Drawing.Color.Gray;
            this.chboxHide.Size = new System.Drawing.Size(45, 22);
            this.chboxHide.TabIndex = 10;
            this.chboxHide.UseVisualStyleBackColor = true;
            this.chboxHide.CheckedChanged += new System.EventHandler(this.chboxHide_CheckedChanged);
            // 
            // pnlColor
            // 
            this.pnlColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColor.Controls.Add(this.pctColor6);
            this.pnlColor.Controls.Add(this.pctColor5);
            this.pnlColor.Controls.Add(this.pctColor4);
            this.pnlColor.Controls.Add(this.pctColor3);
            this.pnlColor.Controls.Add(this.pctColor2);
            this.pnlColor.Controls.Add(this.pctColor1);
            this.pnlColor.Location = new System.Drawing.Point(0, 116);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(311, 50);
            this.pnlColor.TabIndex = 9;
            // 
            // pctColor6
            // 
            this.pctColor6.Angles = 90F;
            this.pctColor6.BackColor = System.Drawing.Color.Purple;
            this.pctColor6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pctColor6.BorderRadius = 0;
            this.pctColor6.BorderSize = 1;
            this.pctColor6.Location = new System.Drawing.Point(250, 0);
            this.pctColor6.Name = "pctColor6";
            this.pctColor6.Size = new System.Drawing.Size(50, 50);
            this.pctColor6.TabIndex = 5;
            this.pctColor6.TabStop = false;
            this.pctColor6.Click += new System.EventHandler(this.pctColor);
            // 
            // pctColor5
            // 
            this.pctColor5.Angles = 90F;
            this.pctColor5.BackColor = System.Drawing.Color.HotPink;
            this.pctColor5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pctColor5.BorderRadius = 0;
            this.pctColor5.BorderSize = 1;
            this.pctColor5.Location = new System.Drawing.Point(200, 0);
            this.pctColor5.Name = "pctColor5";
            this.pctColor5.Size = new System.Drawing.Size(50, 50);
            this.pctColor5.TabIndex = 4;
            this.pctColor5.TabStop = false;
            this.pctColor5.Click += new System.EventHandler(this.pctColor);
            // 
            // pctColor4
            // 
            this.pctColor4.Angles = 90F;
            this.pctColor4.BackColor = System.Drawing.Color.Turquoise;
            this.pctColor4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pctColor4.BorderRadius = 0;
            this.pctColor4.BorderSize = 1;
            this.pctColor4.Location = new System.Drawing.Point(150, 0);
            this.pctColor4.Name = "pctColor4";
            this.pctColor4.Size = new System.Drawing.Size(50, 50);
            this.pctColor4.TabIndex = 3;
            this.pctColor4.TabStop = false;
            this.pctColor4.Click += new System.EventHandler(this.pctColor);
            // 
            // pctColor3
            // 
            this.pctColor3.Angles = 90F;
            this.pctColor3.BackColor = System.Drawing.Color.GreenYellow;
            this.pctColor3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pctColor3.BorderRadius = 0;
            this.pctColor3.BorderSize = 1;
            this.pctColor3.Location = new System.Drawing.Point(100, 0);
            this.pctColor3.Name = "pctColor3";
            this.pctColor3.Size = new System.Drawing.Size(50, 50);
            this.pctColor3.TabIndex = 2;
            this.pctColor3.TabStop = false;
            this.pctColor3.Click += new System.EventHandler(this.pctColor);
            // 
            // pctColor2
            // 
            this.pctColor2.Angles = 90F;
            this.pctColor2.BackColor = System.Drawing.Color.Orange;
            this.pctColor2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pctColor2.BorderRadius = 0;
            this.pctColor2.BorderSize = 1;
            this.pctColor2.Location = new System.Drawing.Point(50, 0);
            this.pctColor2.Name = "pctColor2";
            this.pctColor2.Size = new System.Drawing.Size(50, 50);
            this.pctColor2.TabIndex = 1;
            this.pctColor2.TabStop = false;
            this.pctColor2.Click += new System.EventHandler(this.pctColor);
            // 
            // pctColor1
            // 
            this.pctColor1.Angles = 90F;
            this.pctColor1.BackColor = System.Drawing.Color.Gold;
            this.pctColor1.BorderColor = System.Drawing.Color.White;
            this.pctColor1.BorderRadius = 0;
            this.pctColor1.BorderSize = 2;
            this.pctColor1.Location = new System.Drawing.Point(0, 0);
            this.pctColor1.Name = "pctColor1";
            this.pctColor1.Size = new System.Drawing.Size(50, 50);
            this.pctColor1.TabIndex = 0;
            this.pctColor1.TabStop = false;
            this.pctColor1.Click += new System.EventHandler(this.pctColor);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(8, 10);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(111, 20);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "Encryption Key";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::StickyNote.Properties.Resources.miCLose;
            this.btnClose.Location = new System.Drawing.Point(278, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStickyNote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(306, 455);
            this.Controls.Add(this.kysPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStickyNote";
            this.Text = "frmStickyNote";
            this.kysPanel1.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.kysPanel2.ResumeLayout(false);
            this.kysPanel2.PerformLayout();
            this.pnlEnterPassword.ResumeLayout(false);
            this.pnlEnterPassword.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNoteList)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctColor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kysToolDemo.KysTools.KYSPanel kysPanel1;
        private System.Windows.Forms.Panel pnlEnterPassword;
        private kysToolDemo.KysTools.KYSButton btnEnterPassword;
        private kysToolDemo.KysTools.KYSTextBox txtEnterPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.PictureBox btnNoteList;
        private System.Windows.Forms.Panel pnlSettings;
        private kysToolDemo.KysTools.KYSTextBox txtPassword;
        private kysToolDemo.KysTools.KYSTextBox txtKey;
        private System.Windows.Forms.Label label1;
        private kysToolDemo.KysTools.KYSToggleButton chboxHide;
        private System.Windows.Forms.Panel pnlColor;
        private Tools.KYSPictureBox pctColor6;
        private Tools.KYSPictureBox pctColor5;
        private Tools.KYSPictureBox pctColor4;
        private Tools.KYSPictureBox pctColor3;
        private Tools.KYSPictureBox pctColor2;
        private Tools.KYSPictureBox pctColor1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlBody;
        private kysToolDemo.KysTools.KYSPanel kysPanel2;
        private System.Windows.Forms.TextBox txtBody;
        private kysToolDemo.KysTools.KYSTextBox txtTitle;
    }
}