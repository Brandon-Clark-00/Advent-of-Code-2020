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
    public partial class day4 : Form
    {
        public day4()
        {
            InitializeComponent();
        }


        List<string> lines;
        List<string> passports = new List<string>();
        List<List<string>> checkPass = new List<List<string>>();
        private void day4_Load(object sender, EventArgs e)
        {
            lines = System.IO.File.ReadLines("day4.txt").ToList();
            string temp = "";
            for (int i = 0; i < lines.Count; i++)
            {
                if (string.Compare(lines[i], "") != 0)
                {
                    temp += lines[i];
                    temp += " ";
                }
                else
                {
                    passports.Add(temp);
                    temp = "";
                }
            }

            int valid = 1, valid2 = 0;
            char[] delims = { ' ' };
            for (int i = 0; i < passports.Count; i++)
            {
                string t = passports[i];
                if (t.Contains("byr") && t.Contains("iyr") && t.Contains("eyr") && t.Contains("hgt") && t.Contains("hcl") && t.Contains("ecl") && t.Contains("pid"))
                {
                    valid++; checkPass.Add(passports[i].Split(delims).ToList());
                }
            }


            for (int i = 0; i < checkPass.Count; i++)
            {
                if (checkLine(i))
                {
                    Console.Out.WriteLine("Valid");
                    valid2++;
                }
                else
                {
                    Console.Out.WriteLine("Invalid");
                }
            }



            System.IO.File.WriteAllLines("day4.txt", passports);
            Console.Out.WriteLine("Lines: " + lines.Count + " Passports: " + passports.Count + " which " + valid + " are valid in part 1 and " + valid2 + " are valid in part 2");
        }

        bool checkLine(int i)
        {
            char[] delim = new char[] { ':' };
            for (int j = 0; j < checkPass[i].Count; j++)
            {
                string[] t = checkPass[i][j].Split(delim);
                if (t[0].StartsWith("byr"))
                {
                    if (!(Int16.Parse(t[1]) >= 1920 && Int16.Parse(t[1]) <= 2002))
                    {
                        Console.Out.WriteLine("invalid byr");
                        return false;
                    }
                }
                if (t[0].StartsWith("iyr"))
                {
                    if (!(Int16.Parse(t[1]) >= 2010 && Int16.Parse(t[1]) <= 2020))
                    {
                        Console.Out.WriteLine("invalid iyr");
                        return false;
                    }
                }
                if (t[0].StartsWith("eyr"))
                {
                    if (!(Int16.Parse(t[1]) >= 2020 && Int16.Parse(t[1]) <= 2030))
                    {
                        Console.Out.WriteLine("invalid eyr");
                        return false;
                    }
                }
                if (t[0].StartsWith("hgt"))
                {
                    int value = Int16.Parse(t[1].Substring(0, t[1].Length - 2));
                    if (t[1].EndsWith("cm"))
                    {
                        if (!(value >= 150 && value <= 193))
                        {
                            Console.Out.WriteLine("invalid hgt");
                            return false;
                        }
                    }
                    else
                    {
                        if (!(value >= 59 && value <= 76))
                        {
                            Console.Out.WriteLine("invalid hgt");
                            return false;
                        }
                    }
                }
                if (t[0].StartsWith("hcl"))
                {
                    if (!(t[1].StartsWith("#")))
                    {
                        Console.Out.WriteLine("invalid hcl");
                        return false;
                    }
                    else if (!FormatValid(t[1].Substring(1)))
                    {
                        Console.Out.WriteLine("invalid hcl");
                        return false;
                    }
                }
                if (t[0].StartsWith("ecl"))
                {
                    string[] allowed = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                    bool v = false;
                    for (int k = 0; k < allowed.Length; k++)
                    {
                        if (string.Compare(t[1],allowed[k]) == 0)
                        {
                            v = true;
                        }
                    }
                    if (v == false)
                    {
                        Console.Out.WriteLine("invalid ecl");
                        return false;
                    }
                }
                if (t[0].StartsWith("pid"))
                {
                    if (t[1].Length != 9)
                    {
                        Console.Out.WriteLine("invalid pid");
                        return false;
                    }
                }
            }
            return true;
        }

        bool FormatValid(string format)
        {
            string allowableLetters = "0123456789abcdef";

            foreach (char c in format)
            {
                // This is using String.Contains for .NET 2 compat.,
                //   hence the requirement for ToString()
                if (!allowableLetters.Contains(c.ToString()))
                    return false;
            }

            return true;
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
