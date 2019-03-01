using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingGarage.Models;

namespace ParkingGarage.Interfaces
{
    public interface IPark
    {
        List<ParkingModel.ParkedCarsDisplay> GetAllParkedVehicles();
        List<ParkingModel.ParkingGarage> GetAllAvailableParkings();
        //List<ParkingModel.ParkingGarage> GetParkings(ParkingModel.ParkingStatus status, ParkingModel.ParkingType type);
        bool AddParkedVehicle(ParkingModel.ParkedCars parkedCars);
        bool RemoveParkedVehicle(ParkingModel.ParkedCars parkedCars);
        bool AddParkingGarage(ParkingModel.ParkingGarage parkingGarage);

    }
}
