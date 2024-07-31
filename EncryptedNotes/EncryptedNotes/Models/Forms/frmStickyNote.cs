using EncryptedNotes.Models.Tools;
using EncryptedNotes.ViewModels;
using EncryptedNotes.ViewModels.StyleEvents;
using StickyNote.ViewModels.StyleEvents;
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
            foreach (KYSPictureBox item in pnlColor.Controls)
                NoteColors.Add(item);
            FormMovedEvents fME = new FormMovedEvents();
            fME.SetForm(this, pnlBar);
            btnClose.MouseEnter += StyleEvent.Object_MouseEnter;
            btnNoteList.MouseEnter += StyleEvent.Object_MouseEnter;
            btnClose.MouseLeave += StyleEvent.Object_MouseLeave;
            btnNoteList.MouseLeave += StyleEvent.Object_MouseLeave;
        }
        private string Id { get; set; }
        private string Title { get; set; }
        private string Path { get; set; }
        private Color ThisColor { get; set; }
        List<PatternInformation> PatternList { get; set; }
        List<PictureBox> NoteColors = new List<PictureBox>();
        Note ThisNote { get; set; }

        public void SetNote(string _Id, string _Title, string _Path, List<PatternInformation> list, Color _Color, Note note)
        {
            Id = _Id;
            Title = _Title;
            Path = _Path;
            PatternList = list;
            this.Text = Title;
            ThisColor = _Color;
            ThisNote = note;
            if (StickyTextOperations.ControlPassword(StickyTextOperations.SelectContext("Password", PatternList)))
                DeActivates();
            else
                Activates();
        }
        private void Activates()
        {
            isPasswordEnter = true;
            pnlEnterPassword.Visible = false;
            pnlBody.Visible = true;
            this.Height = 380;
            pnlBar.BackColor = ThisColor;
            txtTitle.BorderColor = ThisColor;
            txtTitle.BorderFocusColor = ThisColor;
            txtTitle.Texts = StickyTextOperations.SelectContext("Title", PatternList);
            txtBody.Text = StickyTextOperations.SelectContext("Body", PatternList);
            txtKey.Texts = StickyTextOperations.SelectContext("Key", PatternList);
            txtPassword.Texts = StickyTextOperations.SelectContext("Password", PatternList);
            chboxHide.Checked = (StickyTextOperations.SelectContext("Visibility", PatternList) == "True" ? true : false);
            PctControl();
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
                    pnlBar.Height = pnlSettings.Height + 24;
                else
                    pnlBar.Height = 24;
            }
        }
        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if (StickyTextOperations.CheckPassword(txtEnterPassword.Texts, StickyTextOperations.SelectContext("Password", PatternList)))
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
            ThisColor = (sender as KYSPictureBox).BackColor;
            StickyTextOperations.SaveContext("Color",ThisColor.Name, PatternList, Path);
            ThisNote.TakeValue();
            PctControl();
            pnlBar.BackColor = ThisColor;
            txtTitle.BorderColor = ThisColor;
            txtTitle.BorderFocusColor = ThisColor;
        }

        private void PctControl()
        {
            foreach (KYSPictureBox item in NoteColors)
                item.SelectControl(ThisColor);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            RunningWindowsController.CloseOpenedWindow(this);
            this.Close();
        }
        private void btnNoteList_Click(object sender, EventArgs e)
        {
            RunningWindowsController.OpenMainWindow();
        }

    }
}
