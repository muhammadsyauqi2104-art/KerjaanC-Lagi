using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LatihanProjek1
{
    public class RoundedButton : Button
    {
        private int _cornerRadius = 15;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Appearance")]
        [Description("Menentukan tingkat kelengkungan sudut tombol.")]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


            Rectangle rectSurface = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectBorder = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            int r = _cornerRadius;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, r))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, r))
            using (Pen penBorder = new Pen(Color.FromArgb(200, 200, 200), 1.5f))
            {

                this.Region = new Region(pathSurface);


                pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }


        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curve = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curve, curve, 180, 90);
            path.AddArc(rect.X + rect.Width - curve, rect.Y, curve, curve, 270, 90);
            path.AddArc(rect.X + rect.Width - curve, rect.Y + rect.Height - curve, curve, curve, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - curve, curve, curve, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}