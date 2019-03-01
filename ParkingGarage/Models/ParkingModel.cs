using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Models
{
    public class ParkingModel
    {
        public enum ParkingType
        {
            MotorcycleSpot,
            CompactSpot,
            LargeSpot
        }

        public enum ParkingStatus
        {
            Available,
            Unavailable
        }

        public class ParkedCars
        {
            public int Id { get; set; }
            public VehicleType VehicleType { get; set; }
            public string PlateNumber { get; set; }
            [DisplayName("Parked On Garage")]
            public string ParkedSlots { get; set; }
        }

        public class ParkingGarage
        {
            public int Id { get; set; }
            public string GarageCode { get; set; }
            public ParkingType ParkingType { get; set; }
        }

        public class ParkedCarsDisplay
        {
            public int Id { get; set; }
            public VehicleType VehicleType { get; set; }
            public string PlateNumber { get; set; }
            [DisplayName("Parked On Garage")]
            public string ParkedSlots { get; set; }
        }
    }
}
