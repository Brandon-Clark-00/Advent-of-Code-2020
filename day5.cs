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
    public partial class day5 : Form
    {
        public day5()
        {
            InitializeComponent();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        List<string> input = System.IO.File.ReadLines("day5.txt").ToList();
        List<double> seats = new List<double>();
        public struct seat
        {
            public double row, column, ID;
        }
        private void day5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < input.Count; i++)
            {

                Console.Out.WriteLine("====================");
                seat temp = new seat();
                double rMin = 0, rMax = 128, cMin =0, cMax = 7 ;
                double row = Math.Floor((rMax + rMin) / 2), column = Math.Round((cMax + cMin) / 2);
                Console.Out.WriteLine("0- min:" + cMin + " mid:" + column + " max:" + cMax);
                for (int j = 0; j < input[i].Length; j++)
                {
                    
                    switch(input[i][j])
                    {
                        case 'F':
                            rMax = row;
                            row = findMid(rMin, rMax,1);
                 /*           Console.Out.WriteLine(input[i][j] + "- min:" + rMin + " mid:" + row + " max:" + rMax);*/
                            break;
                        case 'B':
                            rMin = row;
                            row = findMid(rMin, rMax,0);
                          /*  Console.Out.WriteLine(input[i][j] + "- min:" + rMin + " mid:" + row + " max:" + rMax);*/
                            break;
                        case 'R':
                            cMin = column;
                            if (j == 9)
                            {
                                column = cMax;
                            }
                            else
                            {

                               column = findMid(cMin, cMax, 1);
                            }
                          /*  Console.Out.WriteLine(input[i][j] + "- min:" + cMin + " mid:" + column + " max:" + cMax);*/
                            break;
                        case 'L':
                            cMax = column;
                            if (j == 9)
                            {
                                column = cMin;
                            }
                            else
                            {
                                column = findMid(cMin, cMax, 1);
                            }
                       /*     Console.Out.WriteLine(input[i][j] + "- min:" + cMin + " mid:" + column + " max:" + cMax);*/
                            break;
                    }

                }
                temp.row = row;
                temp.column = 1+ column;
                temp.ID = (row * 8) + column;
                seats.Add(temp.ID);
            }

            List<double> orderedSeats = seats.OrderBy(number => number).ToList();
            for (int i = 0; i < orderedSeats.Count; i++)
            {
                Console.Out.WriteLine(orderedSeats[i]);
            }
            double maxID = 0, myID = -1;

            for (int i = 0; i < orderedSeats.Count-1; i++)
            {
                if (orderedSeats[i+1] - orderedSeats[i] != 1)
                {
                    myID = orderedSeats[i] + 1;
                }
                if (orderedSeats[i]> maxID)
                {
                    maxID = orderedSeats[i];
                }
            }

            Console.Out.WriteLine("The highest ID is " + maxID + " and my seat is num " + myID);
        }

        double findMid(double min, double max, int mode)
        {
            if (mode == 0)
            {
                return Math.Floor((max + min) / 2);
            }
            else
            {
                return Math.Round((max + min) / 2);
            }
           
        }
    }
}
