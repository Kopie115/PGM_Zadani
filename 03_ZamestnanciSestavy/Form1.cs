namespace ZamestnanciSestavy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] jmena = {
    "Marie", "Marcela", "Jan", "Petr", "Jiøí", "Dagmar", "Karel", "Josef", "Zdenìk",
    "Pavla", "Aneta", "Dana", "Leopold", "Richard", "Stanislav", "Miroslav", "Pavel",
    "Jaroslava", "Vìra", "Hana", "Bronislava", "Jaroslav", "Ludmila", "Radek", "Vlasta",
    "Lucie", "Vlastimil", "Miroslava", "Anna", "Lenka", "Antonie", "Václav", "Ondøej",
    "Jana", "Miloslav", "Daniel", "Zdenka", "Jitka", "Lukáš", "František", "Libuše",
    "Tomáš", "Josefa", "David", "Helena", "Nikolay", "Vladimír", "Štefanie", "Kateøina", "Martin"
};
            string[] prijmeni = {
    "Hudeèková", "Poláková", "Kopøiva", "Goliáš", "Salava", "Truchlá", "Zýka", "Peterka", "Lisník",
    "Sychrová", "Píchová", "Švejdová", "Tjasko", "Záhorec", "Kubát", "Hokeš", "Trávníèek",
    "Švrèková", "Vtelenská", "Hekrdlová", "Potùèková", "Moric", "Uhýrková", "Urbánek", "Prchlíková",
    "Matošková", "Cenker", "Bezdìková", "Nìmcová", "Riegerová", "Szabová", "Pešek", "Malèík",
    "Divišová", "Frydrych", "Liška", "Janotová", "Èervinková", "Pøibylák", "Svoboda", "Švejdíková",
    "Hrabák", "Jiránková", "Paloc", "Prùchová", "Konvalinka", "Hala", "Sklenská", "Èeèotková", "Leš"
};

            for (int i = 0; i < 50; i++)
            {
                listBoxZamestnanci.Items.Add(
                    new Zamestnanec(jmena[random.Next(50)],
                                    prijmeni[random.Next(50)],
                                    random.Next(0, 24),
                                    random.NextDouble() < 0.2)
                    );
            }
        }

        private void btnTop5Zamestnancu_Click(object sender, EventArgs e)
        {
            List<Zamestnanec> topZ = listBoxZamestnanci.Items
                .Cast<Zamestnanec>()
                .OrderByDescending(x => x.PocetHodin)
                .Take(5)
                .ToList();

            MessageBox.Show(String.Join("\r\n", topZ));
        }

        private void btnVedouci_Click(object sender, EventArgs e)
        {
            List<Zamestnanec> vedouci = listBoxZamestnanci.Items
                .Cast<Zamestnanec>()
                .Where(x => x.JeVedouci)
                .ToList();

            MessageBox.Show(String.Join("\r\n", vedouci));
        }

        private void btnAboveAverage_Click(object sender, EventArgs e)
        {
            double average = 0;
            foreach (Zamestnanec z in listBoxZamestnanci.Items) { average += z.PocetHodin; }
            average /= listBoxZamestnanci.Items.Count;

            List<Zamestnanec> frajeri = listBoxZamestnanci.Items
                .Cast<Zamestnanec>()
                .Where(x => x.PocetHodin > average)
                .ToList();

            MessageBox.Show(String.Join("\r\n", frajeri));
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }
    }
}