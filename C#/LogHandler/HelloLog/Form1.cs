using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace HelloLog
{
    public partial class Form1 : Form
    {
        public string _helloString;
        public string _logMessage;
        protected DateTime _testTime;
        protected string _s_testTime;
        string _logpath = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _helloString = "Hello C# World!";
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            //현재 시간 계산해서 출력
            _testTime = System.DateTime.Now;
            _s_testTime = string.Format("{0:hh:mm:ss tt}", _testTime);
            txtLog.Text = _s_testTime + ":" + _helloString;

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            _testTime = System.DateTime.Now;
            _s_testTime = string.Format("{0:hh:mm:ss tt}", _testTime);
            txtLog.Text = _s_testTime + ":" + _helloString;

            System.Windows.Forms.MessageBox.Show(_s_testTime + ":" + _helloString,
                          "Log",
                          System.Windows.Forms.MessageBoxButtons.OK,
                          System.Windows.Forms.MessageBoxIcon.Information);
        }



        private void btnConsole_Click(object sender, EventArgs e)
        {
            _testTime = System.DateTime.Now;
            _s_testTime = string.Format("{0:hh:mm:ss tt}", _testTime);

            Debug.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));
            Trace.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));
            Console.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            //step1 : setup about TextWriterTraceListener
            this.turnon_log_dump();

            //step2 : write a log
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            //Debug.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));
            Trace.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));
            
            Thread.Sleep(1000);
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Trace.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));

            Thread.Sleep(1000);
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Trace.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));


            Thread.Sleep(1000);
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Trace.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));


        }

        public void turnon_log_dump()
        {
            try
            {
                string ExportFilePath = Path.GetDirectoryName(Application.ExecutablePath);
                string app_verification_log = ExportFilePath + @"\logdump.txt";

                TextWriterTraceListener cListener = new TextWriterTraceListener(System.IO.File.Open(app_verification_log, FileMode.Append));
                System.Diagnostics.Trace.Listeners.Add(cListener);

                Trace.AutoFlush = true;
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Full Stacktrace: {0}", ex.ToString()));
            }

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            this.turnon_log_dump();

            //step2 : write a log
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Debug.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));

            Thread.Sleep(1000);
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Debug.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));

            Thread.Sleep(1000);
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Debug.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));


            Thread.Sleep(1000);
            _s_testTime = string.Format("{0:hh:mm:ss tt}", System.DateTime.Now);
            Debug.WriteLine(string.Format("{0}:{1},", _s_testTime, _helloString));
        }

    }
}
