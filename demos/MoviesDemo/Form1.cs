namespace MoviesDemo
{
    public partial class Form1 : Form
    {
        //Seed my movie data
        List<Movie> myMovies = new List<Movie>()
        {
            new Movie("The Matrix","blah blah blah", "1999"),
            new Movie("Speed","blah blah blah","1994"),
            new Movie("John Wick","blah blah blah","2014")
        };
        int foundIndex = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userSearchValue = txtSearch.Text;

            bool foundMovie = false;

            for (int i = 0; i < myMovies.Count; i++)
            {
                if (myMovies[i].Name.ToLower().Contains(userSearchValue.ToLower()))
                {
                    foundMovie = true;
                    lblResult.Text = myMovies[i].ToString();
                    grpUpdate.Visible = true;
                    foundIndex = i;
                    txtUpdateDescription.Text = myMovies[i].Description;
                    txtUpdateName.Text = myMovies[i].Name;
                    txtUpdateYear.Text = myMovies[i].Year;
                    break;
                }
            }
            if (foundMovie == false)
            {
                lblResult.Text = "Movie not found";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Read user data from the form
            string movieName = txtMovieName.Text;
            string movieYear = txtMovieYear.Text;
            string movieDescription = txtMovieDescription.Text;

            //Instantiate a movie object
            Movie movieToAdd = new Movie(movieName, movieDescription, movieYear);

            //Add the object to the list
            myMovies.Add(movieToAdd);

            lblAddResult.Text = "Movie added!";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myMovies[foundIndex].Year = txtUpdateYear.Text;
            myMovies[foundIndex].Name = txtUpdateName.Text;
            myMovies[foundIndex].Description = txtUpdateDescription.Text;

            lblUpdateResult.Text = "Movie Updated!";
        }
    }
}