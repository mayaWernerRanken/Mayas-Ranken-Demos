namespace TestSalesTransaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalesTransaction_Click(object sender, EventArgs e)
        {
            //Clears the text property of lblResult
            lblResult.Text = null;


            //SalesTransaction t1 = new SalesTransaction("Jacob", 1000m, .08);
            //lblResult.Text = t1.ToString();

            //Dimensions the array
            SalesTransaction[] dailyTransactions = new SalesTransaction[]
            {
                new SalesTransaction("Jacob 1", 1000m, 0.08),
                new SalesTransaction("Jacob 2", 2000m, 0.09),
                new SalesTransaction("Jacob 3", 3000m, 0.10),
                new SalesTransaction("Jacob 4", 4000m, 0.11)
            };

            //Construct the objects
            //dailyTransactions[0] = new SalesTransaction("Jacob 1", 1000m, 0.08);
            //dailyTransactions[1] = new SalesTransaction("Jacob 2", 2000m, 0.09);
            //dailyTransactions[2] = new SalesTransaction("Jacob 3", 3000m, 0.10);

            for (int i = 0; i < dailyTransactions.Length; i++)
            {
                lblResult.Text += dailyTransactions[i].ToString();
            }

        }
    }
}