namespace EncryptedNotes.Models.Forms
{
    partial class frmNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoteList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNotes = new kysToolDemo.KysTools.KYSPanel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.txtSearches = new kysToolDemo.KysTools.KYSTextBox();
            this.pnlCreateNote = new System.Windows.Forms.Panel();
            this.btnCreateNote = new kysToolDemo.KysTools.KYSButton();
            this.txtCreateNoteName = new kysToolDemo.KysTools.KYSTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCreateNoteName = new System.Windows.Forms.Label();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnShowCreateNote = new System.Windows.Forms.PictureBox();
            this.btnClosed = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.pnlCreateNote.SuspendLayout();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCreateNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pnlNotes);
            this.panel1.Controls.Add(this.pnlSearchBar);
            this.panel1.Controls.Add(this.pnlCreateNote);
            this.panel1.Controls.Add(this.pnlBar);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 635);
            this.panel1.TabIndex = 0;
            // 
            // pnlNotes
            // 
            this.pnlNotes.Angles = 90F;
            this.pnlNotes.AutoScroll = true;
            this.pnlNotes.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.pnlNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlNotes.BorderColor = System.Drawing.Color.Transparent;
            this.pnlNotes.BorderRadius = 5;
            this.pnlNotes.BorderSize = 2;
            this.pnlNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotes.Location = new System.Drawing.Point(0, 188);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(317, 447);
            this.pnlNotes.TabIndex = 5;
            this.pnlNotes.SizeChanged += new System.EventHandler(this.pnlNotes_SizeChanged);
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlSearchBar.Controls.Add(this.txtSearches);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 128);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(317, 60);
            this.pnlSearchBar.TabIndex = 2;
            // 
            // txtSearches
            // 
            this.txtSearches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtSearches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearches.BorderColor = System.Drawing.Color.Empty;
            this.txtSearches.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtSearches.BorderRadius = 5;
            this.txtSearches.BorderSize = 2;
            this.txtSearches.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtSearches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearches.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearches.Location = new System.Drawing.Point(8, 12);
            this.txtSearches.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearches.MultiLine = false;
            this.txtSearches.Name = "txtSearches";
            this.txtSearches.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearches.PasswordChar = false;
            this.txtSearches.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearches.PlaceholderText = "Search";
            this.txtSearches.Size = new System.Drawing.Size(302, 36);
            this.txtSearches.TabIndex = 0;
            this.txtSearches.Texts = "";
            this.txtSearches.UnderlinedStyle = true;
            this.txtSearches._TextChanged += new System.EventHandler(this.txtSearches_TextChanged);
            // 
            // pnlCreateNote
            // 
            this.pnlCreateNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlCreateNote.Controls.Add(this.btnCreateNote);
            this.pnlCreateNote.Controls.Add(this.txtCreateNoteName);
            this.pnlCreateNote.Controls.Add(this.panel6);
            this.pnlCreateNote.Controls.Add(this.lblCreateNoteName);
            this.pnlCreateNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateNote.Location = new System.Drawing.Point(0, 38);
            this.pnlCreateNote.Name = "pnlCreateNote";
            this.pnlCreateNote.Size = new System.Drawing.Size(317, 90);
            this.pnlCreateNote.TabIndex = 3;
            this.pnlCreateNote.Visible = false;
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNote.Angles = 90F;
            this.btnCreateNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCreateNote.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnCreateNote.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreateNote.BorderRadius = 10;
            this.btnCreateNote.BorderSize = 0;
            this.btnCreateNote.ColorBottom = System.Drawing.Color.White;
            this.btnCreateNote.ColorTop = System.Drawing.Color.White;
            this.btnCreateNote.FlatAppearance.BorderSize = 0;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateNote.Location = new System.Drawing.Point(230, 39);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(77, 36);
            this.btnCreateNote.TabIndex = 0;
            this.btnCreateNote.Text = "Create";
            this.btnCreateNote.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateNote.UseVisualStyleBackColor = false;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // txtCreateNoteName
            // 
            this.txtCreateNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreateNoteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtCreateNoteName.BorderColor = System.Drawing.Color.Empty;
            this.txtCreateNoteName.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtCreateNoteName.BorderRadius = 10;
            this.txtCreateNoteName.BorderSize = 2;
            this.txtCreateNoteName.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtCreateNoteName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCreateNoteName.Location = new System.Drawing.Point(11, 39);
            this.txtCreateNoteName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateNoteName.MultiLine = false;
            this.txtCreateNoteName.Name = "txtCreateNoteName";
            this.txtCreateNoteName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCreateNoteName.PasswordChar = false;
            this.txtCreateNoteName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCreateNoteName.PlaceholderText = "Enter the Note Name";
            this.txtCreateNoteName.Size = new System.Drawing.Size(215, 36);
            this.txtCreateNoteName.TabIndex = 7;
            this.txtCreateNoteName.Texts = "";
            this.txtCreateNoteName.UnderlinedStyle = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 4);
            this.panel6.TabIndex = 6;
            // 
            // lblCreateNoteName
            // 
            this.lblCreateNoteName.AutoSize = true;
            this.lblCreateNoteName.ForeColor = System.Drawing.Color.White;
            this.lblCreateNoteName.Location = new System.Drawing.Point(6, 16);
            this.lblCreateNoteName.Name = "lblCreateNoteName";
            this.lblCreateNoteName.Size = new System.Drawing.Size(93, 19);
            this.lblCreateNoteName.TabIndex = 2;
            this.lblCreateNoteName.Text = "Note Name";
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBar.Controls.Add(this.btnShowCreateNote);
            this.pnlBar.Controls.Add(this.btnClosed);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(317, 38);
            this.pnlBar.TabIndex = 1;
            this.pnlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseDown);
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            this.pnlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseUp);
            // 
            // btnShowCreateNote
            // 
            this.btnShowCreateNote.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCreateNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowCreateNote.Image = global::StickyNote.Properties.Resources.Plus;
            this.btnShowCreateNote.Location = new System.Drawing.Point(0, 0);
            this.btnShowCreateNote.Name = "btnShowCreateNote";
            this.btnShowCreateNote.Size = new System.Drawing.Size(38, 38);
            this.btnShowCreateNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShowCreateNote.TabIndex = 2;
            this.btnShowCreateNote.TabStop = false;
            this.btnShowCreateNote.Click += new System.EventHandler(this.btnShowCreateNote_Click);
            this.btnShowCreateNote.MouseEnter += new System.EventHandler(this.btnShowCreateNote_MouseEnter);
            this.btnShowCreateNote.MouseLeave += new System.EventHandler(this.btnShowCreateNote_MouseLeave);
            // 
            // btnClosed
            // 
            this.btnClosed.BackColor = System.Drawing.Color.Transparent;
            this.btnClosed.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosed.Image = global::StickyNote.Properties.Resources.Close;
            this.btnClosed.Location = new System.Drawing.Point(279, 0);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(38, 38);
            this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClosed.TabIndex = 0;
            this.btnClosed.TabStop = false;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            this.btnClosed.MouseEnter += new System.EventHandler(this.btnShowCreateNote_MouseEnter);
            this.btnClosed.MouseLeave += new System.EventHandler(this.btnShowCreateNote_MouseLeave);
            // 
            // frmNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(321, 640);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNoteList";
            this.Text = "frmNoteList";
            this.panel1.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlCreateNote.ResumeLayout(false);
            this.pnlCreateNote.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCreateNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.PictureBox btnShowCreateNote;
        private System.Windows.Forms.PictureBox btnClosed;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Panel pnlCreateNote;
        private System.Windows.Forms.Label lblCreateNoteName;
        private System.Windows.Forms.Panel panel6;
        private kysToolDemo.KysTools.KYSTextBox txtCreateNoteName;
        private kysToolDemo.KysTools.KYSTextBox txtSearches;
        private kysToolDemo.KysTools.KYSPanel pnlNotes;
        private kysToolDemo.KysTools.KYSButton btnCreateNote;
    }
}