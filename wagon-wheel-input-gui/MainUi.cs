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
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void Control1_MouseClick(Object sender, MouseEventArgs e)
        {
            Program.X = Convert.ToInt32(e.X*1.5);
            Program.Y = Convert.ToInt32(e.Y*1.5);
            MessageBox.Show("X = "+Program.X+"\n"+"y = "+Program.Y);
        }
    }
}
