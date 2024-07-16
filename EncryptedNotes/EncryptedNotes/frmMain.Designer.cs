namespace EncryptedNotes
{
    partial class frmMain
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
            this.btnShowCreatePanel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.pnlCreateNote = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCreateNote = new System.Windows.Forms.TextBox();
            this.lblCreateNoteName = new System.Windows.Forms.Label();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlCreateNote.SuspendLayout();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowCreatePanel
            // 
            this.btnShowCreatePanel.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnShowCreatePanel.Location = new System.Drawing.Point(0, 4);
            this.btnShowCreatePanel.Name = "btnShowCreatePanel";
            this.btnShowCreatePanel.Size = new System.Drawing.Size(54, 35);
            this.btnShowCreatePanel.TabIndex = 0;
            this.btnShowCreatePanel.Text = "New";
            this.btnShowCreatePanel.UseVisualStyleBackColor = true;
            this.btnShowCreatePanel.Click += new System.EventHandler(this.btnShowCreatePanel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(60, 6);
            this.txtSearch.MaxLength = 200;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 33);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pnlNote);
            this.panel1.Controls.Add(this.pnlCreateNote);
            this.panel1.Controls.Add(this.pnlBar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 577);
            this.panel1.TabIndex = 4;
            // 
            // pnlNote
            // 
            this.pnlNote.AutoScroll = true;
            this.pnlNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNote.Location = new System.Drawing.Point(0, 117);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(300, 460);
            this.pnlNote.TabIndex = 6;
            // 
            // pnlCreateNote
            // 
            this.pnlCreateNote.BackColor = System.Drawing.Color.LightGray;
            this.pnlCreateNote.Controls.Add(this.panel2);
            this.pnlCreateNote.Controls.Add(this.button2);
            this.pnlCreateNote.Controls.Add(this.txtCreateNote);
            this.pnlCreateNote.Controls.Add(this.lblCreateNoteName);
            this.pnlCreateNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateNote.Location = new System.Drawing.Point(0, 47);
            this.pnlCreateNote.Name = "pnlCreateNote";
            this.pnlCreateNote.Size = new System.Drawing.Size(300, 70);
            this.pnlCreateNote.TabIndex = 5;
            this.pnlCreateNote.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 5);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCreateNote
            // 
            this.txtCreateNote.Location = new System.Drawing.Point(7, 30);
            this.txtCreateNote.Name = "txtCreateNote";
            this.txtCreateNote.Size = new System.Drawing.Size(216, 31);
            this.txtCreateNote.TabIndex = 1;
            // 
            // lblCreateNoteName
            // 
            this.lblCreateNoteName.AutoSize = true;
            this.lblCreateNoteName.Location = new System.Drawing.Point(3, 8);
            this.lblCreateNoteName.Name = "lblCreateNoteName";
            this.lblCreateNoteName.Size = new System.Drawing.Size(93, 19);
            this.lblCreateNoteName.TabIndex = 0;
            this.lblCreateNoteName.Text = "Note Name";
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.LightGray;
            this.pnlBar.Controls.Add(this.txtSearch);
            this.pnlBar.Controls.Add(this.btnShowCreatePanel);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(300, 47);
            this.pnlBar.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(324, 601);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Notes";
            this.panel1.ResumeLayout(false);
            this.pnlCreateNote.ResumeLayout(false);
            this.pnlCreateNote.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCreatePanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlCreateNote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCreateNote;
        private System.Windows.Forms.Label lblCreateNoteName;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Panel panel2;
    }
}

