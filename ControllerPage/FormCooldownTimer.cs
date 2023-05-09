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
    public partial class FormCooldownTimer : Form
    {
        public FormCooldownTimer()
        {
            InitializeComponent();
        }
        public static string numpad_max;
        private void button1_Click(object sender, EventArgs e)
        {
            numpad_max = numericUpDown1.Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
