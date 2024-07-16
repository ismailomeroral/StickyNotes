using EncryptedNotes.Models;
using EncryptedNotes.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptedNotes
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            RunningWindowsController.NewOpenedWindow(this);
            NoteOperations.ToCreateList(pnlNote);
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            NoteOperations.ToListSearch(pnlNote, txtSearch.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCreateNote.Text != "" && !txtCreateNote.Text.Contains(" "))
            {
                NoteOperations.AddNotes(txtCreateNote.Text, pnlNote);
                pnlCreateNote.Visible = false;
                txtCreateNote.Text = "";
                lblCreateNoteName.ForeColor = Color.Black;
            }
            else
                lblCreateNoteName.ForeColor = Color.Red;

        }
        bool b = false;
        private void btnShowCreatePanel_Click(object sender, EventArgs e)
        {
            b = !b;
            pnlCreateNote.Visible = b;

        }
    }
}

