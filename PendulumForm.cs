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
            param.stepy = (double)param.ymax / 5;
            param.osicolor = Color.Black;
            param.setkacolor = Color.Black;
            param.backgroundcolor = Color.LightBlue;
            param.graphcolor = Color.Red;
            param.pointcolor = Color.Brown;


            param_faz.backgroundcolor = Color.WhiteSmoke;
            param_faz.osicolor = Color.Black;
            param_faz.graphcolor = Color.Blue;
            param_faz.pointcolor = Color.Red;
            param_faz.xmax = 10;
            param_faz.xmin = -10;
            param_faz.ymax = 10;
            param_faz.ymin = -10;

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
        PhisycalBody body = new PhisycalBody();
        List<Dots> faz_line = new List<Dots>();
        Bitmap bmp, bmp_faz;
        Timer timer = new Timer();
        double K, l, mu;


        private void painting()
        {
            bmp = new Bitmap(WorldPic.Width, WorldPic.Height);
            bmp_faz = new Bitmap(FazDiagram.Width, FazDiagram.Height);

            Graphics g = Graphics.FromImage(bmp),
                g_faz = Graphics.FromImage(bmp_faz);

            SolidBrush brush_back = new SolidBrush(param.backgroundcolor);
            SolidBrush brush_back_faz = new SolidBrush(param_faz.backgroundcolor);
            SolidBrush brush_dot_faz = new SolidBrush(param_faz.pointcolor);

            g.FillRectangle(brush_back, 0, 0, WorldPic.Width, WorldPic.Height);
            g_faz.FillRectangle(brush_back_faz, 0, 0, FazDiagram.Width, FazDiagram.Height);
            //ручка для осей
            Pen osi = new Pen(param.osicolor, 3);
            osi.DashStyle = DashStyle.Solid;

            Pen graph_pen = new Pen(param_faz.graphcolor, 2);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g_faz.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            double width = bmp.Width, height = bmp.Height,
                width_faz = FazDiagram.Width, height_faz = FazDiagram.Height;

            //рисую оси
            g.DrawLine(osi, (float)param.X(width, param.xmin), (float)param.Y(height, 0), (float)param.X(width, param.xmax), (float)param.Y(height, 0));
            g.DrawEllipse(osi, (float)param.X(width, body.x), (float)param.Y(height, body.y), 20, 20);

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
            RungeKutt(0.05);
            if (body.x < param.xmin) { param.xmin = body.x; param.xmax = -body.x; }
            if (body.x > param.xmax) { param.xmax = body.x; param.xmin = -body.x; }
            if (body.x > param_faz.xmax) { param_faz.xmax = body.x + body.x / 8; param_faz.xmin = -body.x - body.x / 8; }
            if (body.x < param_faz.xmin) { param_faz.xmin = body.x + body.x / 8; param_faz.xmax = -body.x - body.x / 8; }
            if (body.dx < param_faz.ymin) { param_faz.ymin = body.dx + body.dx / 8; param_faz.ymax = -body.dx - body.dx / 8; }
            if (body.dx > param_faz.ymax) { param_faz.ymax = body.dx + body.dx / 8; param_faz.ymin = -body.dx - body.dx / 8; }
            Speed.Text = body.dx.ToString("F4");
            Dots dot = new Dots(body.x, body.dx);
            faz_line.Add(dot);
            painting();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            faz_line.Clear();
            body.m = double.Parse(mBox.Text);
            K = double.Parse(Kbox.Text);
            body.x = double.Parse(X0Box.Text);
            l = double.Parse(LBox.Text);
            mu = double.Parse(MuBox.Text);
            body.dx = double.Parse(SpeedBox.Text);
            painting();
            timer1.Start();
        }
    }
}
