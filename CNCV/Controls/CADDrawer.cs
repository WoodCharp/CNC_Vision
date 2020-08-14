using CCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCV.Controls
{
    public class CADDrawer : Control, IControl
    {
        [Browsable(false)]
        public CSkinManager SkinManager => CSkinManager.Instance;

        public Color BackgroundColor { get; set; } = Color.LightGray;
        public Color GridColor { get; set; } = Color.Black;

        public float GridSize { get; set; } = 10;
        public int GridDotSize { get; set; } = 2;

        public CADDrawer()
        {

        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackgroundColor);

            int hDots = (int)(ClientRectangle.Height / GridSize);
            int wDots = (int)(ClientRectangle.Width / GridSize) + 1;

            //Draw grid
            for (int x = 0; x < wDots; x++)
            {
                e.Graphics.FillRectangle(new SolidBrush(GridColor), new Rectangle(
                    (int)((GridSize * x) - (GridDotSize / 2)) + (int)GridSize,
                    (int)(GridSize - (GridDotSize / 2)) + (int)GridSize,
                    GridDotSize,
                    GridDotSize
                    ));

                for (int y = 0; y < hDots; y++)
                {
                    e.Graphics.FillRectangle(new SolidBrush(GridColor), new Rectangle(
                        (int)((GridSize * x) - (GridDotSize / 2)) + (int)GridSize,
                        (int)((GridSize * y) - (GridDotSize / 2)) + (int)GridSize,
                        GridDotSize,
                        GridDotSize
                        ));
                }
            }

            //Draw objects

        }
    }
}
