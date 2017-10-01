using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Painting;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Pendulum
{
    public partial class PendulumForm : Form
    {
        public PendulumForm()
        {
            InitializeComponent();
            param.xmin = -50;
            param.xmax = 50;
            param.ymin = -1;
            param.ymax = 10;
            param.N = 50;
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 2;
            param.osicolor = Color.Black;
            param.bodycolor = Color.Yellow;
            param.setkacolor = Color.Black;
            param.backgroundcolor = Color.LightBlue;
            param.graphcolor = Color.Yellow;
            param.pointcolor = Color.Brown;
            param.prujcolor = Color.DarkGreen;

            param_faz.backgroundcolor = Color.WhiteSmoke;
            param_faz.osicolor = Color.Black;
            param_faz.graphcolor = Color.Blue;
            param_faz.pointcolor = Color.Red;
            param_faz.xmax = 10;
            param_faz.xmin = -10;
            param_faz.ymax = 10;
            param_faz.ymin = -10;
            param_faz.stepx = (double)param_faz.xmax / 5;
            param_faz.stepy = (double)param_faz.ymax / 5;

            param_ta.backgroundcolor = Color.WhiteSmoke;
            param_ta.osicolor = Color.Black;
            param_ta.graphcolor = Color.Blue;
            param_ta.pointcolor = Color.Red;
            param_ta.xmax = 10;
            param_ta.xmin = -1;
            param_ta.ymax = 10;
            param_ta.ymin = -1;
            param_ta.stepx = (double)param_faz.xmax / 5;
            param_ta.stepy = (double)param_faz.ymax / 5;

            body.height = 20;
            body.width = 40;


            Kbox.Text = "0,5";
            LBox.Text = "10";
            X0Box.Text = "50";
            mBox.Text = "10";
            SpeedBox.Text = "25";
            MuBox.Text = "2";
            painting();
        }

        Parametrs param = new Parametrs();
        Parametrs param_faz = new Parametrs();
        Parametrs param_ta = new Parametrs();

        PhisycalBody body = new PhisycalBody();
        List<Dots> faz_line = new List<Dots>();
        List<Dots> TA_line = new List<Dots>();
        Bitmap bmp, bmp_faz, bmp_ta;
        Timer timer = new Timer();
        double K, l, mu, step_time;

        int counter_ta = 0;
        double counter_time=0, buffer_elem;


        private void painting()
        {
            bmp = new Bitmap(WorldPic.Width, WorldPic.Height);
            bmp_faz = new Bitmap(FazDiagram.Width, FazDiagram.Height);
            bmp_ta = new Bitmap(TAPic.Width, TAPic.Height);

            Graphics g = Graphics.FromImage(bmp),
                g_faz = Graphics.FromImage(bmp_faz),
                g_ta= Graphics.FromImage(bmp_ta);

            SolidBrush brush_back = new SolidBrush(param.backgroundcolor);
            SolidBrush brush_back_faz = new SolidBrush(param_faz.backgroundcolor);
            SolidBrush brush_dot_faz = new SolidBrush(param_faz.pointcolor);
            SolidBrush brush_body = new SolidBrush(param.bodycolor);

            g.FillRectangle(brush_back, 0, 0, WorldPic.Width, WorldPic.Height);
            g_faz.FillRectangle(brush_back_faz, 0, 0, FazDiagram.Width, FazDiagram.Height);
            //ручка для осей
            Pen osi = new Pen(param.osicolor, 3);
            osi.DashStyle = DashStyle.Solid;

            Pen graph_pen = new Pen(param_faz.graphcolor, 2);
            Pen body_pen = new Pen(param.bodycolor, 3);
            Pen setka_pen = new Pen(param.setkacolor, 1);
            setka_pen.DashStyle = DashStyle.Dot;
            Pen prij_pen=new Pen(param.prujcolor, 8);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g_faz.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g_ta.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g_faz.TextRenderingHint = TextRenderingHint.AntiAlias;
            g_ta.TextRenderingHint = TextRenderingHint.AntiAlias;

            SolidBrush brush_earth = new SolidBrush(Color.Chocolate);
            double width = bmp.Width, height = bmp.Height,
                width_faz = FazDiagram.Width, height_faz = FazDiagram.Height,
                width_ta = TAPic.Width, height_ta=TAPic.Height;
            g.FillRectangle(brush_earth, 0, (float)param.Y(height, 0) + (float)body.height / 2, (float)width, (float)height - (float)param.Y(height, 0) + (float)body.height / 2); //типа земля

            //рисую ось
            g.DrawLine(osi, (float)param.X(width, param.xmin), (float)param.Y(height, 0), (float)param.X(width, param.xmax), (float)param.Y(height, 0)); 


            //рисую сетку

            //право вертикаль
            for (double i = param.stepx; i <= param.xmax; i += param.stepx)
            {
                g.DrawLine(setka_pen, (float)param.X(width, i), (float)param.Y(height, param.ymin), (float)param.X(width, i), (float)param.Y(height, param.ymax));
            }
            //лево вертикаль
            for (double i = 0; i >= param.xmin; i -= param.stepx)
            {
                g.DrawLine(setka_pen, (float)param.X(width, i), (float)param.Y(height, param.ymin), (float)param.X(width, i), (float)param.Y(height, param.ymax));
            }
            //верх горизонталь
            for (double i = param.stepy; i <= param.ymax; i += param.stepy)
            {
                g.DrawLine(setka_pen, (float)param.X(width, param.xmin), (float)param.Y(height, i), (float)param.X(width, param.xmax), (float)param.Y(height, i));
            }

            //подписываю оси
            String str;
            Font font = new Font("Arial", 8);

            SolidBrush brush_text = new SolidBrush(param.osicolor);            

            //вправо
            for (double i = 0; i <= param.xmax; i += param.stepx)
            {
                str = i.ToString("F2");
                g.DrawString(str, font, brush_text, (float)param.X(width, i), (float)param.Y(height, param.ymin) - 16);
            }
            //влево
            for (double i = -param.stepx; i >= param.xmin; i -= param.stepx)
            {
                str = i.ToString("F2");
                g.DrawString(str, font, brush_text, (float)param.X(width, i), (float)param.Y(height, param.ymin) -16);
            }

            //вверх
            for (double i = param.stepy; i <= param.ymax; i += param.stepy)
            {
                str = i.ToString("F1");
                g.DrawString(str, font, brush_text, (float)param.X(width, param.xmin), (float)param.Y(height, i) + 2);
            }

            g.DrawLine(prij_pen, (float)param.X(width, 0), (float)param.Y(height, param.ymax),
                (float)param.X(width, body.x), (float)param.Y(height, body.y));
            g.FillRectangle(brush_body, (float)param.X(width, (body.x)) - (float)body.width / 2,
               (float)param.Y(height, body.y) - (float)body.height / 2, (float)body.width, (float)body.height);


            /******************************************Фазовая диграмма****************************************/
            //рисую сетку

            //право вертикаль
            for (double i = param_faz.stepx; i <= param_faz.xmax; i += param_faz.stepx)
            {
                g_faz.DrawLine(setka_pen, (float)param_faz.X(width_faz, i), (float)param_faz.Y(height_faz, param_faz.ymin),
                    (float)param_faz.X(width_faz, i), (float)param_faz.Y(height_faz, param_faz.ymax));
            }
            //лево вертикаль
            for (double i = 0; i >= param_faz.xmin; i -= param_faz.stepx)
            {
                g_faz.DrawLine(setka_pen, (float)param_faz.X(width_faz, i), (float)param_faz.Y(height_faz, param_faz.ymin),
                    (float)param_faz.X(width_faz, i), (float)param_faz.Y(height_faz, param_faz.ymax));
            }
            //верх горизонталь
            for (double i = 0; i <= param_faz.ymax; i += param_faz.stepy)
            {
                g_faz.DrawLine(setka_pen, (float)param_faz.X(width_faz, param_faz.xmin), (float)param_faz.Y(height_faz, i),
                    (float)param_faz.X(width_faz, param_faz.xmax), (float)param_faz.Y(height_faz, i));
            }
            //низ горизонталь
            for (double i = -param_faz.stepy; i >= param_faz.ymin; i -= param_faz.stepy)
            {
                g_faz.DrawLine(setka_pen, (float)param_faz.X(width_faz, param_faz.xmin), (float)param_faz.Y(height_faz, i),
                    (float)param_faz.X(width_faz, param_faz.xmax), (float)param_faz.Y(height_faz, i));
            }


            //подписываю
            //вправо
            for (double i = 0; i <= param_faz.xmax; i += param_faz.stepx)
            {
                str = i.ToString("F2");
                g_faz.DrawString(str, font, brush_text, (float)param_faz.X(width_faz, i), (float)param_faz.Y(height_faz, param_faz.ymin) - 16);
            }
            //влево
            for (double i = -param_faz.stepx; i >= param_faz.xmin; i -= param_faz.stepx)
            {
                str = i.ToString("F2");
                g_faz.DrawString(str, font, brush_text, (float)param_faz.X(width_faz, i), (float)param_faz.Y(height_faz, param_faz.ymin) - 16);
            }

            //вверх
            for (double i = 0; i <= param_faz.ymax; i += param_faz.stepy)
            {
                str = i.ToString("F1");
                g_faz.DrawString(str, font, brush_text, (float)param_faz.X(width_faz, param_faz.xmin), (float)param_faz.Y(height_faz, i) + 2);
            }
            //вниз
            for (double i = -param_faz.stepy; i >= param_faz.ymin; i -= param_faz.stepy)
            {
                str = i.ToString("F1");
                g_faz.DrawString(str, font, brush_text, (float)param_faz.X(width_faz, param_faz.xmin), (float)param_faz.Y(height_faz, i) + 2);
            }
            /********************************************Зависимость периода от амплитуды************************************************/
            g_ta.DrawLine(osi, (float)param_ta.X(width_ta, param_ta.xmin), (float)param_ta.Y(height_ta, 0),
                (float)param_ta.X(width_ta, param_ta.xmax), (float)param_ta.Y(height_ta, 0));

          

            //рисую сетку

            //право вертикаль
            for (double i = param_ta.stepx; i <= param_ta.xmax; i += param_ta.stepx)
            {
                g_ta.DrawLine(setka_pen, (float)param_ta.X(width_ta, i), (float)param_ta.Y(height_ta, param_ta.ymin),
                    (float)param_ta.X(width_ta, i), (float)param_ta.Y(height_ta, param_ta.ymax));
            }
            //лево вертикаль
            for (double i = 0; i >= param_ta.xmin; i -= param_ta.stepx)
            {
                g_ta.DrawLine(setka_pen, (float)param_ta.X(width_ta, i), (float)param_ta.Y(height_ta, param_ta.ymin),
                    (float)param_ta.X(width_ta, i), (float)param_ta.Y(height_ta, param_ta.ymax));
            }
            //верх горизонталь
            for (double i = 0; i <= param_ta.ymax; i += param_ta.stepy)
            {
                g_ta.DrawLine(setka_pen, (float)param_ta.X(width_ta, param_ta.xmin), (float)param_ta.Y(height_ta, i),
                    (float)param_ta.X(width_ta, param_ta.xmax), (float)param_ta.Y(height_ta, i));
            }
            //низ горизонталь
            for (double i = -param_ta.stepy; i >= param_ta.ymin; i -= param_ta.stepy)
            {
                g_ta.DrawLine(setka_pen, (float)param_ta.X(width_ta, param_ta.xmin), (float)param_ta.Y(height_ta, i),
                    (float)param_ta.X(width_ta, param_ta.xmax), (float)param_ta.Y(height_ta, i));
            }

            //подписываю
            //вправо
            for (double i = 0; i <= param_ta.xmax; i += param_ta.stepx)
            {
                str = i.ToString("F2");
                g_ta.DrawString(str, font, brush_text, (float)param_ta.X(width_ta, i), (float)param_ta.Y(height_ta, param_ta.ymin) - 16);
            }

            //вверх
            for (double i = param_ta.stepy; i <= param_ta.ymax; i += param_ta.stepy)
            {
                str = i.ToString("F2");
                g_ta.DrawString(str, font, brush_text, (float)param_ta.X(width_ta, param_ta.xmin), (float)param_ta.Y(height_ta, i) + 2);
            }

            if(TA_line.Count>1)
            {
                for (int i = 1; i < TA_line.Count; i++)
                {
                    g_ta.DrawLine(graph_pen, (float)param_ta.X(width_ta, TA_line[i-1].x), (float)param_ta.Y(height_ta, TA_line[i-1].y),
                        (float)param_ta.X(width_ta, TA_line[i].x), (float)param_ta.Y(height_ta, TA_line[i].y));
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            g_faz.FillEllipse(brush_dot_faz, (float)param_faz.X(width_faz, body.x), (float)param_faz.Y(height_faz, body.dx), 6, 6);
            if (faz_line.Count > 1)
            {
                for (int i = 0; i < faz_line.Count - 1; i++)
                {
                    g_faz.DrawLine(graph_pen, (float)param_faz.X(width_faz, faz_line[i].x), (float)param_faz.Y(height_faz, faz_line[i].y),
                        (float)param_faz.X(width_faz, faz_line[i + 1].x), (float)param_faz.Y(height_faz, faz_line[i + 1].y));
                }
            }


            WorldPic.Image = bmp;
            FazDiagram.Image = bmp_faz;
            TAPic.Image = bmp_ta;

        }

        void RungeKutt(double dt)  //метод Рунге-Кутты
        {

            double xx = body.x;
            double yy = body.y;
            double dxx = body.dx;
            double dyy = body.dy;
            double dtt = dt;
            double k1x = ddx(xx, dxx) * dtt;
            double k2x = ddx(xx + (double)dxx * dtt / 2, dxx + (double)k1x / 2) * dtt;
            double k3x = ddx(xx + (double)dxx * dtt / 2 + (double)k1x * dtt / 4, dxx + (double)k2x / 2) * dtt;
            double k4x = ddx(xx + (double)dxx * dtt + k2x * dtt / 2, dxx + k3x) * dtt;
            body.x = xx + dxx * dtt + (double)1 / 6 * (k1x + k2x + k3x) * dtt;
            body.dx = dxx + (double)1 / 6 * (2 * k2x + 2 * k3x + k1x + k4x);

        }

        double ddx(double x, double dx)
        {
            if (!trenie.Checked) return -K * (Math.Sqrt(l * l + x * x) - l) * x / (Math.Sqrt(l * l + x * x) * body.m);
            else
            {
                if (body.dx > 0) return -K * (Math.Sqrt(l * l + x * x) - l) * x / Math.Sqrt(l * l + x * x) * body.m - mu * 9.832;
                else return -K * (Math.Sqrt(l * l + x * x) - l) * x / Math.Sqrt(l * l + x * x) * body.m + mu * 9.832;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RungeKutt(step_time);
            if (body.x < param.xmin) { param.xmin = body.x + body.x / 8; param.xmax = -body.x - body.x / 8; }
            if (body.x > param.xmax) { param.xmax = body.x + body.x / 8; param.xmin = -body.x - body.x / 8; }
            if (body.x > param_faz.xmax) { param_faz.xmax = body.x + body.x / 8; param_faz.xmin = -body.x - body.x / 8; }
            if (body.x < param_faz.xmin) { param_faz.xmin = body.x + body.x / 8; param_faz.xmax = -body.x - body.x / 8; }
            if ((body.dx < param_faz.ymin)) { param_faz.ymin = body.dx + body.dx / 8; param_faz.ymax = -body.dx - body.dx / 8; }
            if ((body.dx > param_faz.ymax)) { param_faz.ymax = body.dx + body.dx / 8; param_faz.ymin = -body.dx - body.dx / 8; }
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 2;

            param_faz.stepx = (double)param_faz.xmax / 5;
            param_faz.stepy = (double)param_faz.ymax / 5;


           

            SpeedStream.Text = body.dx.ToString("F3")+" м/c";


            if(counter_ta>0)
            {
                counter_time+=step_time;
            }

            if (faz_line.Count > 0)
            {
                if (Math.Abs(faz_line.Last().x - body.x) < 0.001) { timer1.Stop(); MessageBox.Show("Расчёт остановлен, т.к. кооридната не изменяется.", "Уведомление"); }
                if ((buffer_elem * body.dx) < 0)
                {
                    if (counter_ta < 2)
                    {
                        counter_ta++;
                        
                    }
                    else
                    {
                        counter_ta = 1;
                        Dots dot_buf = new Dots(Math.Abs(body.x), counter_time); 
                        counter_time = 0;
                        TA_line.Add(dot_buf);

                        if (TA_line.Count == 1)
                        {
                            param_ta.ymax = dot_buf.y;
                            param_ta.xmax = dot_buf.x;
                        }
                        if (param_ta.ymax < dot_buf.y) param_ta.ymax = dot_buf.y;
                        if (param_ta.xmax < dot_buf.x) param_ta.xmax = dot_buf.x;
                        param_ta.ymin = -param_ta.ymax / 14;
                        param_ta.xmin = -param_ta.xmax / 100;
                        param_ta.stepx = (double)param_ta.xmax / 5;
                        param_ta.stepy = (double)param_ta.ymax / 5;
                    }
                }
            }



            

            Dots dot = new Dots(body.x, body.dx);
            faz_line.Add(dot);
            buffer_elem = dot.y;

            

            period_stream.Text = counter_time.ToString("F3")+ " c";
            painting();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            //восстановление исходного размера окон
            param.xmin = -50;
            param.xmax = 50;
            param.ymin = -1;
            param.ymax = 10;
            param.stepx = (double)param.xmax / 5;
            param.stepy = (double)param.ymax / 2;

            //восстановление исходного размера окон
            param_faz.xmax = 10;
            param_faz.xmin = -10;
            param_faz.ymax = 10;
            param_faz.ymin = -10;
            param_faz.stepx = (double)param_faz.xmax / 5;
            param_faz.stepy = (double)param_faz.ymax / 5;


            //
            param_ta.xmax = 10;
            param_ta.xmin = -1;
            param_ta.ymax = 10;
            param_ta.ymin = -1;
            param_ta.stepx = (double)param_faz.xmax / 5;
            param_ta.stepy = (double)param_faz.ymax / 5;

            step_time = 0.01;
            TA_line.Clear();
            faz_line.Clear();
            body.m = double.Parse(mBox.Text);
            K = double.Parse(Kbox.Text);
            body.x = double.Parse(X0Box.Text);
            l = double.Parse(LBox.Text);
            mu = double.Parse(MuBox.Text);
            body.dx = double.Parse(SpeedBox.Text);
            body.height = 20;
            body.width = 40;
            painting();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
