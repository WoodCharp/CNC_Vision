using System;
using System.Windows.Forms;

using GRBL;

using CNCV.Tools;
using CNCV.Machines;

using CCL.Controls;

namespace CNCV.Pages
{
    public partial class Form_ToolChangeWindow : CForm, IManager, IGRBL
    {
        public Manager Manager => Manager.Instance;
        public GRBLManager GRBLFramework => GRBLManager.Instance;

        public CNCTool RouterTool { get; set; }
        public Machine CurrentMachine { get; set; }

        public Form_ToolChangeWindow()
        {
            InitializeComponent();
        }

        private void Form_ToolChangeWindow_Load(object sender, EventArgs e)
        {
            cLabelName.Text = RouterTool.Name;
            cLabelCD.Text = string.Format("CD: {0}", RouterTool.CD);
            cLabelSD.Text = string.Format("SD: {0}", RouterTool.SD);
            cLabelID.Text = string.Format("ID: {0}", RouterTool.ID);
            cLabelType.Text = string.Format("Type: {0}", RouterTool.ToolType);
        }

        private void cButton_Xm_Click(object sender, EventArgs e)
        {
            if(cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.X, cRadioButton_g0.Checked, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Xp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.X, cRadioButton_g0.Checked, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Yp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Y, cRadioButton_g0.Checked, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Ym_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Y, cRadioButton_g0.Checked, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XmYp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                    -float.Parse(cTextBox_distance.Text),
                    float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XpYp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                    float.Parse(cTextBox_distance.Text),
                    float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XmYm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                    -float.Parse(cTextBox_distance.Text),
                    -float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_XpYm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                    float.Parse(cTextBox_distance.Text),
                    -float.Parse(cTextBox_distance.Text),
                    int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Zp_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Z, cRadioButton_g0.Checked, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Zm_Click(object sender, EventArgs e)
        {
            if (cTextBox_distance.Text.Length > 0 && cTextBox_feedRate.Text.Length > 0)
                GRBLFramework.MoveSingleAxis(eAxis.Z, cRadioButton_g0.Checked, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButtonToolChanged_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cButton_touchThePlate_Click(object sender, EventArgs e)
        {
            GRBLFramework.ToutchThePlate(-50, 200,
            CurrentMachine.TouchPlateHeight,
            CurrentMachine.MoveUpDistance);
        }

        private void cTextBox_distance_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                e.Handled = true;
        }

        private void cTextBox_feedRate_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
