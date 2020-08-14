using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCL.Controls;
using CCL;
using GRBL;

namespace CNCV.Pages
{
    public partial class Form_CheckFile : CForm, IGRBL
    {
        public GRBLManager GRBLFramework => GRBLManager.Instance;

        private float percentage = 0, current = 0, total = 0;
        private bool Canceled = false;

        public Form_CheckFile()
        {
            InitializeComponent();

            //Setting up theme
            var skinmanager = CSkinManager.Instance;
            skinmanager.AddFormToManage(this);
        }

        private void Form_CheckFile_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            cRichTextBox_NotOk.Visible = false;
            cRichTextBox_ok.Visible = false;
        }

        private void cButtonCancel_Click(object sender, EventArgs e)
        {
            Canceled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            total = GRBLFramework.CheckItemsList.Count;
            foreach(CheckItem ci in GRBLFramework.CheckItemsList)
            {
                if (Canceled)
                    break;

                if (ci.OK == "ok")
                    cRichTextBox_ok.Invoke(() =>
                    {
                        cRichTextBox_ok.AppendText(string.Format(
                            "{0} -> {1}\n", ci.Line, ci.OK));
                    });
                else
                    cRichTextBox_NotOk.Invoke(() =>
                    {
                        cRichTextBox_NotOk.AppendText(string.Format(
                            "{0} -> {1}\n", ci.Line, ci.OK));
                    });

                current++;
                percentage = (current / total) * 100;

                RefreshValues();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cPanel1.Invoke(() => { cPanel1.Visible = false; });

            cRichTextBox_NotOk.Visible = true;
            cRichTextBox_ok.Visible = true;

            if (Canceled)
                cRichTextBox_NotOk.AppendText("Process was canceled !");
        }

        private void Form_CheckFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSkinManager.Instance.RemoveFormToManage(this);
        }

        private void RefreshValues()
        {
            cProgressBar1.Invoke(() => { cProgressBar1.Value = (int)percentage; });
            cLabel4.Invoke(() => { cLabel4.Text = percentage.ToString("F1"); });
        }

        private void cButton_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
