using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


/// <summary>
///  Nabin Atreya Sunar
///  ID: C7202333
///  College: The British College
/// </summary>
namespace Assignment1
{
    public class CommandParser
    {

        /// <summary>
        /// This class is used to check the validation part of this program.
        /// </summary>
        /// <param name="input">Takes the text from the user input</param>
        /// <param name="temp1">Compare this parameter to the another class. i.e. 2nd input as integer</param>
        /// <param name="temp2">Compare this parameter to the another class. i.e. 3rd input as integer</param>
        /// <returns>The text, for getting the text from input</returns>
        /// 

        public static Color colour;
        public static bool isPen = false;
        public static bool isFillOn = false;
        //Creating string array method getValidtae with parameters.
        public string[] ValidationCheck(string input, int temp1, int temp2)
        {

            string[] txt = { }; 
            string[] send = input.Split(',',' ');

            {
                if (send[0].ToUpper() == "MOVETO"){
                    if (send.Length < 4){
                        int x = Convert.ToInt32(send[1]);
                        int y = Convert.ToInt32(send[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "moveto", a1, b1 };
                        txt = k;
                    }
                }

                else{

                    if (send[0].ToUpper() == "DRAWTO") {
                        if (send.Length == 3)
                        {
                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string[] k = { "drawto", a1, b1 };
                            txt = k;
                        }
                        else {
                            MessageBox.Show("Opps...Sorry ! Incorrect Parameter for moveto method. ");
                            string[] n = { "moveto,100,100" };
                            txt = n;
                        }

                    }
                     else if (send[0].ToUpper() == "RECTANGLE"){
                        if (send.Length == 3)
                        {
                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string[] k = { "rectangle", a1, b1 };
                            txt = k;
                        }
                        else
                        {
                            MessageBox.Show("Opps...Sorry ! Incorrect Parameter for Rectangle. ");
                            string[] n = { "rectangle, 20,40" };
                            txt = n;
                        }
                     }

                     else if (send[0].ToUpper() == "CIRCLE") {
                        if (send.Length == 2)
                        {
                            int x = Convert.ToInt32(send[1]);
                            string a1 = Convert.ToString(x * 2);
                            string[] k = { "circle", a1 };
                            txt = k;
                        }
                        else
                        {
                            MessageBox.Show("Opps...Sorry ! Incorrect Parameter for Circle. ");
                            string[] n = { "circle,20" };
                            txt = n;
                        }
                     }

                    else if (send[0].ToUpper() == "TRIANGLE") {
                        if (send.Length == 4)
                        {

                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            int z = Convert.ToInt32(send[3]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string c1 = Convert.ToString(z);
                            string[] k = { "triangle", a1, b1, c1 };
                            txt = k;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Oppps...! Sorry. Not Suitable Side To Form Triangle.");
                            string[] n = { "triangle,30,60,90" };
                            txt = n;
                        }
                    }

                    else if (send[0].ToUpper() == "PEN")
                    {
                        isPen = true;
                        string[] k = { "pen", send[1] };
                        txt = k;
                        if (send[1].Equals("red"))
                        {
                            colour = Color.Red;
                        }
                        //if parameter is blue then colour is set  to blue
                        else if (send[1].Equals("blue"))
                        {
                            colour = Color.Blue;
                        }
                        //if parameter is yellow then colour is set  to yellow
                        else if (send[1].Equals("yellow"))
                        {
                            colour = Color.Yellow;
                        }
                        //if parameter is gray then colour is set  to gray
                        else if (send[1].Equals("gray"))
                        {
                            colour = Color.Gray;
                        }
                        //if parameter is green then colour is set  to green
                        else if (send[1].Equals("green"))
                        {
                            colour = Color.Green;
                        }


                    }
                    else if (send[0].ToUpper() == "FILL")
                    {
                        string[] k = { "fill", send[1] };
                        txt = k;
                        if (send[1].Equals("on"))
                        {
                            isFillOn = true;
                        }
                        else
                        {
                            isFillOn = false;
                        }
                    }


                    else if (send[0].ToUpper() == "RUN")
                    { }
                    else if (send[0].ToUpper() == "RESET")
                    { }
                    else if (send[0].ToUpper() == "CLEAR"||send[0].ToLower()=="clear")
                    { }
                    else
                    {
                        string[] k = { "error" };
                        txt = k;
                    }
                }
                //end of else condition


                return txt;
            }
        }   //end of method

        internal Color getColor()
        {
            return colour;
        }

        /// <summary>
        /// the member is accessible from either the declaring assembly or from any derived type in any assembly.
        /// </summary>
        /// <param name="runtextbox">Returns as the textbox</param>
        /// <returns>runtextbox</returns>
        internal string[] getValidate(TextBox runtextbox)
        {
            throw new NotImplementedException();
        }
    }
}
