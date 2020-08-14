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
    public class GCodeViewer : Control, IControl
    {
        [Browsable(false)]
        public CSkinManager SkinManager => CSkinManager.Instance;

        public List<string> GCodeLines;
        public int Ratio = 1;

        #region Properties

        private bool _DrawBorder = true;
        [Category("0 CCL")]
        [Browsable(true)]
        [Description("Draw border around control.")]
        public bool DrawBorder
        {
            get { return _DrawBorder; }
            set { _DrawBorder = value; Invalidate(); }
        }

        #endregion

        public GCodeViewer()
        {
            GCodeLines = new List<string>();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(SkinManager.GetScheme().BackgroundColor);

            using(Pen p = new Pen(SkinManager.GetScheme().SchemeBrush, 1))
            {
                if (GCodeLines != null && GCodeLines.Count > 0)
                {
                    for (int i = 0; i < GCodeLines.Count; i++)
                    {

                    }
                }

                if (DrawBorder)
                    e.Graphics.DrawRectangle(p, new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1));
            }
        }
    }
}
