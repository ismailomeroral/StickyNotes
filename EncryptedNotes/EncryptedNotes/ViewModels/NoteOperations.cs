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
        /// <Summary>
        /// Notların listesini tutar.
        /// </Summary>
        public static List<Note> notes = new List<Note>();

        /// <Summary>
        /// İlk notun y eksenindeki başlangıç pozisyonunu belirler.
        /// </Summary>
        static int firstNoteY = 20;


        /// <Summary>
        /// Panel içindeki notları temizler ve veri tabanından gelen notları oluşturup listeye ekler.
        /// </Summary>
        /// <param name="selectPanel">Notların yerleştirileceği panel.</param>
        public static void CreateList(Panel selectPanel)
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
            ListToControls(selectPanel, ToList());
        }

        /// <Summary>
        /// Belirtilen paneldeki notları kontrol eder ve listelenir.
        /// </Summary>
        /// <param name="selectControl">Notların ekleneceği kontrol.</param>
        /// <param name="list">Listelenecek notların listesi.</param>
        public static void ListToControls(Panel selectControl, List<Note> list)
        {
            int i = 0;
            selectControl.Controls.Clear();
            foreach (var item in list.ToList())
            {
                item.Location = new Point(10, firstNoteY + (i * (item.Size.Height + item.Height / 5)));
                i++;
                selectControl.Controls.Add(item);
            }
        }

        /// <Summary>
        /// Belirtilen arama değeriyle notlar arasında arama yapar ve sonuçları listeler.
        /// </Summary>
        /// <param name="selectPanel">Arama sonuçlarının listeleneceği panel.</param>
        /// <param name="searchValue">Aranacak değer.</param>
        public static void Search(Panel selectPanel, string searchValue)
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
            ListToControls(selectPanel, list);
        }

        /// <Summary>
        /// Notların boyutlarını panelin genişliğine göre yeniden boyutlandırır.
        /// </Summary>
        public static void ResizeNotes()
        {
            if (notes.Count > 0) 
                foreach (var item in notes)
                {
                    if (item.Parent != null)
                        item.Width = item.Parent.Width - (35);
                }
        }

        /// <Summary>
        /// Yeni bir not ekler ve listeyi günceller.
        /// </Summary>
        /// <param name="title">Eklenecek notun başlığı.</param>
        /// <param name="selectPanel">Notların yerleştirileceği panel.</param>
        public static void AddNote(string title, Panel selectPanel)
        {
            FileOperation.CreateStickyFile(title);
            CreateList(selectPanel);
        }

        /// <Summary>
        /// Belirtilen notu listeden ve dosya sisteminden siler.
        /// </Summary>
        /// <param name="note">Silinecek not nesnesi.</param>
        public static void RemoveNotes(Note note)
        {
            notes.Remove(note);
            DataOperations.RemoveData(note.NoteID);
            FileOperation.DeleteFile(note.NotePath);
            Search(note.Parent as Panel, "");
        }

        /// <Summary>
        /// Görünür durumda olan notların listesini döndürür.
        /// </Summary>
        /// <Returns>
        /// Gizlenmemiş notların listesi döndürülür.
        /// </Returns>
        public static List<Note> ToList()
        {
            return notes.Where(b => b.isNoteHiden != true).ToList();
        }
    }
}
