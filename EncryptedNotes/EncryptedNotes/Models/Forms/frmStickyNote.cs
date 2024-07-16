using EncryptedNotes.Models.Tools;
using EncryptedNotes.ViewModels;
using EncryptedNotes.ViewModels.StyleEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.Models.Forms
{
    internal partial class frmStickyNote : KYSForm
    {
        public frmStickyNote()
        {
            InitializeComponent();
            NoteColors.Add(pctColor1);
            NoteColors.Add(pctColor2);
            NoteColors.Add(pctColor3);
            NoteColors.Add(pctColor4);
            NoteColors.Add(pctColor5);
            NoteColors.Add(pctColor6);
        }
        private string Id { get; set; }
        private string Title { get; set; }
        private string Path { get; set; }
        private Color ThisColor {  get; set; }
        List<PatternInformation> PatternList { get; set; }
        List<PictureBox> NoteColors = new List<PictureBox>();
        Note ThisNote { get; set; }

        public void SetNote(string _Id, string _Title, string _Path, List<PatternInformation> list,Color _Color, Note note)
        {
            Id = _Id;
            Title = _Title;
            Path = _Path;
            PatternList = list;
            this.Text = Title;
            ThisColor = _Color;
            ThisNote = note;
            if (StickyTextOperations.PasswordControl(StickyTextOperations.SelectContext("Password", PatternList)))
                DeActivates();
            else
                Activates();
        }
        private void Activates()
        {
            isPasswordEnter = true;
            pnlEnterPassword.Visible = false;
            pnlBody.Visible = true;
            this.Height = 360;
            pnlBody.Dock = DockStyle.Fill;
            pnlBar.BackColor = ThisColor;
            txtTitle.Texts = StickyTextOperations.SelectContext("Title", PatternList);
            txtTitle.BorderColor = ThisColor; 
            txtTitle.BorderFocusColor = ThisColor;
            txtBody.Text = StickyTextOperations.SelectContext("Body", PatternList);
            txtKey.Texts = StickyTextOperations.SelectContext("Key", PatternList);
            txtPassword.Texts = StickyTextOperations.SelectContext("Password", PatternList);
            chboxHide.Checked = (StickyTextOperations.SelectContext("Visibility", PatternList) == "True" ? true : false);
        }
        private void DeActivates()
        {
            pnlBody.Visible = false;
            this.Height = 24 + pnlEnterPassword.Height;
            pnlEnterPassword.Visible = true;
            pnlEnterPassword.Dock = DockStyle.Fill;
        }


        bool sopen = false;
        bool isPasswordEnter = false;
        private void pnlBar_Click(object sender, EventArgs e)
        {
            if (isPasswordEnter)
            {
                sopen = !sopen;
                if (sopen)
                    pnlBar.Height = 200;
                else
                    pnlBar.Height = 24;
            }
        }
        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if (StickyTextOperations.PasswordChecked(txtEnterPassword.Texts, StickyTextOperations.SelectContext("Password", PatternList)))
                Activates();
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Title", txtTitle.Texts, PatternList, Path);
        }
        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Body", txtBody.Text, PatternList, Path);
        }
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Key", txtKey.Texts, PatternList, Path);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Password", txtPassword.Texts, PatternList, Path);
        }
        private void chboxHide_CheckedChanged(object sender, EventArgs e)
        {
            StickyTextOperations.SaveContext("Visibility", chboxHide.Checked.ToString(), PatternList, Path);
            ThisNote.TakeValue();
        }
        private void pctColor(object sender, EventArgs e)
        {
            Selected((sender as KYSPictureBox));
            foreach (KYSPictureBox item in NoteColors.Where(b => b != (sender as KYSPictureBox)).ToList())
                DeSelected(item);
                StickyTextOperations.SaveContext("Color", (sender as KYSPictureBox).BackColor.Name, PatternList, Path);
            ThisNote.TakeValue();
            pnlBar.BackColor = (sender as KYSPictureBox).BackColor;
            txtTitle.BorderColor = (sender as KYSPictureBox).BackColor;
            txtTitle.BorderFocusColor = (sender as KYSPictureBox).BackColor;
        }
        public void Selected(KYSPictureBox pct)
        {
            pct.BorderSize = 2;
            pct.BorderColor = Color.White;
        }
        public void DeSelected(KYSPictureBox pct)
        {
            pct.BorderSize = 1;
            pct.BorderColor = Color.FromArgb(55, 55, 55);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            RunningWindowsController.CloseOpenedWindow(this);
            this.Close();
        }
        int mow, mowY, mowX;
        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }
        private void btnNoteList_Click(object sender, EventArgs e)
        {
            RunningWindowsController.OpenMainWindow();
        }
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            StyleEvent.BGColorChange((sender as PictureBox), Color.FromArgb(50, 0, 0, 0));
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            StyleEvent.BGColorChange((sender as PictureBox), (sender as PictureBox).Parent.BackColor);
        }
        private void pnlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mow = 0;
        }
        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mow == 1)
            {
                SetDesktopLocation(MousePosition.X - mowX, MousePosition.Y - mowY);
            }
        }
    }
}
