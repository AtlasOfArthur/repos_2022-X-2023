using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonsForm
{
    internal class TriangleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graph = pevent.Graphics;
            graph.SmoothingMode= SmoothingMode.AntiAlias;
            float h = this.Height;
            float w = this.Width;

            PointF[] triPoints = new PointF[] { new PointF(w / 2, 0), new PointF(0, w), new PointF(w, h) };
            graph.FillPolygon(new SolidBrush(this.BackColor), triPoints );
            GraphicsPath grPTH = new GraphicsPath();
            grPTH.AddPolygon( triPoints );

            this.Region = new Region( grPTH );

            base.OnPaint(pevent);
        }
    }
}
