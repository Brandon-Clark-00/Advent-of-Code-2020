using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class day1 : Form
    {
        public day1()
        {
            InitializeComponent();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void day1_Load(object sender, EventArgs e)
        {
            int part = 2;
         
            var watch = new System.Diagnostics.Stopwatch();
            watch.Restart();
            watch.Start();
            List<string> lines = System.IO.File.ReadLines("day1.txt").ToList();
            /* if (part == 1)
             {*/
            //part 1
            for (int i = 0; i < lines.Count(); i++)
                {
                    for (int j = 0; j < lines.Count(); j++)
                    {
                        if ((Int32.Parse(lines[i]) + (Int32.Parse(lines[j]))) == 2020)
                        {
                            output.Text = (Int32.Parse(lines[i]) * (Int32.Parse(lines[j]))).ToString();
                            break;
                        }

                    }
                }
           /* }
            else
            {*/
                //part 2
                for (int i = 0; i < lines.Count(); i++)
                {
                    if (Int32.Parse(lines[i]) < 1657)
                    {
                        for (int j = 0; j < lines.Count(); j++)
                        {
                            if (!((Int32.Parse(lines[i]) + (Int32.Parse(lines[j])) >= 2005)))
                            {
                                for (int k = 0; k < lines.Count(); k++)
                                {
                                    if ((Int32.Parse(lines[i]) + (Int32.Parse(lines[j])) + (Int32.Parse(lines[k]))) == 2020)
                                    {
                                        output.Text = (Int32.Parse(lines[i]) * (Int32.Parse(lines[j])) * (Int32.Parse(lines[k]))).ToString();
                                        break;
                                    }
                                }
                            }
                        }

                    }
                }
            /*}*/

            watch.Stop();
            

            Console.WriteLine($"Execution time: {watch.ElapsedMilliseconds} ms");
            
        }
    }
}
