using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number_Game_2
{
    public partial class Form1 : Form
    {
       Random randomnum=new Random();
        int num = 0;
        int diff = 0;

        
        public Form1()
        {
            InitializeComponent();
            LoadQuestions();

        }


        

        private void inputNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                inputNumber.Focus();
                int input = Convert.ToInt32(inputNumber.Text);
                
                if (input == num)
                {
                    this.BackColor = Color.LightGray;
                    MessageBox.Show("Correct Guess");
                    inputNumber.Text = "";
                    
                    
                }
                else if (input< num )
                {
                    this.BackColor = Color.Blue;
                    MessageBox.Show("Too low , Try a Higher number");
                    
                }
                else
                {
                    this.BackColor = Color.Red;
                    MessageBox.Show("Too high, Try a lower number");
                    
                }
                
            }

        }
        private void LoadQuestions()
        {
            num = randomnum.Next(1, 1001);
            lbl1.Text = "I am thinking of a number between 1 and 1000";
            
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            num = randomnum.Next(1, 1001);
            newGameBtn.Enabled = true;
            newGameBtn.BackColor = Color.White;
            inputNumber.Clear();
            
            this.BackColor = Color.White;
        }
    }
}
