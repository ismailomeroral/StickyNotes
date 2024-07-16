using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.ViewModels
{
    static internal class RunningWindowsController
    {
        static private List<Form> OpeningWindows = new List<Form>();

        public static void NewOpenedWindow(Form frm)
        {
            if (!WindowControl(frm))
                OpeningWindows.Add(frm);
        }
        public static void CloseOpenedWindow(Form frm)
        {
            OpeningWindows.Remove(frm);
            IsAllClosedWindows();
        }
        public static List<Form> ToList()
        {
            return OpeningWindows;
        }
        public static bool WindowControl(Form frm)
        {
            return !(OpeningWindows.Where(b => b == frm).Count() == 0);
        }
        public static void AppClose()
        {
            Application.Exit();
        }
        public static Form ToListByIndex(int index)
        {
            return OpeningWindows[index];
        }
        public static void OpenMainWindow()
        {
            OpeningWindows[0].Show();
            OpeningWindows[0].Focus();
        }
        public static void IsAllClosedWindows()
        {
            if (OpeningWindows.Count() <= 1 && !OpeningWindows[0].Visible)
            {
                AppClose();
            }
        }
    }
}
