using EncryptedNotes.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.ViewModels
{
    static internal class NoteOperations
    {
        public static List<Note> notes = new List<Note>();
        static int firstNoteY = 20;

        public static void ToCreateList(Panel selectPanel)
        {
            notes.Clear();
            foreach (var item in DataOperations.ToList())
            {
                if (item.id != "0")
                {
                    Note note = new Note();
                    note.NoteID = item.id;
                    note.NoteTitle = item.title;
                    note.NotePath = item.path;
                    note.Name = "noteItem" + item.id;
                    note.Width = selectPanel.Width - (35);
                    note.lblNoteName.Text = item.title;
                    note.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    note.TakeValue();
                    notes.Add(note);
                }
            }
            ToListControls(selectPanel, ToList());
        }
        public static void ToListControls(Panel selectPanel, List<Note> list)
        {
            int i = 0;
            selectPanel.Controls.Clear();
            foreach (var item in list.ToList())
            {
                item.Location = new Point(10, firstNoteY + (i * (item.Size.Height + item.Height / 5)));
                i++;
                selectPanel.Controls.Add(item);
            }
        }
        public static void ToListSearch(Panel selectPanel, string searchValue)
        {
            selectPanel.Controls.Clear();
            List<Note> list = new List<Note>();
            if (searchValue != "")
                foreach (var item in notes)
                {
                    if (item.NoteTitle == searchValue && item.isNoteHiden)
                        list.Add(item);
                    if (item.NoteTitle.ToLower().Contains(searchValue.ToLower()) && !item.isNoteHiden)
                        list.Add(item);
                }
            else
                list = ToList();
            ToListControls(selectPanel, list);
        }
        public static void ResizeNotes()
        {
            if (notes.Count > 0)
                foreach (var item in notes)
                {
                    if (item.Parent != null)
                        item.Width = item.Parent.Width - (35);
                }
        }
        public static void AddNotes(string title, Panel selectPanel)
        {
            FileOperation.CreateStickyFile(title);
            ToCreateList(selectPanel);
        }
        public static void RemoveNotes(Note note)
        {
            notes.Remove(note);
            DataOperations.RemoveData(note.NoteID);
            FileOperation.DeleteFile(note.NotePath);
            ToListSearch(note.Parent as Panel, "");
        }
        public static List<Note> ToList()
        {
            return notes.Where(b => b.isNoteHiden != true).ToList();
        }
    }
}
