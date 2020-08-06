using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wagon_wheel_input_gui
{
    public partial class PopupUi : Form
    {
        public PopupUi()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.Sess = "MCG1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Program.Sess = "RCG1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Program.Sess = "MCG2";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Program.Sess = "RCG2";
        }
    }
}
