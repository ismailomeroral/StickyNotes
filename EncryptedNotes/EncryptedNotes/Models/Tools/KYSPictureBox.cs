using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.Models.Tools
{
    internal class KYSPictureBox : PictureBox
    {
        private float angles = 90f;
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.Transparent;

        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public float Angles { get => angles; set { angles = value; this.Invalidate(); } }

        public KYSPictureBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Resize += CustomTextBox_Resize;
        }

        private void CustomTextBox_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Update();
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.BackColor, this.BackColor, this.angles);
            Graphics graph = e.Graphics;
            graph.FillRectangle(lgb, this.ClientRectangle);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    e.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            base.OnPaint(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public void SelectControl(Color selectColor)
        {
            if (BackColor == selectColor)
                Selected();
            else
                DeSelected();
        }
        public void Selected()
        {
            BorderSize = 2;
            BorderColor = Color.White;
        }
        public void DeSelected()
        {
            BorderSize = 1;
            BorderColor = Color.FromArgb(55, 55, 55);
        }
    }
}
