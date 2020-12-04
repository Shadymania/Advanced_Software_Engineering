using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
///  Nabin Atreya Sunar
///  ID: C7202333
///  College: The British College
/// </summary>
namespace Assignment1
{
    public partial class Form1 : Form
    {
       

        int point1 = 0, point2 = 0;
        Pen p;
        SolidBrush sb;
        Graphics g;

  
        public Form1()
        {
            InitializeComponent();
            g = Canvas.CreateGraphics();
        }

        /// <summary>
        /// Checks all the command and draw specific patterns as defined.
        /// </summary>
        public void RunProgramMethod()
        {
            try {
                String input = CordinateBox.Text;
                CommandParser cmd = new CommandParser();
                String[] val = cmd.ValidationCheck(input, point1, point2);
                if (val[0] == "moveto")
                {
                    int a = Convert.ToInt32(val[1]);
                    int b = Convert.ToInt32(val[2]);
                    point1 = a;
                    point2 = b;
                }
                if (val[0] == "drawto")
                {
                    Color colour = cmd.getColor();
                    FileChooser s1 = new FileChooser();
                    Shape sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, point1, point2,colour);
                }

                else if (val[0] == "rectangle")
                {
                    Color colour = cmd.getColor();
                    FileChooser s1 = new FileChooser();
                    Shape sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, point1, point2,colour);
                
                }
                else if (val[0] == "circle")
                {
                    Color colour = cmd.getColor();
                    FileChooser s1 = new FileChooser();
                    Shape sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, point1, point2,colour);
                }

                else if (val[0] == "triangle")
                {
                    Color colour = cmd.getColor();
                    FileChooser s1 = new FileChooser();
                    Shape sh = s1.getShape(val[0]);
                    sh.drawShape(val, g, point1, point2,colour);
                }

                else if (val[0] == "error")
                {
                    MessageBox.Show("Opppps...! Sorry. Error Occured.");
                }
                else if (input.ToUpper() == "RUN")
                {
                    MultipleLineMethod();
                }
                else
                {

                }
            }
            catch (Exception e) { }
        }

        /// <summary>
        /// This method is used to take the input from the user which reads
        /// the multiple line from the textbox.
        /// </summary>
        public void MultipleLineMethod()
        {
            try {
                CommandParser cmd = new CommandParser();
                Color colour = cmd.getColor();
                int counter = MultipleText.Lines.Length;
                for (int i = 0; i < counter; i++)
                {

                    String input = string.Format("text");
                    input = MultipleText.Lines[i];
                    CommandParser cp = new CommandParser();
                    String[] val = cp.ValidationCheck(input, point1, point2);
                    if (val[0] == "moveto")
                    {
                        int a = Convert.ToInt32(val[1]);
                        int b = Convert.ToInt32(val[2]);
                        point1 = a;
                        point2 = b;
                    }
                    else if (val[0] == "drawto")
                    {
                       
                        FileChooser s1 = new FileChooser();
                        Shape sh = s1.getShape(val[0]);
                        sh.drawShape(val, g, point1, point2,colour);
                    }

                    else if (val[0] == "rectangle")
                    {
                       
                        FileChooser s1 = new FileChooser();
                        Shape sh = s1.getShape(val[0]);
                        sh.drawShape(val, g, point1, point2,colour);
                    }
                    else if (val[0] == "circle")
                    {
                        FileChooser s1 = new FileChooser();
                        Shape sh = s1.getShape(val[0]);
                        sh.drawShape(val, g, point1, point2,colour);
                    }

                    else if (val[0] == "triangle")
                    {
                        FileChooser s1 = new FileChooser();
                        Shape sh = s1.getShape(val[0]);
                        sh.drawShape(val, g, point1, point2,colour);
                    }

                    else if (val[0].ToUpper() == "PEN")
                    {

                        CommandParser.isPen = true;
                        if (val[1].Equals("red"))
                        {

                            CommandParser.colour = Color.Red;
                        }
                        //if parameter is blue then colour is set  to blue
                        else if (val[1].Equals("blue"))
                        {
                            CommandParser.colour = Color.Blue;
                        }
                        //if parameter is yellow then colour is set  to yellow
                        else if (val[1].Equals("yellow"))
                        {
                            CommandParser.colour = Color.Yellow;
                        }
                        //if parameter is gray then colour is set  to gray
                        else if (val[1].Equals("gray"))
                        {
                            CommandParser.colour = Color.Gray;
                        }
                        //if parameter is green then colour is set  to green
                        else if (val[1].Equals("green"))
                        {
                            colour = Color.Green;
                        }


                    }
                    else if (val[0].ToUpper() == "FILL")
                    {

                        if (val[1].Equals("on"))
                        {
                            CommandParser.isFillOn = true;
                        }
                        else
                        {
                            CommandParser.isFillOn = false;
                        }
                    }


                    else if (val[0] == "error")
                    {
                        MessageBox.Show("Please enter valid value");
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception e) { }
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /// <summary>
        /// This method calls the MultipleLineMethod();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            MultipleLineMethod();
        }

        /// <summary>
        /// This method calls the RunProgramMethod();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            RunProgramMethod();
        }

        /// <summary>
        /// This method clears the shapes in the canvas panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
           Canvas.Refresh();
        }


        /// <summary>
        /// This method is used for the opening file in the program. For 2nd component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(openFile.FileName));
                MultipleText.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }

        /// <summary>
        /// This method is used for the saving file in the program. For 2nd component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(saveFile.FileName));
                saveStream.Write(MultipleText.Text);
                saveStream.Dispose();
            }
        }

        /// <summary>
        /// reset the cursor or coordinates as 0,0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            point1 = 0;
            point2 = 0;
        }

        /// <summary>
        /// It terminate the program. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CordinateBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        /// <summary>
        ///  reads and exeutes from the keyboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CordinateBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (CordinateBox.Text.ToUpper() == "RUN"||CordinateBox.Text.ToLower()=="run")
            {
                MultipleLineMethod();
            }
            else if (CordinateBox.Text.ToUpper() == "CLEAR" || CordinateBox.Text.ToLower()=="clear")
            {
                Canvas.Refresh();
                MultipleText.Clear();
            }
            else if (CordinateBox.Text.ToUpper() == "RESET" ||CordinateBox.Text.ToLower()=="reset")
            {
                point1 = 0;
                point2 = 0;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Not used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultipleText_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Using Cursor in the MENUSTRIP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Open the new window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        /// <summary>
        /// Exists the specific window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Closed += (s, args) => this.Close();
        }

        /// <summary>
        /// Open the About Us form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }


        /// <summary>
        /// Not used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
