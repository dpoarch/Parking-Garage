using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingGarage.Models;

namespace ParkingGarage.Interfaces
{
    public interface IPark
    {
        void RefreshData();
        ParkingModel.ParkingType GetParkingType(int id);
        ObservableCollection<ParkingModel.ParkedCarsDisplay> GetAllParkedVehicles();
        ObservableCollection<ParkingModel.ParkingGarage> GetAllAvailableParkings();
        void FetchAllParkedVehicles();
        void FetchAllAvailableParkings();
        bool AddParkedVehicle(ParkingModel.ParkedCars parkedCars);
        bool RemoveParkedVehicle(ParkingModel.ParkedCars parkedCars);
        bool AddParkingGarage(ParkingModel.ParkingGarage parkingGarage);

    }
}
