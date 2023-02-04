using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerPage
{
    public partial class FormCountdown : Form
    {
        public FormCountdown()
        {
            InitializeComponent();
        }
        public int totalMinutes = Global.GlobalVar19 * 60 + Global.GlobalVar20;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCountdown_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.label1.Text = Global.GlobalVar19.ToString() + " Hr and " + Global.GlobalVar20 + " Min left";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalMinutes--;
            int hours = totalMinutes / 60;
            int minutes = totalMinutes - (hours * 60);
            this.label1.Text = hours.ToString() + " Hr and " + minutes + " Min left";
            if (totalMinutes == 0)
            {
                this.timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            totalMinutes--;
            int hours = totalMinutes / 60;
            int minutes = totalMinutes - (hours * 60);
            this.label1.Text = hours.ToString() + " Hr and " + minutes + " Min left";
            if (totalMinutes == 0)
            {
                this.timer1.Stop();
                this.Close();
            }
        }
    }
}
