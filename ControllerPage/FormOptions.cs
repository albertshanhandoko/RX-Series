using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerPage
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormLanguage FormLanguageoption = new FormLanguage();
            FormLanguageoption.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            using (var form = new FormThreshold())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //button_thereshold_maxvalue.Text = FormNumpad_max.numpad_max;
                    Console.WriteLine("test");
                }
            }
            this.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (var form = new FormBIASPassword())
            using (var form = new FormNumpadBPassword())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //button_thereshold_maxvalue.Text = FormNumpad_max.numpad_max;
                    Console.WriteLine("test");
                }
            }
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo procStartInfo3 = new ProcessStartInfo("/usr/bin/sudo", "halt");
            procStartInfo3.RedirectStandardOutput = true;
            procStartInfo3.UseShellExecute = false;
            procStartInfo3.CreateNoWindow = true;

            System.Diagnostics.Process proc3 = new System.Diagnostics.Process();
            proc3.StartInfo = procStartInfo3;
            proc3.Start();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            if(Global.GlobalVar=="Bahasa")
            {
                label1.Text = "Bahasa";
                label2.Text = "Ambang Batas";
                button1.Text = "Bahasa";
                button2.Text = "Perbaharui";
                button3.Text = "Perbaharui";
                button4.Text = "Shutdown";
                button5.Text = "Tutup";
            }
            if (Global.GlobalVar == "English")
            {
                label1.Text = "Language";
                label2.Text = "Threshold";
                button1.Text = "English";
                button2.Text = "Update";
                button3.Text = "Update";
                button4.Text = "Shutdown";
                button5.Text = "Close";
            }
            if (Global.GlobalVar == "Thai")
            {
                label1.Font = new Font("Noto Sans Thai", 25);
                label2.Font = new Font("Noto Sans Thai", 25);
                label3.Font = new Font("Noto Sans Thai", 25);
                label4.Font = new Font("Noto Sans Thai", 25);
                //button1.Font = new Font("Noto Sans Thai", 25);
                button2.Font = new Font("Noto Sans Thai", 25);
                button3.Font = new Font("Noto Sans Thai", 25);
                button4.Font = new Font("Noto Sans Thai", 25);
                button5.Font = new Font("Noto Sans Thai", 40);

                label1.Text = "ภาษา";
                label2.Text = "กำหนดขอบเขตความชื้น";
                label3.Text = "ปรับค่า";
                label4.Text = "ตัวเลือก";
                button1.Text = "Thai";
                button2.Text = "บันทึก";
                button3.Text = "บันทึก";
                button4.Text = "ปิดเครื่อง";
                button5.Text = "ปิดเ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 OpenForm1 = new Form1();
            OpenForm1.ShowDialog();
        }
    }
}
