using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerPage.Constant;
using ControllerPage.Helper;
using ControllerPage.Library;
using System.Windows.Forms;

namespace ControllerPage
{
    public partial class FormLanguage : Form
    {
        public FormLanguage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sensor_input_Helper.writeTextFile("/etc/rxseries/config_language.txt", "bahasa");
            Global.GlobalVar = "Bahasa";
            Global.GlobalVar1 = "Pengukuran Kadar Air Aktual";
            Global.GlobalVar2 = "Interval Ke";
            Global.GlobalVar3 = "Penghitung Biji";
            Global.GlobalVar4 = "Rataan Kadar Air";
            Global.GlobalVar5 = "Produk";
            Global.GlobalVar6 = "Jumlah Interval";
            Global.GlobalVar7 = "PCS tiap Interval";
            Global.GlobalVar8 = "Waktu Tunggu";
            Global.GlobalVar9 = "Opsi";
            Global.GlobalVar10 = "Nomor Sensor";
            Global.GlobalVar11 = "Status ";
            Global.GlobalVar12 = "Temp";
            Global.GlobalVar13 = "Interface";
            Global.GlobalVar14 = "Mode ";
            Global.GlobalVar15 = "Ambang Batas Maksimal";
            Global.GlobalVar16 = "Ambang Batas Minimal";
            Global.GlobalVar17 = "Offline";
            Global.GlobalVar18 = "Padi";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sensor_input_Helper.writeTextFile("/etc/rxseries/config_language.txt", "english");
            Global.GlobalVar = "English";
            Global.GlobalVar1 = "Current Interval Moisture Measurement";
            Global.GlobalVar2 = "Interval Number";
            Global.GlobalVar3 = "Kernel Counter";
            Global.GlobalVar4 = "Average Moisture";
            Global.GlobalVar5 = "Product";
            Global.GlobalVar6 = "No. of Intervals";
            Global.GlobalVar7 = "PCS per Interval";
            Global.GlobalVar8 = "Int. Waiting Time";
            Global.GlobalVar9 = "Options";
            Global.GlobalVar10 = "Sensor Number";
            Global.GlobalVar11 = "Status ";
            Global.GlobalVar12 = "Temp";
            Global.GlobalVar13 = "Interface";
            Global.GlobalVar14 = "Mode";
            Global.GlobalVar15 = "Threshold Max";
            Global.GlobalVar16 = "Threshold Min";
            Global.GlobalVar17 = "Offline";
            Global.GlobalVar18 = "Paddy";
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Sensor_input_Helper.writeTextFile("/etc/rxseries/config_language.txt", "thai");
            Global.GlobalVar = "Thai";
            Global.GlobalVar1 = "ความชื้นที่วัดได้";
            Global.GlobalVar2 = "จำนวนครั้งที่วัด";
            Global.GlobalVar3 = "จำนวนเมล็ด";
            Global.GlobalVar4 = "ค่าเฉลี่ยความชื้น";
            Global.GlobalVar5 = "ชนิดข้าว";
            Global.GlobalVar6 = "จำนวนครั้ง";
            Global.GlobalVar7 = "จำนวนเมล็ด";
            Global.GlobalVar8 = "ระยะห่างในการวัด";
            Global.GlobalVar9 = "ตัวเลือก";
            Global.GlobalVar10 = "เซ็นเซอร์";
            Global.GlobalVar11 = "สถานะ";
            Global.GlobalVar12 = "อุณหภูมิ";
            Global.GlobalVar13 = "ระบบการเชื่อมต่อ";
            Global.GlobalVar14 = "โหม"+"ด";
            Global.GlobalVar15 = "ขอบเขตความชื้นสูงสุด";
            Global.GlobalVar16 = "ขอบเขตความชื้นต่ำสุด";
            Global.GlobalVar17 = "สถานะ";
            Global.GlobalVar18 = "สถานะ";
            this.Close();
        }

        private void FormLanguage_Load(object sender, EventArgs e)
        {

        }
    }
}
