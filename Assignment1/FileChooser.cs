using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///  Nabin Atreya Sunar
///  ID: C7202333
///  College: The British College
/// </summary>
/// 
namespace Assignment1
{
    class FileChooser
    {
        /// <summary>
        /// This getShape method return the shape respectively from the userinput as inputs.
        /// </summary>
        /// <param name="input">Take input parameter as the string.</param>
        /// <returns>As specified in the if-else condition.</returns>
        public Shape getShape(String input)
        {
            {
                if (input == "rectangle")
                {
                    return new Rectangle();
                }
                else if (input == "circle")
                {
                   return new Circle();
                }else if(input== "triangle")
                {
                    return new Triangle();
                }
                else if(input=="drawto"){
                    return new DrawTo();
                }
                return null;
            }
        }
    }
}
        
    