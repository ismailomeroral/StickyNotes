using EncryptedNotes.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EncryptedNotes.Models.Forms
{
    internal partial class frmOldStickyNote : Form
    {
        public frmOldStickyNote()
        {
            InitializeComponent();
            RunningWindowsController.NewOpenedWindow(this);

        }
        private string Id { get; set; }
        private string Title { get; set; }
        private string Path { get; set; }
        List<PatternInformation> PatternList { get; set; }

        public void SetNote(string _Id, string _Title, string _Path, List<PatternInformation> list)
        {
            Id = _Id;
            Title = _Title;
            Path = _Path;
            PatternList = list;
            this.Text = Title;
            if (StickyTextOperations.PasswordControl(StickyTextOperations.SelectContext("Password", PatternList)))
                DeActivates();
            else
                Activates();
        }
        public void DeActivates()
        {
            pnlBody.Visible = false;
            this.Height = 40 + pnlEnterPassword.Height;
            pnlEnterPassword.Visible = true;
            pnlEnterPassword.Dock = DockStyle.Fill;
        }
        private void Activates()
        {
            pnlEnterPassword.Visible = false;
            pnlBody.Visible = true;
            this.Height = 10 + pnlBody.Height;
            pnlBody.Dock = DockStyle.Fill;

            txtBody.Text = StickyTextOperations.SelectContext("Body", PatternList);
            txtKey.Text = StickyTextOperations.SelectContext("Key", PatternList);
            txtPassword.Text = StickyTextOperations.SelectContext("Password", PatternList);
            txtTitle.Text = StickyTextOperations.SelectContext("Title", PatternList);
            chboxHide.Checked = (StickyTextOperations.SelectContext("Visibility", PatternList) == "True" ? true : false);
        }
        // Events

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Body", txtBody.Text, PatternList, Path);
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Title", txtTitle.Text, PatternList, Path);

            txtTitle.Height = 12 + ((txtTitle.GetLineFromCharIndex(txtTitle.Text.Length)+1 ) * 20);

            string[] lines = txtTitle.Lines;

            if (lines.Length > 3)
            {
                txtTitle.Lines = lines.Take(3).ToArray();
                txtTitle.SelectionStart = txtTitle.Text.Length;
            }
        }
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Key", txtKey.Text, PatternList, Path);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Password", txtPassword.Text, PatternList, Path);
        }
        private void chboxHide_CheckedChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Visibility", chboxHide.Checked.ToString(), PatternList, Path);

        }
        bool b = false;
        private void pnlSettings_Click(object sender, EventArgs e)
        {
            b = !b;
            if (b)
                pnlSettings.Height = pnlSettings.Height * 9;
            else
                pnlSettings.Height = pnlSettings.Height / 9;

        }
        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if (StickyTextOperations.PasswordChecked(txtEnterPassword.Text, StickyTextOperations.SelectContext("Password", PatternList)))
                Activates();
        }
    }
}
