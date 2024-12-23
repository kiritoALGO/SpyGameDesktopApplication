using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp.RJ_Controls
{
    [ToolboxItem(true)]
    public class PlaceholderTextBox : TextBox
    {
        private string placeholderText = "Placeholder";

        [Category("Appearance")]
        [Description("The text displayed when the textbox is empty.")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                Invalidate(); // Redraw the control
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(PlaceholderText) && !this.Focused)
            {
                using (Font font = new Font(this.Font, FontStyle.Italic))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(PlaceholderText, font, brush, new PointF(1, 1));
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate(); // Redraw to hide/show placeholder
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }
    }
}
