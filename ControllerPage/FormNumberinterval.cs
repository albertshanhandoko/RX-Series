﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerPage.Constant;
using ControllerPage.Helper;

namespace ControllerPage
{
    public partial class FormNumberinterval : Form
    {
        public static bool password_value;
        public static string combobox_selectedItem_number_Interval;

        public FormNumberinterval()
        {
            InitializeComponent();
            Combobox_NumInterval.Items.Clear();
            for (int i = 1; i <= 50; i++)
            {
                Combobox_NumInterval.Items.Add(i.ToString());
            }

        }

        public decimal Intervalselection { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Intervalselection = numericUpDown1.Value;

     
            if (Combobox_NumInterval.SelectedIndex > -1)
            {
                combobox_selectedItem_number_Interval = Combobox_NumInterval.SelectedItem.ToString();
            }
            else
            {
                combobox_selectedItem_number_Interval = string.Empty;
            }

            this.DialogResult = DialogResult.OK;
            Sensor_input_Helper.Update_DataSetting(Sensor_input_Helper.GetLocalIPAddress(), "button8", combobox_selectedItem_number_Interval.ToString());
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combobox_NumInterval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormNumberinterval_Load(object sender, EventArgs e)
        {
            if (Global.GlobalVar == "Bahasa")
            {
                label1.Text = "Nomor dari Interval (1-50)";
                Combobox_NumInterval.Text = "-- Mohon Pilih Nomor dari Interval --";
                button1.Text = "Gunakan";
            }
            if (Global.GlobalVar == "English")
            {
                label1.Text = "Number of Intervals (1-50)";
                Combobox_NumInterval.Text = "-- Please Choose Number of Interval --";
                button1.Text = "Apply";
            }
        }
    }
}
