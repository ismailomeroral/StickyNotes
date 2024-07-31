using EncryptedNotes.Models.Forms;
using EncryptedNotes.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNote.ViewModels.StyleEvents
{
    internal class FormMovedEvents
    {
        /// <Summary>
        /// Formu taşıma işlemlerini kontrol etmek için kullanılır.
        /// </Summary>
        int mow, mowY, mowX;
        private KYSForm frm;

        /// <Summary>
        /// Formun taşınması için gerekli olayları ayarlar.
        /// </Summary>
        /// <param name="_frm">Taşınacak form nesnesi.</param>
        /// <param name="selectPanel">Taşıma işlemi için kullanılacak panel.</param>
        public void SetForm(KYSForm _frm,Panel selectPanel)
        {
            frm = _frm;
            selectPanel.MouseMove += MovedForm_Move;
            selectPanel.MouseDown += MovedForm_Down;
            selectPanel.MouseUp += MovedForm_Up;
        }

        /// <Summary>
        /// Fare hareket ettikçe formun taşınmasını sağlar.
        /// </Summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Fare olay verisi.</param>
        private void MovedForm_Move(object sender, MouseEventArgs e)
        {
            if (mow == 1)
            {
                frm.SetDesktop(mowX, mowY);
            }
        }

        /// <Summary>
        /// Fare tuşuna basıldığında formun taşınmaya hazır hale gelmesini sağlar.
        /// </Summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Fare olay verisi.</param>
        private void MovedForm_Down(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        /// <Summary>
        /// Fare tuşu bırakıldığında formun taşınmasını durdurur.
        /// </Summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Fare olay verisi.</param>
        private void MovedForm_Up(object sender, MouseEventArgs e)
        {
            mow = 0;
        }
    }
}
