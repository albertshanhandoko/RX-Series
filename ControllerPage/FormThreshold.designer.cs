﻿
namespace ControllerPage
{
    partial class FormThreshold
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThreshold));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_thereshold_maxvalue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_disable = new System.Windows.Forms.RadioButton();
            this.button_thereshold_apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_thereshold_minvalue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_enable = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_maxvalue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_disable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_apply, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_minvalue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_enable, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 363);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Noto Sans Thai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_TheresholdApply_Click);
            // 
            // button_thereshold_maxvalue
            // 
            this.button_thereshold_maxvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_maxvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_maxvalue.Location = new System.Drawing.Point(262, 225);
            this.button_thereshold_maxvalue.Name = "button_thereshold_maxvalue";
            this.button_thereshold_maxvalue.Size = new System.Drawing.Size(94, 53);
            this.button_thereshold_maxvalue.TabIndex = 9;
            this.button_thereshold_maxvalue.Text = "12";
            this.button_thereshold_maxvalue.UseVisualStyleBackColor = true;
            this.button_thereshold_maxvalue.Click += new System.EventHandler(this.button_maxthereshold_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Noto Sans Thai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "กำหนดขอบเขตความชื้น";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_disable
            // 
            this.radioButton_disable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_disable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton_disable.Font = new System.Drawing.Font("Noto Sans Thai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_disable.Location = new System.Drawing.Point(223, 57);
            this.radioButton_disable.Name = "radioButton_disable";
            this.radioButton_disable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton_disable.Size = new System.Drawing.Size(171, 84);
            this.radioButton_disable.TabIndex = 5;
            this.radioButton_disable.TabStop = true;
            this.radioButton_disable.Text = "ปิดใช้งาน";
            this.radioButton_disable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_disable.UseVisualStyleBackColor = false;
            // 
            // button_thereshold_apply
            // 
            this.button_thereshold_apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_thereshold_apply.BackgroundImage")));
            this.button_thereshold_apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_thereshold_apply.Font = new System.Drawing.Font("Noto Sans Thai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_apply.Location = new System.Drawing.Point(259, 299);
            this.button_thereshold_apply.Name = "button_thereshold_apply";
            this.button_thereshold_apply.Size = new System.Drawing.Size(100, 52);
            this.button_thereshold_apply.TabIndex = 3;
            this.button_thereshold_apply.UseVisualStyleBackColor = true;
            this.button_thereshold_apply.Click += new System.EventHandler(this.Btn_close_thereshold_click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Thai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "ขอบเขตความชื้นสูงสุด";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_thereshold_minvalue
            // 
            this.button_thereshold_minvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_minvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_minvalue.Location = new System.Drawing.Point(262, 156);
            this.button_thereshold_minvalue.Name = "button_thereshold_minvalue";
            this.button_thereshold_minvalue.Size = new System.Drawing.Size(94, 48);
            this.button_thereshold_minvalue.TabIndex = 8;
            this.button_thereshold_minvalue.Text = "10";
            this.button_thereshold_minvalue.UseVisualStyleBackColor = true;
            this.button_thereshold_minvalue.Click += new System.EventHandler(this.button_minthereshold_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Thai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "ขอบเขตความชื้นต่ำสุด";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_enable
            // 
            this.radioButton_enable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_enable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton_enable.Font = new System.Drawing.Font("Noto Sans Thai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_enable.Location = new System.Drawing.Point(20, 57);
            this.radioButton_enable.Name = "radioButton_enable";
            this.radioButton_enable.Size = new System.Drawing.Size(165, 84);
            this.radioButton_enable.TabIndex = 4;
            this.radioButton_enable.TabStop = true;
            this.radioButton_enable.Text = "เปิดใช้งาน";
            this.radioButton_enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_enable.UseVisualStyleBackColor = false;
            this.radioButton_enable.CheckedChanged += new System.EventHandler(this.radioButton_enable_CheckedChanged);
            // 
            // FormThreshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormThreshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormThreshold_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_thereshold_apply;
        private System.Windows.Forms.RadioButton radioButton_enable;
        private System.Windows.Forms.RadioButton radioButton_disable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button_thereshold_maxvalue;
        public System.Windows.Forms.Button button_thereshold_minvalue;
        private System.Windows.Forms.Button button1;
    }
}