﻿
namespace ControllerPage
{
    partial class FormNumberpcsinterval
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Combobox_NumPerPCS = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Combobox_NumPerPCS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.55274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.44726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 272);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 3);
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Combobox_NumPerPCS
            // 
            this.Combobox_NumPerPCS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Combobox_NumPerPCS, 3);
            this.Combobox_NumPerPCS.DropDownHeight = 200;
            this.Combobox_NumPerPCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combobox_NumPerPCS.FormattingEnabled = true;
            this.Combobox_NumPerPCS.IntegralHeight = false;
            this.Combobox_NumPerPCS.Location = new System.Drawing.Point(12, 97);
            this.Combobox_NumPerPCS.Margin = new System.Windows.Forms.Padding(2);
            this.Combobox_NumPerPCS.Name = "Combobox_NumPerPCS";
            this.Combobox_NumPerPCS.Size = new System.Drawing.Size(408, 33);
            this.Combobox_NumPerPCS.TabIndex = 5;
            this.Combobox_NumPerPCS.Text = "-- Please choose no. of PCS --";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControllerPage.Resource1.numofpcs;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormNumberpcsinterval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormNumberpcsinterval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Numberpcsinterval_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox Combobox_NumPerPCS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}