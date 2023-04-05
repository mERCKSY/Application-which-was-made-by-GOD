using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_which_was_made_by_GOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sleep = 100;
        int eat = 100;
        int hp = 100;
        int happiness = 100;
        int money = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hp!=0)
            {
                switch (rnd.Next(1,4))
                {
                    case 1:
                        if (sleep != 0)
                        {
                            sleep--;
                        }
                        else
                        {
                            hp--;
                        }
                        break;
                    case 2:
                        if (eat!= 0)
                        {
                            eat--;
                        }
                        else
                        {
                            hp--;
                        }
                        break;
                    case 3:
                        if (happiness != 0)
                        {
                            happiness--;
                        }
                        else
                        {
                            hp--;
                        }
                        break;
                    default:
                        MessageBox.Show("fniijnfq");                        
                        break;
                }
                Sleepbar.Value = sleep;
                Hungerbar.Value = eat;
                Amusebar.Value = happiness;
                Healthbar.Value = hp;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing");
        }

        private void food_Click(object sender, EventArgs e)
        {
            if (eat!=100)
            {
                eat++;
                Sleepbar.Value = eat;
            }
            
            
        }

       

        private void bed_Click(object sender, EventArgs e)
        {
            if (sleep != 100)
            {
                sleep++;
                Sleepbar.Value = sleep;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (money != 100)
            {
                money++;
                moneyBar.Value = money;
            }
        }

        private void buyHimASweetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyBar.Value = money - 10;
          
        }

        private void candle20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyBar.Value = money - 2;
        }

        private void aPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyBar.Value = money - 80;
        }

        private void aWhisky10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyBar.Value = money - 5;
        }

        private void drugs200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyBar.Value = money - 100;
        }

    }
}
