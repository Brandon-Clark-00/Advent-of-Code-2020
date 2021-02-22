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
    public partial class day6 : Form
    {
        public day6()
        {
            InitializeComponent();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        List<string> input = System.IO.File.ReadLines("day6.txt").ToList();

        private void day6_Load(object sender, EventArgs e)
        {
            string temp="";
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (String.Compare(input[i],"") !=0)
                {
                    if (string.Compare(input[i], " ") != 0)
                    {
                        temp += input[i];
                    }
                    if (i ==input.Count-1)
                    {
                        string dis = new string(temp.Distinct().ToArray());
                        sum += dis.Length;
                        temp = "";
                    }
                }
                else
                {
                    string dis = new string(temp.Distinct().ToArray());
                    sum += dis.Length;
                    temp = "";
                }
            }

            Console.Out.WriteLine("Sum total: " + sum);
            char[] letters =
            {
                'a', 'b', 'c',       // 2
                'd', 'e', 'f',       // 3
                'g', 'h', 'i',       // 4
                'j', 'k', 'l',       // 5
                'm', 'n', 'o',       // 6
                'p', 'q', 'r', 's',  // 7
                't', 'u', 'v',       // 8
                'w', 'x', 'y', 'z',  // 9
                ' '                  // 0
            };

            // Part 2
            int counter = 0, sum2 = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (String.Compare(input[i],"") != 0)
                {
                    temp += input[i];
                    counter++;
                    if (i == input.Count-1)
                    {
                        for (int j = 0; j < letters.Length; j++)
                        {
                            if (temp.Count(c => c == letters[j]) == counter )
                            {
                                sum2++;
                            }
                        }

                        temp = "";
                        counter = 0;
                    }
                }
                else
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (temp.Count(c => c == letters[j]) == counter)
                        {
                            sum2++;
                        }
                    }

                    temp = "";
                    counter = 0;
                }
            }
            Console.Out.WriteLine("Sum 2 total:" + sum2);
        }
    }
}
