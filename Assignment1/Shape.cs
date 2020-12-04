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
    interface Shape
    {
        /// <summary>
        /// Declaring method that stores the first input from the user, draw in graphics with x and y parameter 
        /// </summary>
        /// <param name="inputStoring"> Stores Values from the user and stores in the array</param>
        /// <param name="g">Declaring g as Graphics inorder to draw shape</param>
        /// <param name="x">Acts as the X cordinate</param>
        /// <param name="y">Acts as the Y cordinate</param>
        ///  <param name="colour">It makes user to choose colour</param>
        void drawShape(String[] inputStoring, Graphics g, int x, int y,Color colour);
      
    }
}
