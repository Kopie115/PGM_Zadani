namespace Filmotéka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Movie> list = new List<Movie>();
            Movie m1 = new Movie("abc", "def");
            Movie m2 = new Movie("bfl", "mpsvz");
            Movie m3 = new Movie("asdsa", "qew");
            Movie m4 = new Movie("123", "456");

            m2.Note = "Novotný";
            m3.Rating = 60;
            listBoxMovies.Items.Add(m1);
            listBoxMovies.Items.Add(m2);
            listBoxMovies.Items.Add(m3);
            listBoxMovies.Items.Add(m4);

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(txtMovieName.Text, txtMovieDirector.Text);
            listBoxMovies.Items.Add(movie);

            List<Movie> listFilmu = new List<Movie>();
            foreach (var item in listBoxMovies.Items)
            {
                listFilmu.Add((Movie)item);
            }

            listFilmu.Sort();

            listBoxMovies.Items.Clear(); // Vyčistit ListBox
            foreach (var item in listFilmu)
            {
                listBoxMovies.Items.Add(item); // Přidat zpět setříděné položky
            }

            // Vypíšeme do labelu
            string serazene = "";
            foreach (var item in listFilmu)
            {
                serazene += item.ToString() + "\r\n";
            }
            lblInfo.Text = serazene;
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
