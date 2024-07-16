using EncryptedNotes.Models.Forms;
using EncryptedNotes.ViewModels;
using EncryptedNotes.ViewModels.StyleEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.Models
{
    public partial class Note : UserControl
    {
        public Note()
        {
            InitializeComponent();

        }
        public string NoteID { get; set; }
        public string NoteTitle { get; set; }
        public string NotePath { get; set; }
        public bool isNoteHiden { get; set; }
        public Color NoteColor { get; set; }

        private List<PatternInformation> PatternList;
        public void TakeValue()
        {
            PatternList = StickyTextOperations.SendPattern(FileOperation.OpenFileAndLoad(NotePath));
            isNoteHiden = StickyTextOperations.SelectContext("Visibility", PatternList) == "True" ? true : false;
            NoteColor = Color.FromName(StickyTextOperations.SelectContext("Color", PatternList));
            panel1.BackColor = NoteColor;
            changeNoteNameToolStripMenuItem.Text = lblNoteName.Text;
        }
        frmStickyNote frm = new frmStickyNote();
        private void Note_Click(object sender, EventArgs e)
        {
            if (!RunningWindowsController.WindowControl(frm))
                frm = new frmStickyNote();
            RunningWindowsController.NewOpenedWindow(frm);
            frm.SetNote(NoteID, NoteTitle, NotePath, PatternList, NoteColor, this);
            frm.Text = NoteTitle;
            frm.Show();
            frm.Focus();
        }
        private void DeleteNoteCMSItem_Click(object sender, EventArgs e)
        {
            string password = StickyTextOperations.SelectContext("Password", PatternList);
            if (!StickyTextOperations.PasswordControl(password))
                NoteOperations.RemoveNotes(this);
            else
            {
                frmEnterPassword frm = new frmEnterPassword();
                frm.setNoteInfo(password, this);
                frm.ShowDialog();
            }
        }
        private void note_MouseEnter(object sender, EventArgs e)
        {
            StyleEvent.BGColorChange(pnlBody, Color.FromArgb(50, 50, 50));
            btnNoteSettings.Visible = true;
        }
        private void note_MouseLeave(object sender, EventArgs e)
        {
            StyleEvent.BGColorChange(pnlBody, Color.FromArgb(65, 65, 65));
            btnNoteSettings.Visible = false;
        }

        private void changeNoteNameToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            DataOperations.UpdateData(NoteID, changeNoteNameToolStripMenuItem.Text);
            lblNoteName.Text = changeNoteNameToolStripMenuItem.Text;
        }

        private void btnNoteSettings_Click(object sender, EventArgs e)
        {
            NoteCMS.Show(MousePosition);
        }
    }
}
