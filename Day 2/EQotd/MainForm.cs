using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQotd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        const string qotdUrl = "https://nvp-functions.azurewebsites.net/api/qotd/?slow=true";

        private string qotd = "";
        private bool qotdWorkerComplete = false;

        private void qotdWorker()
        {
            WebClient client = new WebClient();
            using (var stream = client.OpenRead(qotdUrl))
            {
                var streamReader = new StreamReader(stream);
                qotd = streamReader.ReadLine();
            }
            qotdWorkerComplete = true;
            this.Invoke((Delegate)(new Action(UpdateQotdUI)));
        }

        private void UpdateQotdUI()
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            lQotd.Text = qotd;
            lQotd.Visible = true;
        }

        private void bGetQotd_Click(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            Thread qotdThread = new Thread(qotdWorker);
            qotdThread.Start();
        }
    }
}
