namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CircleRadiusT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.WidthSetter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Color_Indicator = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Holst = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.CircleStatement_rbtn = new System.Windows.Forms.RadioButton();
            this.PolygonStatement_rbtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Color_Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Holst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // CircleRadiusT
            // 
            this.CircleRadiusT.Location = new System.Drawing.Point(12, 121);
            this.CircleRadiusT.Name = "CircleRadiusT";
            this.CircleRadiusT.Size = new System.Drawing.Size(100, 20);
            this.CircleRadiusT.TabIndex = 1;
            this.CircleRadiusT.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Радиус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Углы";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Цвет...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Select_Color_Click);
            // 
            // WidthSetter
            // 
            this.WidthSetter.Location = new System.Drawing.Point(162, 38);
            this.WidthSetter.Name = "WidthSetter";
            this.WidthSetter.Size = new System.Drawing.Size(100, 20);
            this.WidthSetter.TabIndex = 7;
            this.WidthSetter.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Толщина";
            // 
            // Color_Indicator
            // 
            this.Color_Indicator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color_Indicator.Location = new System.Drawing.Point(17, 28);
            this.Color_Indicator.Name = "Color_Indicator";
            this.Color_Indicator.Size = new System.Drawing.Size(40, 36);
            this.Color_Indicator.TabIndex = 9;
            this.Color_Indicator.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "0";
            // 
            // Holst
            // 
            this.Holst.BackColor = System.Drawing.Color.Coral;
            this.Holst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Holst.Location = new System.Drawing.Point(278, 25);
            this.Holst.Name = "Holst";
            this.Holst.Size = new System.Drawing.Size(290, 265);
            this.Holst.TabIndex = 16;
            this.Holst.TabStop = false;
            this.Holst.Click += new System.EventHandler(this.Holst_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(151, 114);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 25;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(153, 63);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 18;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(152, 168);
            this.trackBar3.Maximum = 12;
            this.trackBar3.Minimum = 3;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 19;
            this.trackBar3.Value = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // CircleStatement_rbtn
            // 
            this.CircleStatement_rbtn.AutoSize = true;
            this.CircleStatement_rbtn.Checked = true;
            this.CircleStatement_rbtn.Location = new System.Drawing.Point(39, 225);
            this.CircleStatement_rbtn.Name = "CircleStatement_rbtn";
            this.CircleStatement_rbtn.Size = new System.Drawing.Size(48, 17);
            this.CircleStatement_rbtn.TabIndex = 20;
            this.CircleStatement_rbtn.TabStop = true;
            this.CircleStatement_rbtn.Text = "Круг";
            this.CircleStatement_rbtn.UseVisualStyleBackColor = true;
            this.CircleStatement_rbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // PolygonStatement_rbtn
            // 
            this.PolygonStatement_rbtn.AutoSize = true;
            this.PolygonStatement_rbtn.Location = new System.Drawing.Point(127, 225);
            this.PolygonStatement_rbtn.Name = "PolygonStatement_rbtn";
            this.PolygonStatement_rbtn.Size = new System.Drawing.Size(103, 17);
            this.PolygonStatement_rbtn.TabIndex = 21;
            this.PolygonStatement_rbtn.TabStop = true;
            this.PolygonStatement_rbtn.Text = "Многоугольник";
            this.PolygonStatement_rbtn.UseVisualStyleBackColor = true;
            this.PolygonStatement_rbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PolygonStatement_rbtn);
            this.Controls.Add(this.CircleStatement_rbtn);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Holst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Color_Indicator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthSetter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CircleRadiusT);
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Color_Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Holst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CircleRadiusT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox WidthSetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Color_Indicator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Holst;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.RadioButton CircleStatement_rbtn;
        private System.Windows.Forms.RadioButton PolygonStatement_rbtn;
        private System.Windows.Forms.Button button1;
    }
}

