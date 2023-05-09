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
    public partial class FormNumpadTargetMoisture : Form
    {
        FormThreshold FormThereshold_Temp = new FormThreshold();
        public FormNumpadTargetMoisture()
        {
            InitializeComponent();
        }
        public static string numpad_max;
        private void button_numpad_del_Click(object sender, EventArgs e)
        {
            if (textBox_numpad_window_max.Text.Length > 0)
            {
                textBox_numpad_window_max.Text = textBox_numpad_window_max.Text.Remove(textBox_numpad_window_max.Text.Length - 1, 1);
            }
        }

        private void button_numpad_1_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "1";
        }

        private void button_numpad_2_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "2";
        }

        private void button_numpad_3_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "3";
        }

        private void button_numpad_4_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "4";
        }

        private void button_numpad_5_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "5";
        }

        private void button_numpad_6_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "6";
        }

        private void button_numpad_7_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "7";
        }

        private void button_numpad_8_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "8";
        }

        private void button_numpad_9_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "9";
        }

        private void button_numpad_dot_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + ".";
        }

        private void button_numpad_0_Click(object sender, EventArgs e)
        {
            textBox_numpad_window_max.Text = textBox_numpad_window_max.Text + "0";
        }

        private void button_numpad_ent_Click(object sender, EventArgs e)
        {
            FormThereshold_Temp.button_thereshold_maxvalue.Text = string.Format("{0:0}", textBox_numpad_window_max.Text);
            numpad_max = string.Format("{0:0}", textBox_numpad_window_max.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
