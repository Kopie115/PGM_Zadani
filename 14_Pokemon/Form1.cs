namespace _14_Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pokedex.AddPokemon(new Pokemon("Gengar", "Poison", 30, 50, 20, 30));
            pokedex.AddPokemon(new Pokemon("Ghastly", "Poison", 30, 30, 20, 40));
            pokedex.AddPokemon(new Pokemon("Squirtle", "Water", 10, 2690, 210, 850));

            label1.Text = pokedex.ToString();
        }
        Pokedex pokedex = new Pokedex();
    }
}