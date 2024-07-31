namespace EncryptedNotes.Models
{
    partial class Note
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoteCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeNoteNameToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.DeleteNoteCMSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnNoteSettings = new System.Windows.Forms.PictureBox();
            this.lblNoteName = new System.Windows.Forms.Label();
            this.NoteCMS.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoteSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 4);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.Note_Click);
            // 
            // NoteCMS
            // 
            this.NoteCMS.BackColor = System.Drawing.Color.Khaki;
            this.NoteCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNoteNameToolStripMenuItem,
            this.DeleteNoteCMSItem});
            this.NoteCMS.Name = "contextMenuStrip1";
            this.NoteCMS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.NoteCMS.Size = new System.Drawing.Size(241, 51);
            // 
            // changeNoteNameToolStripMenuItem
            // 
            this.changeNoteNameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeNoteNameToolStripMenuItem.Name = "changeNoteNameToolStripMenuItem";
            this.changeNoteNameToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.changeNoteNameToolStripMenuItem.Text = "Change Note Name";
            this.changeNoteNameToolStripMenuItem.TextChanged += new System.EventHandler(this.changeNoteNameToolStripMenuItem_TextChanged);
            // 
            // DeleteNoteCMSItem
            // 
            this.DeleteNoteCMSItem.Name = "DeleteNoteCMSItem";
            this.DeleteNoteCMSItem.Size = new System.Drawing.Size(240, 22);
            this.DeleteNoteCMSItem.Text = "Remove Note";
            this.DeleteNoteCMSItem.Click += new System.EventHandler(this.DeleteNoteCMSItem_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnNoteSettings);
            this.pnlBody.Controls.Add(this.lblNoteName);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(262, 78);
            this.pnlBody.TabIndex = 2;
            this.pnlBody.DoubleClick += new System.EventHandler(this.Note_Click);
            this.pnlBody.MouseEnter += new System.EventHandler(this.note_MouseEnter);
            this.pnlBody.MouseLeave += new System.EventHandler(this.note_MouseLeave);
            // 
            // btnNoteSettings
            // 
            this.btnNoteSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoteSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnNoteSettings.Image = global::StickyNote.Properties.Resources.DotMenu;
            this.btnNoteSettings.Location = new System.Drawing.Point(234, 7);
            this.btnNoteSettings.Name = "btnNoteSettings";
            this.btnNoteSettings.Size = new System.Drawing.Size(25, 25);
            this.btnNoteSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNoteSettings.TabIndex = 5;
            this.btnNoteSettings.TabStop = false;
            this.btnNoteSettings.Visible = false;
            this.btnNoteSettings.Click += new System.EventHandler(this.btnNoteSettings_Click);
            this.btnNoteSettings.MouseEnter += new System.EventHandler(this.note_MouseEnter);
            this.btnNoteSettings.MouseLeave += new System.EventHandler(this.note_MouseLeave);
            // 
            // lblNoteName
            // 
            this.lblNoteName.ForeColor = System.Drawing.Color.LightGray;
            this.lblNoteName.Location = new System.Drawing.Point(11, 10);
            this.lblNoteName.Name = "lblNoteName";
            this.lblNoteName.Size = new System.Drawing.Size(225, 25);
            this.lblNoteName.TabIndex = 4;
            this.lblNoteName.Text = "label1";
            this.lblNoteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoteName.DoubleClick += new System.EventHandler(this.Note_Click);
            this.lblNoteName.MouseEnter += new System.EventHandler(this.note_MouseEnter);
            this.lblNoteName.MouseLeave += new System.EventHandler(this.note_MouseLeave);
            // 
            // Note
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ContextMenuStrip = this.NoteCMS;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Note";
            this.Size = new System.Drawing.Size(262, 82);
            this.DoubleClick += new System.EventHandler(this.Note_Click);
            this.NoteCMS.ResumeLayout(false);
            this.NoteCMS.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNoteSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip NoteCMS;
        private System.Windows.Forms.ToolStripMenuItem DeleteNoteCMSItem;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.PictureBox btnNoteSettings;
        public System.Windows.Forms.Label lblNoteName;
        private System.Windows.Forms.ToolStripTextBox changeNoteNameToolStripMenuItem;
    }
}
