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
namespace EncryptedNotes.Models.Forms
{
    public partial class frmEnterPassword : Form
    {
        public frmEnterPassword()
        {
            InitializeComponent();
        }
        private string password;
        private Note note;
        public void setNoteInfo(string _password, Note _note)
        {
            password = _password;
            note = _note;
            pnlBar.BackColor = note.NoteColor;
        }
        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            if (password == txtEnterPassword.Texts)
            {
                NoteOperations.RemoveNotes(note);
                this.Close();
            }

        }


        int mow, mowY, mowX;
        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
