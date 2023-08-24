namespace bandGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] bandNames =
            {
                "VIN METHANE",
                "THE GLUE EATERS",
                "CLEEZ AND THE POLICALLY CORECT",
                "GARM VANILLA",
                "VAGULY HAIR SEXALITY",
                "TAMELY PURGITORY FURRY",
                "BLARGSHNOOPUS",
                "KRAB",
                "THE START TIMES",
                "SONIC BURNOUT",
                "ELETRIC DREAMSCAPE",
                "THE NEON OUTLAWS",
                "SHADOW SIMPHONY",
                "COSMIC VIBRASHINS",
                "THE FUZZY HAZE",
                "THE VELVET UNDERGRONDERS",
                "THE SPACE CADETS",
                "GROOVE MANIACS",
                "THE DREAM MASHEENS"
            };

        private void btnGen_Click(object sender, EventArgs e)
        {
            Random ranName = new Random();
            int num = ranName.Next(bandNames.Length);
            lblName.Text = bandNames[num];


            

        }
    }
}