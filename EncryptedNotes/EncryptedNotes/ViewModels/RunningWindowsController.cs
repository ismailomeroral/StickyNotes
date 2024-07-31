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
        /// <Summary>
        /// Açık olan pencereleri tutan bir liste oluşturur.
        /// </Summary>
        static private List<Form> OpeningWindows = new List<Form>();

        /// <Summary>
        /// Yeni açılan bir pencereyi listeye ekler.
        /// </Summary>
        /// <param name="frm">Eklenmesi gereken form.</param>
        public static void NewOpenedWindow(Form frm)
        {
            if (!WindowControl(frm))
                OpeningWindows.Add(frm);
        }

        /// <Summary>
        /// Açık olan bir pencereyi listeden kaldırır ve tüm pencerelerin kapalı olup olmadığını kontrol eder.
        /// </Summary>
        /// <param name="frm">Kapatılacak form.</param>
        public static void CloseOpenedWindow(Form frm)
        {
            OpeningWindows.Remove(frm);
            IsAllClosedWindows();
        }

        /// <Summary>
        /// Açık olan tüm pencereleri liste olarak döndürür.
        /// </Summary>
        /// <Returns>
        /// Açık olan pencerelerin bulunduğu Form listesi döndürür.
        /// </Returns>
        public static List<Form> ToList()
        {
            return OpeningWindows;
        }

        /// <Summary>
        /// Belirtilen pencerenin zaten açık olup olmadığını kontrol eder.
        /// </Summary>
        /// <Returns>
        /// Eğer form açıksa true, değilse false döndürür.
        /// </Returns>
        /// <param name="frm">Kontrol edilecek form.</param>
        public static bool WindowControl(Form frm)
        {
            return !(OpeningWindows.Where(b => b == frm).Count() == 0);
        }

        /// <Summary>
        /// Uygulamayı kapatır.
        /// </Summary>
        public static void AppClose()
        {
            Application.Exit();
        }

        /// <Summary>
        /// Açık olan pencereler listesindeki belirli bir pencereyi indekse göre döndürür.
        /// </Summary>
        /// <Returns>
        /// Belirtilen indekste bulunan formu döndürür.
        /// </Returns>
        /// <param name="index">Erişilecek formun indeksi.</param>
        public static Form ListByIndex(int index)
        {
            return OpeningWindows[index];
        }

        /// <Summary>
        /// Ana pencereyi açar ve odaklar.
        /// </Summary>
        public static void OpenMainWindow()
        {
            OpeningWindows[0].Show();
            OpeningWindows[0].Focus();
        }

        /// <Summary>
        /// Tüm pencerelerin kapalı olup olmadığını kontrol eder ve eğer kapalıysa uygulamayı kapatır.
        /// </Summary>
        public static void IsAllClosedWindows()
        {
            if (OpeningWindows.Count() <= 1 && !OpeningWindows[0].Visible)
            {
                AppClose();
            }
        }
    }
}
