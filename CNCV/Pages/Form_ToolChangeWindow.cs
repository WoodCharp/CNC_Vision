using CNCV.Tools;
using System;

using CCL.Controls;
using GRBL;
using CNCV.Machines;

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
        }

        private void cButton_Xm_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveSingleAxis(eAxis.X, cRadioButton_g0.Checked, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Xp_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveSingleAxis(eAxis.X, cRadioButton_g0.Checked, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));
        }

        private void cButton_Yp_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveSingleAxis(eAxis.Y, cRadioButton_g0.Checked, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_Ym_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveSingleAxis(eAxis.Y, cRadioButton_g0.Checked, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_XmYp_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                -float.Parse(cTextBox_distance.Text),
                float.Parse(cTextBox_distance.Text),
                int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_XpYp_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                float.Parse(cTextBox_distance.Text),
                float.Parse(cTextBox_distance.Text),
                int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_XmYm_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                -float.Parse(cTextBox_distance.Text),
                -float.Parse(cTextBox_distance.Text),
                int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_XpYm_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveTwoAxis(cRadioButton_g0.Checked,
                float.Parse(cTextBox_distance.Text),
                -float.Parse(cTextBox_distance.Text),
                int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_Zp_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveSingleAxis(eAxis.Z, cRadioButton_g0.Checked, float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));

        }

        private void cButton_Zm_Click(object sender, EventArgs e)
        {
            GRBLFramework.MoveSingleAxis(eAxis.Z, cRadioButton_g0.Checked, -float.Parse(cTextBox_distance.Text), int.Parse(cTextBox_feedRate.Text));

        }

        private void cButtonToolChanged_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cButton_touchThePlate_Click(object sender, EventArgs e)
        {
            GRBLFramework.ToutchThePlate(-100, 100,
            CurrentMachine.TouchPlateHeight,
            CurrentMachine.MoveUpDistance);
        }
    }
}
