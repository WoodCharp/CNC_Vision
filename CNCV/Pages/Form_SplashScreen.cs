using System;
using System.Windows.Forms;

using CCL.Controls;

namespace CNCV.Pages
{
    public partial class Form_SplashScreen : CForm
    {

        private Timer timer;
        private int counter = 0;

        public Form_SplashScreen()
        {
            InitializeComponent();

            cLabel_Version.Text = GetVersionInfo.Version();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void Form_SplahsScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter >= 2000)
            {
                timer.Stop();
               this.Close();
            }

            counter += timer.Interval;
        }
    }
}
