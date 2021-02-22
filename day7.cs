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
    public partial class day7 : Form
    {
        public day7()
        {
            InitializeComponent();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        List<string> input = System.IO.File.ReadLines("input.txt").ToList();
        List<bag> bags = new List<bag>();
        struct bag
        {
            public string bagColor;
            public List<bag> contents;
            public int bagCount, index;

            public bag(int x = 1,int y = -1)
            {
                bagCount = x;
                index = y;
                bagColor = "";
                contents = new List<bag>();
            }
        }

        char[] delims = {','};
        private void day7_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < input.Count; i++)
            {
                bag temp = new bag(i);
                temp.bagColor = input[i].Substring(0, input[i].IndexOf(" bags"));
                temp.bagCount = 1;
                temp.index = i;
                
                string contentString = input[i].Substring(input[i].LastIndexOf("contain ")+8);
                if (!contentString.Contains("no other"))
                {
                    string[] line = contentString.Split(delims);
                    temp.contents = new List<bag>();
                    for (int j = 0; j < line.Length; j++)
                    {
                        line[j] = line[j].Trim();
                        bag contentTemp = new bag(line[j][0], j);
                        contentTemp.bagColor = line[j].Substring(2, line[j].Length - 7);
                        temp.contents.Add(contentTemp);
                    }
                }
               
                bags.Add(temp);
            }
            int gbOptions = -1;
            for (int i = 0; i < bags.Count; i++)
            {
                /*printRecursive("", i);*/
                if (countRecursive(i))
                {
                    Console.Out.WriteLine(i + " is true");
                    gbOptions++;
                }
                else
                {
                    Console.Out.WriteLine(i + " is false");
                }
            }

            Console.Out.WriteLine("Number of possible shinys: " + gbOptions);
            

        }


        void printRecursive(string indent, int index)
        {
            Console.Out.WriteLine(indent + bags[index].bagColor);
            if (bags[index].contents.Count>0)
            {
                for (int i = 0; i < bags[index].contents.Count; i++)
                {
                    
                    if (findBag(bags[index].contents[i].bagColor) != -1)
                    {
                        
                            printRecursive(indent + "-", findBag(bags[index].contents[i].bagColor));
                        
                        
                    }
                    else
                    {
                        
                            Console.Out.WriteLine(indent + "-" + bags[index].contents[i].bagColor);
                        
                    }
                    
                }
            }
            
            return;
        }
        bool countRecursive(int index)
        {
            if (string.Compare(bags[index].bagColor, "shiny gold") == 0)
            {
                return true;
            }
            else if(bags[index].contents.Count > 0)
            {
                    for (int i = 0; i < bags[index].contents.Count; i++)
                    {
                        if (findBag(bags[index].contents[i].bagColor) != -1)
                        {
                            
                            if (countRecursive(findBag(bags[index].contents[i].bagColor)))
                            {
                                return true;
                            }                        
                        }
                    }
            }
            else
            {
                return false;
            }
            return false;
        }

        int findBag(string sinput)
        {
            for (int i = 0; i < bags.Count; i++)
            {
                if (bags[i].bagColor.Contains(sinput))
                {
                    return bags[i].index;
                }
            }
            return -1;
        }

    }
}
