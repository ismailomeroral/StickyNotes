using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.ViewModels.StyleEvents
{
    internal static class StyleEvent
    {
        /// <Summary>
        /// Belirtilen panelin arka plan rengini değiştirir.
        /// </Summary>
        /// <param name="panel">Rengi değiştirilecek panel.</param>
        /// <param name="color">Panelin yeni arka plan rengi.</param>
        public static void BGColorChange(Panel panel, Color color)
        {
            panel.BackColor = color;
        }

        /// <Summary>
        /// Fare imleci bir nesnenin üzerine geldiğinde çağrılır. Nesneyi seçili olarak işaretler.
        /// </Summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay verisi.</param>
        public static void Object_MouseEnter(object sender, EventArgs e)
        {
            ObjectSelect((sender as Control), true);
        }

        /// <Summary>
        /// Fare imleci bir nesnenin üzerinden ayrıldığında çağrılır. Nesneyi seçili olmayan duruma getirir.
        /// </Summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay verisi.</param>
        public static void Object_MouseLeave(object sender, EventArgs e)
        {
            ObjectSelect((sender as Control), false);
        }

        /// <Summary>
        /// Bir nesneyi seçili olan ve seçili olmayan durumlara göre arkaplan rengini değiştirir.
        /// </Summary>
        /// <param name="control">Seçilecek veya seçili olmayan duruma getirilecek kontrol.</param>
        /// <param name="activate">Seçim durumu: `true` ise seçili, `false` ise seçili değil.</param>
        private static void ObjectSelect(Control control, bool activate)
        {
            if (activate)
                control.BackColor = Color.FromArgb(50, 0, 0, 0);
            else
                control.BackColor = Color.Transparent;
        }
    }
}
