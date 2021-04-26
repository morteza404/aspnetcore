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

namespace AsyncFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => BigLongImportant("Sally")).ContinueWith(t => label1.Text = t.Result);
            //label1.Text = BigLongImportant("John");
        }
        private string BigLongImportant(string name)
        {
            Thread.Sleep(2000);
            return "Hello, " + name;
        }
    }
}
