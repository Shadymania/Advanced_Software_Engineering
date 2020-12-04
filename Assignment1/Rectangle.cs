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
    
    class Rectangle : Shape
    {
        /// <summary>
        /// Rectangle class inherits the property of Shape interface.
        /// </summary>
        /// <param name="inputStoring">Stores the input from the textbox of a Rectangle class </param>
        /// <param name="g">Graphics of the Rectangle class.</param>
        /// <param name="x">First parameter of the Rectangle</param>
        /// <param name="y">Second parameter of the Rectanggle</param>
        ///  <param name="colour">It makes user to choose colour</param>
        /// 
        Color pencolor = CommandParser.colour;
        public void drawShape(string[] inputStoring, Graphics g, int x, int y,Color colour)
        {




            if (CommandParser.isFillOn == true)
            {
                if (CommandParser.isPen == true)
                {
                    SolidBrush ab = new SolidBrush(pencolor);
                    int c = Convert.ToInt32(inputStoring[1]);
                    int d = Convert.ToInt32(inputStoring[2]);
                    Pen p = new Pen(pencolor, 2);
                    g.FillRectangle(ab, x, y, c, d);
                }
                else
                {
                    SolidBrush ab = new SolidBrush(Color.Black);
                    int c = Convert.ToInt32(inputStoring[1]);
                    int d = Convert.ToInt32(inputStoring[2]);
                    Pen p = new Pen(pencolor, 2);
                    g.FillRectangle(ab, x, y, c, d);
                }
            }
            else
            {
                if (CommandParser.isPen == true)
                {

                    int c = Convert.ToInt32(inputStoring[1]);
                    int d = Convert.ToInt32(inputStoring[2]);
                    Pen p = new Pen(pencolor, 2);
                    g.DrawRectangle(p, x, y, c, d);
                }
                else
                {
                    int c = Convert.ToInt32(inputStoring[1]);
                    int d = Convert.ToInt32(inputStoring[2]);
                    Pen p = new Pen(Color.Black, 2);
                    g.DrawRectangle(p, x, y, c, d);


                }
            }
        }
    }
}
