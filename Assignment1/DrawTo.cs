using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
///  Nabin Atreya Sunar
///  ID: C7202333
///  College: The British College
/// </summary>
namespace Assignment1
{
    class DrawTo: Shape 
    {
        /// <summary>
        /// DrawTo class inherits the method of Shape interface.
        /// This drawShape method draw the line with the help of two parameter points.
        /// </summary>
        /// <param name="inputStoring">Stores the input from the textbox of a DrawTo class </param>
        /// <param name="g">Graphics of the DrawTo class.</param>
        /// <param name="x">First parameter of the DrawTo class method</param>
        /// <param name="y">Second parameter of the DrawTo class method</param>
        /// <param name="colour">It makes user to choose colour</param>
        /// 

        public void drawShape(string[] inputStoring, Graphics g, int x, int y,Color colour)
        {
            int a = Convert.ToInt32(inputStoring[1]);
            int b = Convert.ToInt32(inputStoring[2]);
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, x, y, a, b);
        }

     }
}
