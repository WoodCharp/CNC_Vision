using System.Windows.Forms;

namespace CNCV.Controls
{
    public partial class PointPicker : UserControl
    {
        public float X, Y, Z;

        public PointPicker()
        {
            InitializeComponent();

            cTextBoxX.KeyPress += new KeyPressEventHandler(KeyPressEvent);
            cTextBoxY.KeyPress += new KeyPressEventHandler(KeyPressEvent);
            cTextBoxZ.KeyPress += new KeyPressEventHandler(KeyPressEvent);

            cTextBoxX.KeyUp += new KeyEventHandler(KeyUpEvent);
            cTextBoxY.KeyUp += new KeyEventHandler(KeyUpEvent);
            cTextBoxZ.KeyUp += new KeyEventHandler(KeyUpEvent);
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            if (cTextBoxX.Text.Length > 0)
                X = float.Parse(cTextBoxX.Text);

            if (cTextBoxY.Text.Length > 0)
                Y = float.Parse(cTextBoxY.Text);

            if (cTextBoxZ.Text.Length > 0)
                Z = float.Parse(cTextBoxZ.Text);
        }
    }
}
