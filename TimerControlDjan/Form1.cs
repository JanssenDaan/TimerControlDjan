using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DjanControls;
using DjanDLL;

namespace TimerControlDjan
{
    public partial class Form1 : Form
    {

        UC1 UCTimerControlDjan = new UC1();
        public Helpers Helpers = new Helpers();
        public List<UC1> UC1List = new List<UC1>();
        public int NrOfControls;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int r = Helpers.RandomNumber(1, 10);
        }

        private void btnAddTimerDjan_Click(object sender, EventArgs e)
        {
            NrOfControls++;

            var myControl = new UC1();
            myControl.Nr = NrOfControls;
            myControl.lblOneDjan.Text = NrOfControls.ToString();
            Flow.Controls.Add(myControl);
            Flow.AutoScroll = true;
            
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void pnlOneDjan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
