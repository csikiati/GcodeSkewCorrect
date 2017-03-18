using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcodeSkewCorrect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI*angle/180.0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog1 = new OpenFileDialog();

            fileDialog1.InitialDirectory = @"E:\Autodesk\STL";
            fileDialog1.Title = "Browse Gcode files";

            fileDialog1.CheckFileExists = true;
            fileDialog1.CheckPathExists = true;

            fileDialog1.DefaultExt = "gcode";
            fileDialog1.Filter = "G-code (*.gcode)|*.gcode|All files (*.*)|*.*";
            fileDialog1.FilterIndex = 2;
            fileDialog1.RestoreDirectory = true;

            fileDialog1.ReadOnlyChecked = true;
            fileDialog1.ShowReadOnly = true;

            if (fileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbOrigGcode.Text = fileDialog1.FileName;
            }

        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string newline;

            double yMultiplier = Math.Round(Math.Tan((DegreeToRadian(Convert.ToDouble(tbXY.Text)))), 3);
            //calculate the trigo stuff once to save precious process time

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(tbOrigGcode.Text);
            System.IO.StreamWriter file2 = new System.IO.StreamWriter("D:\\SkewCorrectedOutput.gcode");

            file2.WriteLine(";Original unconverted filename:");
            file2.WriteLine(";" + tbOrigGcode.Text);
            file2.WriteLine(";XY°=" + tbXY.Text);
            file2.WriteLine(";ZX°=" + tbZX.Text);
            file2.WriteLine(";ZY°=" + tbZY.Text);
            file2.WriteLine(";Converted by GcodeSkewCorrect (c) Attila Csiki 2017");

            while ((line = file.ReadLine()) != null) //do it until end of file
            {
                newline = line;
                var splitted = line.Split(' '); //splitting the line into words
                if (splitted[0].StartsWith("G1") || splitted[0].StartsWith("G0"))
                    // only G1 and G0 commands are important so if first word is G1 or G0 then
                {
                    //initializing line level variables
                    //double newX = 0;
                    double newY = 0;
                    var oldX = "";
                    var oldY = "";
                    var oldF = "";
                    var oldE = "";
                    var gString = "";
                    var xString = "";
                    var yString = "";
                    var fString = "";
                    var eString = "";
                    var zString = "";

                    char c = new char();
                    bool isF = false;
                    bool isX = false;
                    bool isY = false;
                    bool isE = false;
                    bool isZ = false;

                    isF = false;
                    isX = false;
                    isY = false;
                    isE = false;

                    if (splitted[0].StartsWith("G1"))
                    {
                        gString = "G1";
                    }

                    if (splitted[0].StartsWith("G0"))
                    {
                        gString = "G0";
                    }

                    for (int i = 1; i < splitted.Count(); i++) //going through all relevant values
                    {


                        if (splitted[i].Length > 1)
                        {
                            c = splitted[i][0];
                            switch (c) //getting all the F, X, Y, and E values from the G1 comand
                            {
                                case 'F':
                                    oldF = splitted[i].TrimStart('F');
                                    isF = true;
                                    fString = " " + splitted[i];
                                    break;
                                case 'X':
                                    oldX = splitted[i].TrimStart('X');
                                    isX = true;
                                    break;
                                case 'Y':
                                    oldY = splitted[i].TrimStart('Y');
                                    isY = true;
                                    break;
                                case 'Z':
                                    zString = " " + splitted[i];
                                    isZ = true;
                                    break;
                                case 'E':
                                    oldE = splitted[i].TrimStart('E');
                                    eString = " " + splitted[i];
                                    isE = true;
                                    break;
                                default:
                                    break;
                            }


                        }


                        if (isX & isY)
                        {
                            double a = double.Parse(oldY, System.Globalization.CultureInfo.InvariantCulture);
                            double b = double.Parse(oldX, System.Globalization.CultureInfo.InvariantCulture);
                            double m = yMultiplier;
                            xString = " X" + oldX;
                            newY = a - (b*m);
                            yString = " Y" + Math.Round(newY, 3).ToString().Replace(',', '.');

                            newline = gString + fString + xString + yString + zString + eString;

                        }
                        else
                        {
                            newline = line;
                        }
                    }
                }

                file2.WriteLine(newline);
                //Console.WriteLine(line);
                counter++;
            }

            file.Close();
            file2.Close();

            MessageBox.Show("File is converted. Rejoice in the Lord!", "Breaking news");

            // Suspend the screen.
            Console.ReadLine();
        }
    }
}