using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int eggs1;
            int eggs2;
            int eggs3;
            int eggs4;
            int eggs5;
            int total;
            int dozens;
            int leftover;

            eggs1 = int.Parse(txtEgg1.Text);
            eggs2 = int.Parse(txtEgg2.Text);
            eggs3 = int.Parse(txtEgg3.Text);
            eggs4 = int.Parse(txtEgg4.Text);
            eggs5 = int.Parse(txtEgg5.Text);

            total = eggs1 + eggs2 + eggs3 + eggs4 + eggs5;
            dozens = total / 12;
            leftover = total % 12;

            txtOutput.Text = total.ToString() + " eggs is " + dozens.ToString() + " dozen with " + leftover.ToString() + " eggs left over";
        }
    }
}
