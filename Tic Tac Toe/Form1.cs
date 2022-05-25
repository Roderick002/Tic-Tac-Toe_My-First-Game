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

        private void BtnTttStart_Click(object sender, EventArgs e)
        {
           
            if (BtnTttStart.Text == "Start Game!" )
            {
                BtnTttStart.Text = "Finish";
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
            else if(BtnTttStart.Text == "Finish")
            {
                BtnTttStart.Text = "Start Game!";
                BtnTtt1.Text = "T";
                BtnTtt2.Text = "I";
                BtnTtt3.Text = "C";
                BtnTtt4.Text = "T";
                BtnTtt5.Text = "A";
                BtnTtt6.Text = "C";
                BtnTtt7.Text = "T";
                BtnTtt8.Text = "O";
                BtnTtt9.Text = "E";
            }
        }
        


        private void BtnTtt1_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt1.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt2_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt2.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt3_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt3.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt4_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt4.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt5_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt5.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt6_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt6.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt7_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt7.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt8_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt8.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

        private void BtnTtt9_Click(object sender, EventArgs e)
        {
            BtnTttPlayer.Enabled = true;
            BtnTtt9.Text = BtnTttPlayer.Text;
            BtnTttPlayer.PerformClick();
            BtnTttPlayer.Enabled = false;
        }

       
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

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
            
        }
       
    }
}