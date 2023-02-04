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
    public partial class Formdelaystart : Form
    {
        public Formdelaystart()
        {
            InitializeComponent();
        }
        public static string delay_start;
        private void button_thereshold_apply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.GlobalVar19 = Int16.Parse(numericUpDown2.Text.ToString());
            Global.GlobalVar20 = Int16.Parse(numericUpDown1.Text.ToString());
            delay_start = Global.GlobalVar19.ToString() + " Hr and " + Global.GlobalVar20 + " Min";
            Global.GlobalVar21 = numericUpDown2.Text.ToString();
            this.DialogResult = DialogResult.OK;
            if (radioButton_disable.Checked)
            {
                Global.GlobalVar22 = false;
            }
            if (radioButton_enable.Checked)
            {
                Global.GlobalVar22 = true;
            }
            this.Close();
        }
    }
}
