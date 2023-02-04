
namespace ControllerPage
{
    partial class Formdelaystart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formdelaystart));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_enable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_disable = new System.Windows.Forms.RadioButton();
            this.button_thereshold_apply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_enable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_disable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_apply, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.31537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.82393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.85989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.00081F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 361);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 55);
            this.label3.TabIndex = 15;
            this.label3.Text = "Min";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_enable
            // 
            this.radioButton_enable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_enable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.radioButton_enable, 2);
            this.radioButton_enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_enable.Location = new System.Drawing.Point(28, 58);
            this.radioButton_enable.Name = "radioButton_enable";
            this.radioButton_enable.Size = new System.Drawing.Size(218, 80);
            this.radioButton_enable.TabIndex = 5;
            this.radioButton_enable.Text = "เปิดใช้งาน";
            this.radioButton_enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_enable.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตั้งเวลาเริ่มทำงาน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_disable
            // 
            this.radioButton_disable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_disable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton_disable.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.radioButton_disable, 2);
            this.radioButton_disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_disable.Location = new System.Drawing.Point(304, 58);
            this.radioButton_disable.Name = "radioButton_disable";
            this.radioButton_disable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton_disable.Size = new System.Drawing.Size(230, 80);
            this.radioButton_disable.TabIndex = 6;
            this.radioButton_disable.TabStop = true;
            this.radioButton_disable.Text = "ปิดใช้งาน";
            this.radioButton_disable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_disable.UseVisualStyleBackColor = false;
            // 
            // button_thereshold_apply
            // 
            this.button_thereshold_apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_thereshold_apply.BackgroundImage")));
            this.tableLayoutPanel1.SetColumnSpan(this.button_thereshold_apply, 2);
            this.button_thereshold_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_apply.Location = new System.Drawing.Point(369, 313);
            this.button_thereshold_apply.Name = "button_thereshold_apply";
            this.button_thereshold_apply.Size = new System.Drawing.Size(100, 45);
            this.button_thereshold_apply.TabIndex = 12;
            this.button_thereshold_apply.UseVisualStyleBackColor = true;
            this.button_thereshold_apply.Click += new System.EventHandler(this.button_thereshold_apply_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 55);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hr";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(297, 167);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 116);
            this.numericUpDown1.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(16, 167);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 116);
            this.numericUpDown2.TabIndex = 17;
            // 
            // Formdelaystart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Formdelaystart";
            this.Text = "Formdelaystart";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_enable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_disable;
        private System.Windows.Forms.Button button_thereshold_apply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}