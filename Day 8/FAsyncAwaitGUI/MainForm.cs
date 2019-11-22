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

namespace FAsyncAwaitGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bDoSomething_Click(object sender, EventArgs e)
        {
            MyGreatClass my = new MyGreatClass();
            string value = my.Get();
            lResult.Text = value;
        }

        private void bDoSomethingThread_Click(object sender, EventArgs e)
        {
            MyGreatClass my = new MyGreatClass();
            Thread thread = new Thread(
                () =>
                {
                    string value = my.Get();
                    Action updateAction = () => lResult.Text = value;
                    Invoke(updateAction);
                }); 
            thread.Start();
        }

        private async void bDoSomethingAsync_Click(object sender, EventArgs e)
        {
            var my = new MyGreatClass();
            var value = await my.GetAsync();
            lResult.Text = value;
        }
    }
}
