using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCL.Controls;
using CCL;

namespace CNCV.Generator
{
    public partial class Form_Generator : CForm
    {
        public Form_Generator()
        {
            InitializeComponent();

            //Setting up theme
            var skinmanager = CSkinManager.Instance;
            skinmanager.AddFormToManage(this);
        }

        private void Form_Generator_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSkinManager.Instance.RemoveFormToManage(this);
        }
    }
}
