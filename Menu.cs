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
    public partial class Menu : Form
    {


        struct dayInfo
            {
            public dayInfo(int x, int y, Color z)
            {
                completed = 1;
                dayNum = 1;
                dayColor = Color.Green;
            }

            public int completed;
            int dayNum;
            public Color dayColor;

                
            
            };

        dayInfo[,] adventInfo = new dayInfo[5, 5];

        Button[,] btn = new Button[5,5];
        int completed =0;
        int currDay = 4;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            int counter = 1;
            int other= 0;
            for (int y  = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (completed<=counter)
                    {
                        adventInfo[y, x].completed = 2;
                    }
                    if (counter <= currDay)
                    {
                        adventInfo[y, x].dayColor = Color.Green;
                        if (adventInfo[y, x].completed == 1)
                        {
                            adventInfo[y, x].dayColor = Color.Blue;
                        }
                        else if (adventInfo[y, x].completed == 2)
                        {
                            adventInfo[y, x].dayColor = Color.Gold;
                        }
                    }
                    else
                    {
                        adventInfo[y, x].dayColor = Color.Red;
                    }
                    
                    btn[y,x] = new Button();
                    btn[y, x].SetBounds(50 + (100 * x),50 +(100 * y),50,50);
                    btn[y, x].Name = "day" + counter;
                    btn[y, x].Text = "Day " + counter;
                    btn[y, x].BackColor = adventInfo[y,x].dayColor;
                    btn[y,x].Click += new EventHandler(this.btnEvent_Click);
                    counter++;
                    Controls.Add(btn[y, x]);
                }
            }    
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            day7 temp = new day7();
            temp.ShowDialog();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
                
       


