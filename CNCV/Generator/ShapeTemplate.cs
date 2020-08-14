using CCL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CNCV.Controls
{
    public class ShapeTemplate : Control, IControl
    {
        [Browsable(false)]
        public CSkinManager SkinManager => CSkinManager.Instance;

        #region Properties

        private string _Text = "Template Text Goes Here!!";
        [Category("0 CCL")]
        [Browsable(true)]
        [Description("Text.")]
        public override string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                Invalidate();
            }
        }

        private int _ID = 0;
        [Category("0 CCL")]
        [Browsable(true)]
        [Description("ID.")]
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }


        private Image _TemplateImage = null;
        [Category("0 CCL")]
        [Browsable(true)]
        [Description("Image")]
        public Image TemplateImage
        {
            get { return _TemplateImage; }
            set
            {
                _TemplateImage = value;
                Invalidate();
            }
        }

        private Size _FixedSize = new Size(200, 80);
        [Category("0 CCL")]
        [Browsable(true)]
        [Description("Fixed size")]
        public Size FixedSize
        {
            get { return _FixedSize; }
            set
            {
                _FixedSize = value;

                Size = value;
                ImageRect = new Rectangle(0, 0, value.Height, value.Height);
                TextRect = new Rectangle(value.Height, 0, value.Width - value.Height, value.Height);

                Invalidate();
            }
        }

        #endregion

        private Rectangle ImageRect;
        private Rectangle TextRect;

        private bool MouseIsHovering = false;
        private bool MouseDown = false;

        public ShapeTemplate()
        {
            Size = FixedSize;

            ImageRect = new Rectangle(0, 0, 80, 80);
            TextRect = new Rectangle(80, 0, 120, 80);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Size = FixedSize;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            MouseIsHovering = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            MouseIsHovering = true;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                MouseDown = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            MouseDown = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(SkinManager.GetScheme().BackgroundColor);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            if (MouseIsHovering && !MouseDown)
                e.Graphics.FillRectangle(SkinManager.GetScheme().MouseHoverBrush, ClientRectangle);
            else if(MouseIsHovering && MouseDown)
                e.Graphics.FillRectangle(SkinManager.GetScheme().MouseDownBrush, ClientRectangle);

            using (Pen p = new Pen(SkinManager.GetScheme().DisabledBrush, 1))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, ClientRectangle.Width - 2, ClientRectangle.Height - 2));

                if (TemplateImage != null)
                    e.Graphics.DrawImage(TemplateImage, ImageRect);

                if (Text.Length > 0)
                    e.Graphics.DrawString(Text, SkinManager.GetFontByStyle(eTextStyle.Normal),
                        SkinManager.GetScheme().ForeBrush, TextRect,
                        new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }
    }
}
