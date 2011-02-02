namespace Refrtest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.RayCount = new System.Windows.Forms.TextBox();
            this.refl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomX1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomX2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomX4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roomX3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.roomY4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.roomY3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.roomY2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.roomY1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pY4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pY3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pY2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pY1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pX4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pX3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pX2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pX1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.sY = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.sX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "количество волн трассировки:";
            // 
            // RayCount
            // 
            this.RayCount.Location = new System.Drawing.Point(186, 12);
            this.RayCount.Name = "RayCount";
            this.RayCount.Size = new System.Drawing.Size(30, 20);
            this.RayCount.TabIndex = 1;
            this.RayCount.Text = "360";
            // 
            // refl
            // 
            this.refl.Location = new System.Drawing.Point(186, 33);
            this.refl.Name = "refl";
            this.refl.Size = new System.Drawing.Size(30, 20);
            this.refl.TabIndex = 5;
            this.refl.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "количество отражений:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "координаты углов комнаты:";
            // 
            // roomX1
            // 
            this.roomX1.Location = new System.Drawing.Point(110, 75);
            this.roomX1.Name = "roomX1";
            this.roomX1.Size = new System.Drawing.Size(30, 20);
            this.roomX1.TabIndex = 9;
            this.roomX1.Text = "360";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "номер отображаемой волны:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Анимация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Х1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Х2";
            // 
            // roomX2
            // 
            this.roomX2.Location = new System.Drawing.Point(110, 96);
            this.roomX2.Name = "roomX2";
            this.roomX2.Size = new System.Drawing.Size(30, 20);
            this.roomX2.TabIndex = 16;
            this.roomX2.Text = "360";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Х4";
            // 
            // roomX4
            // 
            this.roomX4.Location = new System.Drawing.Point(110, 138);
            this.roomX4.Name = "roomX4";
            this.roomX4.Size = new System.Drawing.Size(30, 20);
            this.roomX4.TabIndex = 20;
            this.roomX4.Text = "360";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Х3";
            // 
            // roomX3
            // 
            this.roomX3.Location = new System.Drawing.Point(110, 117);
            this.roomX3.Name = "roomX3";
            this.roomX3.Size = new System.Drawing.Size(30, 20);
            this.roomX3.TabIndex = 18;
            this.roomX3.Text = "360";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Y4";
            // 
            // roomY4
            // 
            this.roomY4.Location = new System.Drawing.Point(186, 138);
            this.roomY4.Name = "roomY4";
            this.roomY4.Size = new System.Drawing.Size(30, 20);
            this.roomY4.TabIndex = 28;
            this.roomY4.Text = "360";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Y3";
            // 
            // roomY3
            // 
            this.roomY3.Location = new System.Drawing.Point(186, 117);
            this.roomY3.Name = "roomY3";
            this.roomY3.Size = new System.Drawing.Size(30, 20);
            this.roomY3.TabIndex = 26;
            this.roomY3.Text = "360";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Y2";
            // 
            // roomY2
            // 
            this.roomY2.Location = new System.Drawing.Point(186, 96);
            this.roomY2.Name = "roomY2";
            this.roomY2.Size = new System.Drawing.Size(30, 20);
            this.roomY2.TabIndex = 24;
            this.roomY2.Text = "360";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Y1";
            // 
            // roomY1
            // 
            this.roomY1.Location = new System.Drawing.Point(186, 75);
            this.roomY1.Name = "roomY1";
            this.roomY1.Size = new System.Drawing.Size(30, 20);
            this.roomY1.TabIndex = 22;
            this.roomY1.Text = "360";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Y4";
            // 
            // pY4
            // 
            this.pY4.Location = new System.Drawing.Point(186, 245);
            this.pY4.Name = "pY4";
            this.pY4.Size = new System.Drawing.Size(30, 20);
            this.pY4.TabIndex = 45;
            this.pY4.Text = "360";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Y3";
            // 
            // pY3
            // 
            this.pY3.Location = new System.Drawing.Point(186, 224);
            this.pY3.Name = "pY3";
            this.pY3.Size = new System.Drawing.Size(30, 20);
            this.pY3.TabIndex = 43;
            this.pY3.Text = "360";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Y2";
            // 
            // pY2
            // 
            this.pY2.Location = new System.Drawing.Point(186, 203);
            this.pY2.Name = "pY2";
            this.pY2.Size = new System.Drawing.Size(30, 20);
            this.pY2.TabIndex = 41;
            this.pY2.Text = "360";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Y1";
            // 
            // pY1
            // 
            this.pY1.Location = new System.Drawing.Point(186, 182);
            this.pY1.Name = "pY1";
            this.pY1.Size = new System.Drawing.Size(30, 20);
            this.pY1.TabIndex = 39;
            this.pY1.Text = "360";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(84, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Х4";
            // 
            // pX4
            // 
            this.pX4.Location = new System.Drawing.Point(110, 245);
            this.pX4.Name = "pX4";
            this.pX4.Size = new System.Drawing.Size(30, 20);
            this.pX4.TabIndex = 37;
            this.pX4.Text = "360";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(84, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Х3";
            // 
            // pX3
            // 
            this.pX3.Location = new System.Drawing.Point(110, 224);
            this.pX3.Name = "pX3";
            this.pX3.Size = new System.Drawing.Size(30, 20);
            this.pX3.TabIndex = 35;
            this.pX3.Text = "360";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(84, 206);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Х2";
            // 
            // pX2
            // 
            this.pX2.Location = new System.Drawing.Point(110, 203);
            this.pX2.Name = "pX2";
            this.pX2.Size = new System.Drawing.Size(30, 20);
            this.pX2.TabIndex = 33;
            this.pX2.Text = "360";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(84, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Х1";
            // 
            // pX1
            // 
            this.pX1.Location = new System.Drawing.Point(110, 182);
            this.pX1.Name = "pX1";
            this.pX1.Size = new System.Drawing.Size(30, 20);
            this.pX1.TabIndex = 31;
            this.pX1.Text = "360";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 164);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "координаты углов препятствия:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 269);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(158, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "координаты источника звука:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(160, 286);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Y1";
            // 
            // sY
            // 
            this.sY.Location = new System.Drawing.Point(186, 283);
            this.sY.Name = "sY";
            this.sY.Size = new System.Drawing.Size(30, 20);
            this.sY.TabIndex = 50;
            this.sY.Text = "360";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(86, 287);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Х1";
            // 
            // sX
            // 
            this.sX.Location = new System.Drawing.Point(112, 283);
            this.sX.Name = "sX";
            this.sX.Size = new System.Drawing.Size(30, 20);
            this.sX.TabIndex = 48;
            this.sX.Text = "360";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.sY);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.sX);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.pY4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.pY3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.pY2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.pY1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.pX4);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.pX3);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.pX2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.pX1);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.roomY4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.roomY3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.roomY2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.roomY1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.roomX4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.roomX3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.roomX2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.roomX1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.refl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RayCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 392);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 332);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(146, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "Задержка анимации(мсек):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 52;
            this.textBox2.Text = "500";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Refrtest.Properties.Resources.Формулы_сводка;
            this.pictureBox1.Location = new System.Drawing.Point(271, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 337);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 698);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Тест-программа для физической модели";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RayCount;
        private System.Windows.Forms.TextBox refl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomX2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomX4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox roomX3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roomY4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox roomY3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox roomY2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox roomY1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pY4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pY3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pY2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox pY1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox pX4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox pX3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox pX2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox pX1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox sY;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox sX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox2;
    }
}

