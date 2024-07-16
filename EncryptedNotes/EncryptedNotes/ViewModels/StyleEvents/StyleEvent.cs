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
        public static void BGColorChange(Panel panel, Color color)
        {
            panel.BackColor = color;
        }
        public static void BGColorChange(Button button, Color color)
        {
            button.BackColor = color;
        }
        public static void BGColorChange(PictureBox pictureBox, Color color)
        {
            pictureBox.BackColor = color;
        }
    }
}
