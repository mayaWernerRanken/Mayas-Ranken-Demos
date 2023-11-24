namespace TestSoccerPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            SoccerPlayer player = new SoccerPlayer();
            SoccerPlayer player2 = new SoccerPlayer();
            player.SetPlayerName("Lionel Messi");
            player.SetJerseyNumber(10);
            player.SetGoalsScored(1000);
            player.SetAssists(1000);
            //player has a name of null
            //player has goals scored of 0
            //player has assists of 0
            //player has a jersey number of 0
            player2.SetPlayerName("Pele");
            player2.SetGoalsScored(900);
            player2.SetJerseyNumber(23);
            player2.SetAssists(300);


            lblResult2.Text = $"Player name: {player.GetPlayerName()}\n" +
                $"Player Jersey Number: {player.GetJerseyNumber()}\n" +
                $"Player Goals Scored : {player.GetGoalsScored()}\n" +
                $"Player assists: {player.GetAssists()} ";

            lblResult.Text = "\n \n \n";


            lblResult.Text = $"Player name: {player2.GetPlayerName()}\n" +
                $"Player Jersey Number: {player2.GetJerseyNumber()}\n" +
                $"Player Goals Scored : {player2.GetGoalsScored()}\n" +
                $"Player assists: {player2.GetAssists()} ";
        }
    }
}