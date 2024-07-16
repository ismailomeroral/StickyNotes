using EncryptedNotes.Models.Tools;
using EncryptedNotes.ViewModels;
using EncryptedNotes.ViewModels.StyleEvents;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptedNotes.Models.Forms
{
    partial class frmNoteList : KYSForm
    {
        public frmNoteList()
        {
            InitializeComponent();
            FileOperation.DirectoryStartControl();
            RunningWindowsController.NewOpenedWindow(this);
            NoteOperations.ToCreateList(pnlNotes);
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
                NoteOperations.AddNotes(txtCreateNoteName.Texts, pnlNotes);
                pnlCreateNote.Visible = false;
                txtCreateNoteName.Texts = "";
                lblCreateNoteName.ForeColor = Color.Black;
            }
            else
                lblCreateNoteName.ForeColor = Color.Red;
        }

        private void txtSearches_TextChanged(object sender, EventArgs e)
        {
            NoteOperations.ToListSearch(pnlNotes, txtSearches.Texts);

        }
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunningWindowsController.IsAllClosedWindows();
        }

        int mow, mowY, mowX;

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        private void btnShowCreateNote_MouseEnter(object sender, EventArgs e)
        {
            StyleEvent.BGColorChange((sender as PictureBox), Color.FromArgb(30, 30, 30));
        }

        private void btnShowCreateNote_MouseLeave(object sender, EventArgs e)
        {
            StyleEvent.BGColorChange((sender as PictureBox), (sender as PictureBox).Parent.BackColor);
        }

        private void pnlNotes_SizeChanged(object sender, EventArgs e)
        {
            NoteOperations.ResizeNotes();
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
