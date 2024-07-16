using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace kysToolDemo.KysTools
{
    public class KYSToggleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = false;

        [Category("Appearance")]
        public Color OnBackColor
        {
            get { return onBackColor; }
            set { onBackColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color OnToggleColor
        {
            get { return onToggleColor; }
            set { onToggleColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color OffBackColor
        {
            get { return offBackColor; }
            set { offBackColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color OffToggleColor
        {
            get { return offToggleColor; }
            set { offToggleColor = value; this.Invalidate(); }
        }

        public override string Text
        {
            get { return base.Text; }
            set { }
        }

        [DefaultValue(false)]
        [Category("Appearance")]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set { solidStyle = value; this.Invalidate(); }
        }

        public KYSToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5; // Adjusted to ensure proper toggle size
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) // On
            {
                if (SolidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else // Off
            {
                if (SolidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

    }
}
