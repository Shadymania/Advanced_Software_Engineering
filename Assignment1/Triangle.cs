using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Nabin Atreya Sunar
/// ID: C7202333
/// The British College
/// </summary>
namespace Assignment1
{
    class Triangle: Shape
    {

        /// <summary>
        /// Triangle class also inherits the Shape interface property.
        /// </summary>
        /// <param name="inputStoring">Stores the input from the textbox of a Triangle class</param>
        /// <param name="g">Graphics of the Triangle class</param>
        /// <param name="x">First parameter of the Triangle class method</param>
        /// <param name="y">First parameter of the Triangle class method</param>
        /// <param name="colour">It makes user to choose colour</param>
        /// 
        Color pencolor = CommandParser.colour;
        public void drawShape(string[] inputStoring, Graphics g, int x, int y,Color colour)
        {
            int point2 = 0;
            int value = 0;
            int c = Convert.ToInt32(inputStoring[1]);
            int d = Convert.ToInt32(inputStoring[2]);
            int e = Convert.ToInt32(inputStoring[3]);
            if (c + d > e && c + e > d && d + e > c)
            {
                if (d > c)
                {
                    if (e > d)
                    {
                        value = e;
                        e = c;
                        c = value;
                    }
                    else
                    {
                        value = d;
                        d = c;
                        c = value;
                    }
                }
               
                if (e > c)
                {
                    value = e;
                    e = c;
                    c = value;
                }

                
                double s = (c + d + e) / 2;
                double area = Math.Sqrt(s * (s - c) * (s - d) * (s - e));
                double h = 2 * area / c;
                double point = (h * h) - (d* d);
                int h2 = Convert.ToInt32(h);
                if (point < 0)
                {
                    point *= (-1);
                    double finalValue = Math.Sqrt(point);
                    point2 = Convert.ToInt32(finalValue);

                }
                else
                {
                    double finalValue = Math.Sqrt(point);
                    point2 = Convert.ToInt32(finalValue);
                }


                Point[] points = new Point[3];
                points[0] = new Point(x, y);
                points[1] = new Point(x, c+y);
                points[2] = new Point(h2+x, point2+y);
                if (CommandParser.isPen == true)
                {

                    Pen p = new Pen(pencolor, 2);
                    g.DrawLine(p, points[0], points[1]);
                    g.DrawLine(p, points[1], points[2]);
                    g.DrawLine(p, points[0], points[2]);
                }
                else
                {
                    Pen p = new Pen(Color.Black, 2);
                    g.DrawLine(p, points[0], points[1]);
                    g.DrawLine(p, points[1], points[2]);
                    g.DrawLine(p, points[0], points[2]);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Opps...Sorry ! No Suitable Side for Triangle. ");

            }
        }
    }
}
