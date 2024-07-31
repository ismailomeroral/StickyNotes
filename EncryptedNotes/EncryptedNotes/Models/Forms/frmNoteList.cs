using EncryptedNotes.Models.Tools;
using EncryptedNotes.ViewModels;
using EncryptedNotes.ViewModels.StyleEvents;
using StickyNote.ViewModels.StyleEvents;
using System;
using System.Drawing;

namespace EncryptedNotes.Models.Forms
{
    partial class frmNoteList : KYSForm
    {
        public frmNoteList()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            FileOperation.DirectoryStartControl();
            RunningWindowsController.NewOpenedWindow(this);
            NoteOperations.CreateList(pnlNotes);
            btnClosed.MouseEnter += StyleEvent.Object_MouseEnter;
            btnClosed.MouseLeave += StyleEvent.Object_MouseLeave;
            btnShowCreateNote.MouseEnter += StyleEvent.Object_MouseEnter;
            btnShowCreateNote.MouseLeave += StyleEvent.Object_MouseLeave;
            FormMovedEvents fME = new FormMovedEvents();
            fME.SetForm(this, pnlBar);
        }

        bool scn = false;
        private void btnShowCreateNote_Click(object sender, EventArgs e)
        {
            scn = !scn;
            pnlCreateNote.Visible = scn;
            txtCreateNoteName.Focus();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            if (txtCreateNoteName.Texts != "")
            {
                NoteOperations.AddNote(txtCreateNoteName.Texts, pnlNotes);
                pnlCreateNote.Visible = false;
                txtCreateNoteName.Texts = "";
                lblCreateNoteName.ForeColor = Color.WhiteSmoke;
            }
            else
                lblCreateNoteName.ForeColor = Color.Red;
        }

        private void txtSearches_TextChanged(object sender, EventArgs e)
        {
            NoteOperations.Search(pnlNotes, txtSearches.Texts);

        }
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunningWindowsController.IsAllClosedWindows();
        }

        private void pnlNotes_SizeChanged(object sender, EventArgs e)
        {
            NoteOperations.ResizeNotes();
        }
    }
}
