using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public partial class day2 : Form
    {
        public day2()
        {
            InitializeComponent();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


   /*     public struct password
        {
            public int min, max;
            public char letter;
            public string pass;
        };*/
/*
        List<password> passwords;*/
        List<string> lines;

        private void day2_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            lines = System.IO.File.ReadLines("bb2.txt").ToList();
            char[] delims = { ' ', '-', ':' };
            int valid = 0, valid2 = 0;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] sections = lines[i].Split(delims);

                //part 1
                int freq = Regex.Matches(sections[4], sections[2]).Count;
                if (freq < Int16.Parse(sections[0]) || freq > Int16.Parse(sections[1]))
                {

                }
                else
                {
                    valid++;
                }

                //Part 2
                if (string.Compare(sections[4][Int16.Parse(sections[0]) - 1].ToString(), sections[2]) == 0 ^ string.Compare(sections[4][Int16.Parse(sections[1]) - 1].ToString(), sections[2]) == 0)
                {
                    valid2++;
                }

            }

            outputLbl.Text = valid + " valid passwords for part 1, " + valid2 + " valid passwords for part 2";
            Console.Out.WriteLine(valid + " valid passwords for part 1, " + valid2 + " valid passwords for part 2");
            watch.Stop();
            Console.WriteLine($"Execution time: {watch.ElapsedMilliseconds} ms");

        }
    }
}
