using System;
using System.Drawing;
using System.Windows.Forms;

namespace War
{
    public partial class War : Form
    {
        int cardCount = 0;
        int totalComputer = 0;
        int totalPlayer = 0;

        private void War_Load(object sender, EventArgs e)  
        {}

        //this is the image path for the images to load
        public const string imagePath = @"../pics/";

        //string arrays that set up the method to pull images of cards
        string[] suits = { "diamonds", "hearts", "clubs", "spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };        

        public War()
        {           
            InitializeComponent();
        }

        //new game button that clears the scores
        private void start_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            computerWin.Clear();
            playerWin.Clear();
            cardCount = 0;
            totalComputer = 0;
            totalPlayer = 0;
            playerBox.Image = Image.FromFile(@"..\pics\card.png");
            computerBox.Image = Image.FromFile(@"..\pics\card.png");
            draw.Enabled = true;

        }

        //draw button that is the body of the game
        private void draw_Click(object sender, EventArgs e)
        {
            

           //this makes sure that you only play 52 cards and only triggers when 52 cards are played
            cardCount += 1;
            if (cardCount == 26)
            {
                
                if (totalComputer > totalPlayer)
                {
                    MessageBox.Show ("The entire deck has been dealt!\n\tComputer wins!");
                    draw.Enabled = false;
                    return;
                }
                else if (totalComputer < totalPlayer)
                {
                    MessageBox.Show("The entire deck has been dealt!\n\tplayer wins!");
                    draw.Enabled = false;
                    return;
                } else
                {
                    MessageBox.Show("The entire deck has been dealt!\n\tit's a draw!");
                    draw.Enabled = false;
                    return;
                }
                
            }

            //creates random cards 
            Random fefe = new Random();

            int i = fefe.Next(13);
            int j = fefe.Next(4);
            int ii = fefe.Next(13);
            int jj = fefe.Next(4);

            //select cards that are randomized
            playerBox.Image = Image.FromFile(@"..\pics\" + ranks[i] + "_of_" +  suits[j]+ ".png");
            computerBox.Image = Image.FromFile(@"..\pics\" + ranks[ii] +"_of_" +  suits[jj]+ ".png");



            //compares the values of the cards based on rank
            //adds values and keeps score
            if (i > ii)
                {
                totalPlayer += 2;
                richTextBox1.Text = "Player gets 2 points";
                playerWin.Text = totalPlayer.ToString();
                 
                }
                else if (i < ii)
                {
                totalComputer += 2;
                richTextBox1.Text = "Computer gets 2 points";
                computerWin.Text = totalComputer.ToString();
                }
                else
                {
                totalComputer += 1;
                totalPlayer += 1;
                richTextBox1.Text = "1 point each";
                playerWin.Text = totalPlayer.ToString();
                computerWin.Text = totalComputer.ToString();
                }            
        }
       
        //closes the program down
        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
