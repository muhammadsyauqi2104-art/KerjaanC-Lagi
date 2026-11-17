using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LatihanProjek1
{
    public class SisiLengkungPanel : Label
    {
        private int _cornerRadius = 15;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Appearance")]
        [Description("Menentukan tingkat kelengkungan sudut.")]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                int r = _cornerRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.X + rect.Width - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.X + rect.Width - r, rect.Y + rect.Height - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - r, r, r, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }
    }
}