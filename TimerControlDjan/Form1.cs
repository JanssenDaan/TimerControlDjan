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

namespace TimerControlDjan
{
    public partial class Form1 : Form
    {

        public Helpers Helpers = new Helpers();
        public List<UC1> UC1List = new List<UC1>();
        public int NrOfControls;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

    }
    
}
