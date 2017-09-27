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
            this.Speed = new System.Windows.Forms.TextBox();
            this.FazDiagram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WorldPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldPic
            // 
            this.WorldPic.Location = new System.Drawing.Point(14, 11);
            this.WorldPic.Name = "WorldPic";
            this.WorldPic.Size = new System.Drawing.Size(679, 377);
            this.WorldPic.TabIndex = 0;
            this.WorldPic.TabStop = false;
            // 
            // Kbox
            // 
            this.Kbox.Location = new System.Drawing.Point(579, 411);
            this.Kbox.Name = "Kbox";
            this.Kbox.Size = new System.Drawing.Size(68, 20);
            this.Kbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Жёсткость";
            // 
            // LBox
            // 
            this.LBox.Location = new System.Drawing.Point(579, 437);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(68, 20);
            this.LBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Начальная длина пружины";
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(579, 463);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(68, 20);
            this.X0Box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начальное положение";
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(579, 489);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(68, 20);
            this.mBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Масса";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(1039, 676);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(122, 34);
            this.Run.TabIndex = 9;
            this.Run.Text = "Пуск/Пауза";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(56, 489);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(100, 20);
            this.Speed.TabIndex = 10;
            // 
            // FazDiagram
            // 
            this.FazDiagram.Location = new System.Drawing.Point(709, 12);
            this.FazDiagram.Name = "FazDiagram";
            this.FazDiagram.Size = new System.Drawing.Size(440, 376);
            this.FazDiagram.TabIndex = 11;
            this.FazDiagram.TabStop = false;
            // 
            // PendulumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 722);
            this.Controls.Add(this.FazDiagram);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.X0Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kbox);
            this.Controls.Add(this.WorldPic);
            this.Name = "PendulumForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WorldPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazDiagram)).EndInit();
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
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.PictureBox FazDiagram;
    }
}

