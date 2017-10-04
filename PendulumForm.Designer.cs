namespace Pendulum
{
    partial class PendulumForm
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
            this.WorldPic = new System.Windows.Forms.PictureBox();
            this.Kbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Run = new System.Windows.Forms.Button();
            this.FazDiagram = new System.Windows.Forms.PictureBox();
            this.SpeedBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MuBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trenie = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TAPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.period_stream = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SpeedStream = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorldPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldPic
            // 
            this.WorldPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorldPic.Location = new System.Drawing.Point(12, 43);
            this.WorldPic.Name = "WorldPic";
            this.WorldPic.Size = new System.Drawing.Size(674, 345);
            this.WorldPic.TabIndex = 0;
            this.WorldPic.TabStop = false;
            // 
            // Kbox
            // 
            this.Kbox.Location = new System.Drawing.Point(185, 17);
            this.Kbox.Name = "Kbox";
            this.Kbox.Size = new System.Drawing.Size(68, 20);
            this.Kbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Жёсткость";
            // 
            // LBox
            // 
            this.LBox.Location = new System.Drawing.Point(185, 44);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(68, 20);
            this.LBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начальная длина пружины";
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(185, 70);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(68, 20);
            this.X0Box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начальное положение";
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(185, 96);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(68, 20);
            this.mBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Масса";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(1039, 636);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(122, 34);
            this.Run.TabIndex = 9;
            this.Run.Text = "Запуск";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // FazDiagram
            // 
            this.FazDiagram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FazDiagram.Location = new System.Drawing.Point(704, 43);
            this.FazDiagram.Name = "FazDiagram";
            this.FazDiagram.Size = new System.Drawing.Size(445, 345);
            this.FazDiagram.TabIndex = 11;
            this.FazDiagram.TabStop = false;
            // 
            // SpeedBox
            // 
            this.SpeedBox.Location = new System.Drawing.Point(185, 122);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(68, 20);
            this.SpeedBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Начальная скорость (со знаком)";
            // 
            // MuBox
            // 
            this.MuBox.Location = new System.Drawing.Point(185, 148);
            this.MuBox.Name = "MuBox";
            this.MuBox.Size = new System.Drawing.Size(68, 20);
            this.MuBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Коэффициент трения";
            // 
            // trenie
            // 
            this.trenie.AutoSize = true;
            this.trenie.Location = new System.Drawing.Point(1039, 602);
            this.trenie.Name = "trenie";
            this.trenie.Size = new System.Drawing.Size(118, 17);
            this.trenie.TabIndex = 16;
            this.trenie.Text = "Активация трения";
            this.trenie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1039, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TAPic
            // 
            this.TAPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TAPic.Location = new System.Drawing.Point(5, 44);
            this.TAPic.Name = "TAPic";
            this.TAPic.Size = new System.Drawing.Size(577, 245);
            this.TAPic.TabIndex = 18;
            this.TAPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Время периода";
            // 
            // period_stream
            // 
            this.period_stream.AutoSize = true;
            this.period_stream.Location = new System.Drawing.Point(7, 46);
            this.period_stream.Name = "period_stream";
            this.period_stream.Size = new System.Drawing.Size(10, 13);
            this.period_stream.TabIndex = 20;
            this.period_stream.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(708, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "dx, м/c";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(420, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "x, м";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(698, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 409);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фазовая диграмма";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(423, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "x, м";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(2, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 409);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Физическая система";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(653, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "x, м";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "L, м";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TAPic);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(7, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 312);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Зависимость периода от амплитуды";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(550, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "A, м";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "T, c";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Текущая скорость";
            // 
            // SpeedStream
            // 
            this.SpeedStream.AutoSize = true;
            this.SpeedStream.Location = new System.Drawing.Point(107, 46);
            this.SpeedStream.Name = "SpeedStream";
            this.SpeedStream.Size = new System.Drawing.Size(10, 13);
            this.SpeedStream.TabIndex = 29;
            this.SpeedStream.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.timeBox);
            this.groupBox4.Controls.Add(this.LBox);
            this.groupBox4.Controls.Add(this.Kbox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.X0Box);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.mBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.SpeedBox);
            this.groupBox4.Controls.Add(this.MuBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(601, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 205);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Начальные условия";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SpeedStream);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.period_stream);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(877, 414);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 63);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текущие параметры";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(185, 174);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(68, 20);
            this.timeBox.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Шаг по времени для метода";
            // 
            // PendulumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 738);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trenie);
            this.Controls.Add(this.FazDiagram);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.WorldPic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PendulumForm";
            this.Text = "Пружинный маятник с фиксацией";
            ((System.ComponentModel.ISupportInitialize)(this.WorldPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WorldPic;
        private System.Windows.Forms.TextBox Kbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X0Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.PictureBox FazDiagram;
        private System.Windows.Forms.TextBox SpeedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MuBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox trenie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox TAPic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label period_stream;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label SpeedStream;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox timeBox;
    }
}

