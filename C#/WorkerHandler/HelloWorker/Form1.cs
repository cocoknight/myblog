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

namespace HelloWorker
{
    public partial class Form1 : Form
    {
        CDiligentWorker _worker;
        public CProgressForm _progressform;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            string requestMode = "REPORT";
            _worker = new CDiligentWorker();
            _worker.worker.RunWorkerAsync(requestMode);

        }

        private void cmdHello_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Your data has been suceesfully exported.",
                           "Message",
                           System.Windows.Forms.MessageBoxButtons.OK,
                           System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void cmdNotWorker_Click(object sender, EventArgs e)
        {
            //Form에서 Worker를 사용하지 않고, ProgressBar를 진행하는 경우
            _progressform = new CProgressForm();
            _progressform.Show();

            for(int i=20;i<=100;i+=20)
            {
                updateProgress(i);
            }
        }

        void updateProgress(int level)
        {
            _progressform.progressBar1.Value = level;
            _progressform.progressBar1.Refresh();
            Thread.Sleep(1000);
            _progressform.lblprogress.Text = level.ToString() + "% completed";
            _progressform.lblprogress.Refresh();
            Thread.Sleep(1000);
        }
    }
}
