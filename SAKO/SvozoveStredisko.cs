using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SAKO
{
    internal class SvozoveStredisko
    {
        private Random random = new Random();

        private int _daysOfLowCapacity = 0;
        private ulong _shiftIndex = 0;
        
        private int _vehicleCount;
        private double _maxCapacity;
        private double _capacity;
        private double _vehicleCapacity = 6.7f;

        public int VehicleCount { get { return _vehicleCount; }  set { _vehicleCount = value; } }
        public double MaxCapacity { get { return _maxCapacity; } }
        public double Capacity { get { return _capacity; } set { _capacity = value; } }
        public double VehicleCapacity { get { return _vehicleCapacity; } set { _vehicleCapacity = value; } }


        public SvozoveStredisko(int vehicles)
        {
            _vehicleCount = vehicles;

            // --- CAPACITY --
            _maxCapacity = 10 * _vehicleCount * _vehicleCapacity;
            _capacity = _maxCapacity;
        }

        public string Tick()
        {
            _shiftIndex++;

            int imports = random.Next(3);
            int exports = random.Next(4);

            double previousCapacity = _capacity;
            _capacity = Math.Clamp(_capacity + imports * _vehicleCapacity - exports * _vehicleCapacity, 0, _maxCapacity);
            double deltaCapacity = Math.Round(_capacity - previousCapacity, 1);

            // --- LOG ---
            string signedDelta = deltaCapacity >= 0 ? "+" : "";
            signedDelta += deltaCapacity;

            // --- DETEKCE ÚPADKU ---
            if(_shiftIndex % 4 == 0)
            {
                if (RelativeCapacityPercentage >= 75)
                    _daysOfLowCapacity = 0;
                else _daysOfLowCapacity++;
            }

            return $"[Směna {_shiftIndex}] Příjezdy: {imports} | Odjezdy: {exports} | {signedDelta} t | {Math.Round(Capacity)} t ({Math.Round(100 * Capacity / _maxCapacity)}%)";
        }
        public double RelativeCapacityPercentage { get { return 100 * Capacity / MaxCapacity; } }

        public ulong Shift { get { return _shiftIndex; } }
        public ulong Day { get { return 1 + (_shiftIndex - 1) / 4; } }
        public string CapacityStatus
        {
            get
            {
                string status = RelativeCapacityPercentage switch
                {
                    >=75 => "OK",
                    _ => "SNIZENA"
                };
                if (_daysOfLowCapacity >= 6) status = "KRIZE";

                return $"{status} | {Math.Round(RelativeCapacityPercentage)}% | {Math.Round(_capacity, 1)} t";
            }
        }
        public int DaysOfLowCapacity { get { return _daysOfLowCapacity; } }
    }
}
