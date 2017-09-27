using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendulum
{
    class PhisycalBody
    {
        public double m, y_ris, x_ris, x, y, dx, dy, ddx, ddy;
        public double width, height;
        

        public PhisycalBody (double M, float w, float h, double x, double y)
        {
            m = M;
            width = w;
            height = h;
            y = 0;
            y_ris = (double)h / 2;
            x_ris = x - w / 2;
        }

        public PhisycalBody()
        {
            m = 1;
            width = 10;
            height = 1;
            y_ris = 0.5;
            x = 0;
            y = 0;
            x_ris = x - width / 2;
        }
    }
}
