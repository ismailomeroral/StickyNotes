using EncryptedNotes.Models.Tools;
using EncryptedNotes.ViewModels;
using StickyNote.ViewModels.StyleEvents;
using System;
using System.Windows.Forms;
namespace EncryptedNotes.Models.Forms
{
    partial class frmEnterPassword : KYSForm
    {
        public frmEnterPassword()
        {
            InitializeComponent();
            FormMovedEvents fME = new FormMovedEvents();
            fME.SetForm(this, pnlBar);
        }
        private string password;
        private Note note;
        public void setNoteInfo(string _password, Note _note)
        {
            password = _password;
            note = _note;
            pnlBar.BackColor = note.NoteColor;
            txtEnterPassword.BorderFocusColor = note.NoteColor;
        }
        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if (password == txtEnterPassword.Texts)
            {
                NoteOperations.RemoveNotes(note);
                this.Close();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
