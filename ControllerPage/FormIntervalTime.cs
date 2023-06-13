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
using ControllerPage.Library;

namespace ControllerPage
{
    public partial class FormIntervalTime : Form
    {
        public FormIntervalTime()
        {
            InitializeComponent();

            Combobox_timeinterval.Items.Clear();
            List<string> List_TimeInter;
            //Form1 Form_Main_Window = new Form1();

            List_TimeInter = Sensor_input_Helper.Get_List_Waiting_Time_Interval();
            foreach (string TimeInter in List_TimeInter)
            {
                Combobox_timeinterval.Items.Add(TimeInter);
            }

        }
        public static string combobox_selectedItem_WaitingTime;

        public decimal WaitingIntervalselection { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.WaitingIntervalselection = numericUpDown2.Value;
            if (Combobox_timeinterval.SelectedIndex > -1)
            {
                combobox_selectedItem_WaitingTime = Combobox_timeinterval.SelectedItem.ToString();
            }
            else
            {
                combobox_selectedItem_WaitingTime = string.Empty;
            }
            this.DialogResult = DialogResult.OK;
            Sensor_input_Helper.Update_DataSetting(Sensor_input_Helper.GetLocalIPAddress(), "button10", combobox_selectedItem_WaitingTime.ToString());
            this.Close();

        }

        private void Combobox_NumPerPCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormIntervalTime_Load(object sender, EventArgs e)
        {
            if (Global.GlobalVar == "Bahasa")
            {
                label1.Text = "Waktu Tunggu Antar Invterval";
                Combobox_timeinterval.Text = "-- Mohon Piluh Waktu Tunggu --";
                button1.Text = "Gunakan";
            }
            if (Global.GlobalVar == "English")
            {
                label1.Text = "Waiting time between Intervals";
                Combobox_timeinterval.Text = "-- Please Choose Waiting Time --";
                button1.Text = "Apply";
            }
        }
    }
}
