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
    public partial class day3 : Form
    {
        public day3()
        {
            InitializeComponent();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        List<string> lines;


        int slope(int right, int down)
        {
            int trees = 0;
            int width = lines[0].Length;
            int x = 0, y = 0;
            while (y < lines.Count)
            {
                Console.Out.WriteLine("x:" + x + " y:" + y);
                if (lines[y][x] == '#')
                {
                    trees++;
                }


                x += right;
                if (x >= width)
                {
                    x -= width;
                    if (x < 0)
                    {
                        x = 0;
                    }
                }
                y += down;
            }
            Console.Out.WriteLine("Num of trees: " + trees);
            return trees;
        }

        private void day3_Load(object sender, EventArgs e)
        {

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            lines = System.IO.File.ReadLines("day3.txt").ToList();
            
            
            int total = slope(1, 1);
           
            total *= slope(3, 1);
          
            total *= slope(5, 1);
           
            total *= slope(7, 1);

            total *= slope(1, 2);

            Console.Out.WriteLine("Total slope: " + total);


            watch.Stop();
            Console.WriteLine($"Execution time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
