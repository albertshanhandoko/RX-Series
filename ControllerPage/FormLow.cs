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
    public partial class FormLow : Form
    {
        public FormLow()
        {
            InitializeComponent();
        }
        public static string numpad_max;
        public static string numpad_min;
        private void button_numpad_ent_Click(object sender, EventArgs e)
        {
            //FormThereshold_Temp.button_thereshold_maxvalue.Text = string.Format("{0:0}", textBox_numpad_window_max.Text);
            numpad_max = numericUpDown1.Value.ToString();
            //FormThereshold_Temp.button_thereshold_maxvalue.Text = string.Format("{0:0}", textBox_numpad_window_max.Text);
            numpad_min = numericUpDown2.Value.ToString();
            Global.lowinterval = float.Parse(numericUpDown1.Value.ToString());
            Global.lowpcs = float.Parse(numericUpDown2.Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
