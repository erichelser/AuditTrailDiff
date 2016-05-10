using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] lines = textBox1.Lines;
            System.IO.StreamWriter ouf1 = new System.IO.StreamWriter("atd_out_A.txt");
            System.IO.StreamWriter ouf2 = new System.IO.StreamWriter("atd_out_B.txt");
            bool olddata = false;
            bool newdata = false;
            int recordCount = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim().Length == 0)
                    continue;

                if (lines[i].StartsWith("\tNew :"))
                {
                    newdata = true;
                    olddata = false;
                }
                else if (lines[i].StartsWith("\tOld :"))
                {
                    newdata = false;
                    olddata = true;
                }
                else if (lines[i].StartsWith("==") && lines[i].EndsWith("=="))
                {
                    newdata = false;
                    olddata = false;
                }
                else if (containsLengthQualifier(lines[i]))
                {
                    newdata = false;
                    olddata = false;
                }
                if (lines[i].Contains("====START===="))
                    recordCount++;

                lines[i] = Convert.ToString(1000+recordCount).Substring(1,3) + " " + lines[i];
                lines[i] = lines[i].Trim();

                if(!newdata)
                    ouf1.WriteLine(lines[i].Replace("\tOld :", "\t--- :"));
                if(!olddata)
                    ouf2.WriteLine(lines[i].Replace("\tNew :", "\t--- :"));
            }
            ouf1.Close();
            ouf2.Close();

            System.Diagnostics.ProcessStartInfo process =
                new System.Diagnostics.ProcessStartInfo(diffprogram.Text,
                       "\"" + Environment.CurrentDirectory + "\\atd_out_A.txt\" " +
                       "\"" + Environment.CurrentDirectory + "\\atd_out_B.txt\" ");

            System.Diagnostics.Process.Start(process);
        }

        private bool containsLengthQualifier(string p)
        {
            string test = "";
            char[] ch = p.ToCharArray();
            Boolean previousCharWasNumeric = false;
            for (int i = 0; i < ch.Length; i++)
            {
                if (isNumeric(ch[i]))
                {
                    if (!previousCharWasNumeric)
                    {
                        test += "#";
                        previousCharWasNumeric = true;
                    }
                }
                else
                {
                    test += ch[i];
                    previousCharWasNumeric = false;
                }
            }
            return test.Contains("(#:#)");
        }

        private bool isNumeric(char p)
        {
            return "0123456789".Contains(p+"");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearfield_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}