using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dongho_2
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        const string START_TEXT = "Start";
        const string STOP_TEXT = "Stop";
        DateTime timeStart;
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnstart.Text == START_TEXT)
            {
                btnstart.Text = STOP_TEXT;
                timer1.Enabled = true;
                timeStart = DateTime.Now;
            }
            else
            {
                btnstart.Text = START_TEXT;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now - timeStart).ToString();
        }
    }
}
