namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //Initiating Button: Start - Play again - New Game
        private void BtnTttStart_Click(object sender, EventArgs e)
        {
            if ((BtnTttStart.Text == "Start Game!") ||
                (BtnTttStart.Text == "Play Again!")
               )
            {
                BtnTttStart.Text = "New Game!";

                BtnTtt1.Enabled = true;
                BtnTtt2.Enabled = true;
                BtnTtt3.Enabled = true;
                BtnTtt4.Enabled = true;
                BtnTtt5.Enabled = true;
                BtnTtt6.Enabled = true;
                BtnTtt7.Enabled = true;
                BtnTtt8.Enabled = true;
                BtnTtt9.Enabled = true;

                BtnTtt1.Text = "";
                BtnTtt2.Text = "";
                BtnTtt3.Text = "";
                BtnTtt4.Text = "";
                BtnTtt5.Text = "";
                BtnTtt6.Text = "";
                BtnTtt7.Text = "";
                BtnTtt8.Text = "";
                BtnTtt9.Text = "";

            }
            else if(BtnTttStart.Text == "New Game!")
            {
                BtnTttStart.Text = "Play Again!";

                BtnTtt1.Enabled = false;
                BtnTtt2.Enabled = false;
                BtnTtt3.Enabled = false;
                BtnTtt4.Enabled = false;
                BtnTtt5.Enabled = false;
                BtnTtt6.Enabled = false;
                BtnTtt7.Enabled = false;
                BtnTtt8.Enabled = false;
                BtnTtt9.Enabled = false;

                BtnTtt1.Text = "T";
                BtnTtt2.Text = "I";
                BtnTtt3.Text = "C";
                BtnTtt4.Text = "T";
                BtnTtt5.Text = "A";
                BtnTtt6.Text = "C";
                BtnTtt7.Text = "T";
                BtnTtt8.Text = "O";
                BtnTtt9.Text = "E";

                BtnTttPlayer.Text = "X";

            }
        }
        

        //Individual Control Buttons
        private void BtnTtt1_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt1.Text = BtnTttPlayer.Text;
            BtnTtt1.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt2_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt2.Text = BtnTttPlayer.Text;
            BtnTtt2.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt3_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt3.Text = BtnTttPlayer.Text;
            BtnTtt3.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt4_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt4.Text = BtnTttPlayer.Text;
            BtnTtt4.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt5_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt5.Text = BtnTttPlayer.Text;
            BtnTtt5.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt6_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt6.Text = BtnTttPlayer.Text;
            BtnTtt6.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt7_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt7.Text = BtnTttPlayer.Text;
            BtnTtt7.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt8_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt8.Text = BtnTttPlayer.Text;
            BtnTtt8.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt9_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt9.Text = BtnTttPlayer.Text;
            BtnTtt9.Enabled = false;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
        
        //Processing Button
        private void BtnTttPlayer_Click(object sender, EventArgs e)
        {
            if (BtnTttPlayer.Text == "X")
            {
                BtnTttPlayer.Text = "O";
            }
            else
            {
                BtnTttPlayer.Text = "X";
            }
           
            //Winning Conditions
            //Player 1
            if (
                ((BtnTtt1.Text == "X") && (BtnTtt2.Text == "X") && (BtnTtt3.Text == "X")) || //Horizontal 1st row
                ((BtnTtt4.Text == "X") && (BtnTtt5.Text == "X") && (BtnTtt6.Text == "X")) || //Horizontal 2nd row
                ((BtnTtt7.Text == "X") && (BtnTtt8.Text == "X") && (BtnTtt9.Text == "X")) || //Horizontal 3rd row
                ((BtnTtt1.Text == "X") && (BtnTtt5.Text == "X") && (BtnTtt9.Text == "X")) || //Diagonal 1-5-9
                ((BtnTtt3.Text == "X") && (BtnTtt5.Text == "X") && (BtnTtt7.Text == "X")) || //Diagonal 3-5-7
                ((BtnTtt1.Text == "X") && (BtnTtt4.Text == "X") && (BtnTtt7.Text == "X")) || //Vertical 1st Column
                ((BtnTtt2.Text == "X") && (BtnTtt5.Text == "X") && (BtnTtt8.Text == "X")) || //Vertical 1st Column
                ((BtnTtt3.Text == "X") && (BtnTtt6.Text == "X") && (BtnTtt9.Text == "X"))    //Vertical 1st Column
              )
            {
                MessageBox.Show(TbTttP1Nn.Text + " Wins!");
                
                BtnTttStart.PerformClick();
            //Scoring Player 1    
                byte initialscore1 = byte.Parse(LblTttScore1.Text);
                byte add1 = 1;
                int score1 = initialscore1 + add1;
                if (byte.Parse(LblTttScore1.Text) >= 0)
                {
                    LblTttScore1.Text = score1.ToString();
                }
            }
            //Player 2
            else if (
                ((BtnTtt1.Text == "O") && (BtnTtt2.Text == "O") && (BtnTtt3.Text == "O")) || //Horizontal 1st row
                ((BtnTtt4.Text == "O") && (BtnTtt5.Text == "O") && (BtnTtt6.Text == "O")) || //Horizontal 2nd row
                ((BtnTtt7.Text == "O") && (BtnTtt8.Text == "O") && (BtnTtt9.Text == "O")) || //Horizontal 3rd row
                ((BtnTtt1.Text == "O") && (BtnTtt5.Text == "O") && (BtnTtt9.Text == "O")) || //Diagonal 1-5-9
                ((BtnTtt3.Text == "O") && (BtnTtt5.Text == "O") && (BtnTtt7.Text == "O")) || //Diagonal 3-5-7
                ((BtnTtt1.Text == "O") && (BtnTtt4.Text == "O") && (BtnTtt7.Text == "O")) || //Vertical 1st Column
                ((BtnTtt2.Text == "O") && (BtnTtt5.Text == "O") && (BtnTtt8.Text == "O")) || //Vertical 1st Column
                ((BtnTtt3.Text == "O") && (BtnTtt6.Text == "O") && (BtnTtt9.Text == "O"))    //Vertical 1st Column
                    )
            {
                MessageBox.Show(TbTttP2Nn.Text + " Wins!");
               
                BtnTttStart.PerformClick();
             //Scoring Player 2  
                    byte initialscore2 = byte.Parse(LblTttScore2.Text);
                    byte add1 = 1;
                    int score2 = initialscore2 + add1;
                    if (byte.Parse(LblTttScore2.Text) >= 0)
                    {
                        LblTttScore2.Text = score2.ToString();
                    }        
            }
            
            //Draw condition
            if (
                (BtnTttStart.Text == "Finish!") &&
                (BtnTtt1.Enabled == false) &&
                (BtnTtt2.Enabled == false) &&
                (BtnTtt3.Enabled == false) &&
                (BtnTtt4.Enabled == false) &&
                (BtnTtt5.Enabled == false) &&
                (BtnTtt6.Enabled == false) &&
                (BtnTtt7.Enabled == false) &&
                (BtnTtt8.Enabled == false) &&
                (BtnTtt9.Enabled == false)
               )
            {
                MessageBox.Show("Draw!");
                BtnTttStart.PerformClick();
            }

            //Next turn label
            if (BtnTttPlayer.Text == "X")
            {
                LblTttNextMove.Text = "Next turn: " + TbTttP1Nn.Text;
            }
            else if (BtnTttPlayer.Text == "O")
            {
                LblTttNextMove.Text = "Next turn: " + TbTttP2Nn.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblTttP1Enn_Click(object sender, EventArgs e)
        {

        }

        // Reset Score Button
        private void BtnTttResetScore_Click(object sender, EventArgs e)
        {
            byte reset = 0;
            LblTttScore1.Text = reset.ToString();
            LblTttScore2.Text = reset.ToString();
        }
    }
}