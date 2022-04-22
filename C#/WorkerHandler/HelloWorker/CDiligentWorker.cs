using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloWorker
{
    class CDiligentWorker
    {
        public BackgroundWorker worker;
        public CProgressForm _progressform;

        public CDiligentWorker() 
        {
            Debug.WriteLine(string.Format("CDeviceManager Default Constructor"));

            _progressform = new CProgressForm();
            _progressform.Show();

            //Declaration of Device Worker
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }


        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //This is Worker Thread
            string argument = e.Argument as string;
            Debug.WriteLine(string.Format("Worker Start:{0}",e.Argument));

            try
            {
                switch (argument)
                {
                    case "REPORT":
                        {


                            worker.ReportProgress(20);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);

                            worker.ReportProgress(40);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);

                            worker.ReportProgress(60);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);

                            worker.ReportProgress(80);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);

                            worker.ReportProgress(100);
                            Thread.Sleep(1000);
                            Thread.Sleep(1000);

                            break;
                        }
                    default:
                        break;
                }
             
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Full Stacktrace: {0}", ex.ToString()));
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //This is UI Thread
            System.Diagnostics.Debug.WriteLine(string.Format("Update UI Worker:{0}", e.ProgressPercentage));

            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Progress Value:{0}", e.ProgressPercentage));
                _progressform.progressBar1.Value = e.ProgressPercentage;
                _progressform.lblprogress.Text = e.ProgressPercentage.ToString() + "% completed";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Full Stacktrace: {0}", ex.ToString()));
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //This is UI Thread
            System.Diagnostics.Debug.WriteLine(string.Format("Worker Complete:{0}", e.Cancelled));

            try
            {
                _progressform.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Full Stacktrace: {0}", ex.ToString()));
            }
        }

    }
}
