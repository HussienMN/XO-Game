using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        int xWins = 0;
        int yWins = 0;
        int d = 0;
        bool turn = true;
        int turn_count = 0 ;
        Button[] b = new Button[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b1.Text = "";
            b2.Enabled = true;
            b2.Text = "";
            b3.Enabled = true;
            b3.Text = "";
            b4.Enabled = true;
            b4.Text = "";
            b5.Enabled = true;
            b5.Text = "";
            b6.Enabled = true;
            b6.Text = "";
            b7.Enabled = true;
            b7.Text = "";
            b8.Enabled = true;
            b8.Text = "";
            b9.Enabled = true;
            b9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                b[i] = new Button();
                b[i].Width = 100;
                b[i].Height = 100;
            } 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            check();
        }
        private void check() 
        {
            bool win = false;
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                win = true;
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
                win = true;
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
                win = true;
            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b7.Enabled))
                win = true;
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b8.Enabled))
                win = true;
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b9.Enabled))
                win = true;
            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b9.Enabled))
                win = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b7.Enabled))
                win = true;
            
            if (win)
            {

                b1.Enabled = true;
                b1.Text = "";
                b2.Enabled = true;
                b2.Text = "";
                b3.Enabled = true;
                b3.Text = "";
                b4.Enabled = true;
                b4.Text = "";
                b5.Enabled = true;
                b5.Text = "";
                b6.Enabled = true;
                b6.Text = "";
                b7.Enabled = true;
                b7.Text = "";
                b8.Enabled = true;
                b8.Text = "";
                b9.Enabled = true;
                b9.Text = "";
                string winner = "";
                if (turn)
                {
                    winner = "O";
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    label3.Text = (int.Parse(label3.Text) + 1).ToString();

                }
                MessageBox.Show("the winner is :"+winner);                 
                
            }else
            {
                if (turn_count == 9)
                    MessageBox.Show("No winner");
            }
           
        }
        private void display()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
