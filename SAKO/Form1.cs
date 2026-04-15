namespace SAKO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SvozoveStredisko stredisko;
        private void btnStartStopTimer_Click(object sender, EventArgs e)
        {
            // --- INITIALIZATION ---
            if (stredisko == null)
                Init();

            /// --- SIMULATION CONTROLS ---
            btnStartStopTimer.Text = timerShift.Enabled ?
                "Pokraèovat" :
                "Pozastavit";

            timerShift.Enabled = !timerShift.Enabled;

            // --- OTHER CONTROLS ---
            btnExportLog.Enabled = !timerShift.Enabled;
            numVehicleCount.Enabled = false;
        }

        private void timerShift_Tick(object sender, EventArgs e)
        {
            // --- NOTIFIKACE ---

            // pise to 4611686018427387904 misto 1 na zacatku ja nechapu co se deje, neni to ulong_max ani jine maximalni cislo nevim proc to overflowuje zrovna na tohle
            ulong day = stredisko.Day == 4611686018427387904 ? 1 : stredisko.Day + 1; 
            if ((stredisko.Shift)% 4 == 0)
                listBoxLog.Items.Add($"Notifikace vedoucímu - den {day}");

            if(stredisko.Shift % 4 == 0)
            {
                switch (stredisko.DaysOfLowCapacity)
                {
                    case 1:
                    case 2:
                    case 4:
                        listBoxLog.Items.Add($"Notifikace vedoucímu - Snížená Kapacita po dobu {stredisko.DaysOfLowCapacity} dní");
                        break;
                    case >= 6:
                        listBoxLog.Items.Add($"Notifikace všem - !!KRIZE, SNÍŽENÁ KAPACITA PO DOBU {stredisko.DaysOfLowCapacity} DNÍ!!");
                        break;
                }
            }

            // --- LOG ---
            listBoxLog.Items.Add(stredisko.Tick());
            
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            // --- KAPACITA / SMÌNY / DNY ---
            lblRelativeCapacity.Text = Math.Round(stredisko.RelativeCapacityPercentage).ToString() + "%";
            lblShiftDay.Text = $"{stredisko.Shift} / {stredisko.Day}";

            // --- STATUS S BARVICKAMA ---
            lblCapacityStatus.Text = stredisko.CapacityStatus;
            if (lblCapacityStatus.Text.StartsWith("OK"))
                panel2.BackColor = Color.Lime;
            else if (lblCapacityStatus.Text.StartsWith("SNIZENA"))
                panel2.BackColor = Color.Orange;
            else if (lblCapacityStatus.Text.StartsWith("KRIZE"))
                panel2.BackColor = Color.Red;

            // --- STAV INCIDENTU ---
            lblIncidentStatus.Text = stredisko.DaysOfLowCapacity == 0 ?
                "Žádný incident" :
                $"{stredisko.DaysOfLowCapacity} DNÍ OD INCIDENTU!";
        }

        private void Init()
        {
            stredisko = new SvozoveStredisko((int)numVehicleCount.Value);

            lblTotalCapacity.Text = Math.Round(stredisko.MaxCapacity).ToString() + "t";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTotalCapacity.Text = "null";
            lblCapacityStatus.Text = "null";
            lblIncidentStatus.Text = "null";
            lblRelativeCapacity.Text = "? %";
            lblShiftDay.Text = "? / ?";

            numVehicleCount.Enabled = true;

            listBoxLog.Items.Clear();

            timerShift.Enabled = false;

            btnStartStopTimer.Text = "Spustit";
            btnExportLog.Enabled = false;
            stredisko = null;
        }

        private void btnExportLog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    Export(sfd.FileName);
            }
        }

        private void Export(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach(var item in listBoxLog.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}