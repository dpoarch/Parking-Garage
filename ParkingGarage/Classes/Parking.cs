using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingGarage.Interfaces;
using ParkingGarage.Models;

namespace ParkingGarage.Classes
{
    public class Parking : IPark
    {
        Garage garageContext = new Garage();
        private ObservableCollection<ParkingModel.ParkedCarsDisplay> parkedVehicles;
        private ObservableCollection<ParkingModel.ParkingGarage> parkingGarages;

        public void RefreshData()
        {
            FetchAllParkedVehicles();
            FetchAllAvailableParkings();
        }

        public ObservableCollection<ParkingModel.ParkedCarsDisplay> GetAllParkedVehicles()
        {
            return parkedVehicles;
        }

        public ObservableCollection<ParkingModel.ParkingGarage> GetAllAvailableParkings()
        {
            return parkingGarages;
        }

        public void FetchAllParkedVehicles()
        {
            ObservableCollection<ParkingModel.ParkedCarsDisplay> display = new ObservableCollection<ParkingModel.ParkedCarsDisplay>();
            List<ParkingModel.ParkedCars> parkedCars = garageContext.ParkedCars.ToList();
            foreach(ParkingModel.ParkedCars cars in parkedCars)
            {
                string parkedOn = "";
                string[] slots = cars.ParkedSlots.Split(',');
                foreach (string id in slots)
                {
                    int newid = Convert.ToInt32(id);
                    parkedOn += garageContext.ParkingGarage.FirstOrDefault(i => i.Id == newid).GarageCode + " | ";
                }
                ParkingModel.ParkedCarsDisplay car = new ParkingModel.ParkedCarsDisplay()
                {
                    Id = cars.Id,
                    VehicleType = cars.VehicleType,
                    PlateNumber = cars.PlateNumber,
                    ParkedSlots = parkedOn
                };

                display.Add(car);
            }
            parkedVehicles = display;
        }

        public void FetchAllAvailableParkings()
        {
            ObservableCollection<ParkingModel.ParkingGarage> newGarageList = new ObservableCollection<ParkingModel.ParkingGarage>();
            List<ParkingModel.ParkedCars> parkedCars = garageContext.ParkedCars.ToList();
            List<ParkingModel.ParkingGarage> parkingGarage = garageContext.ParkingGarage.ToList();
            foreach(var garage in parkingGarage)
            {
                bool toAdd = true;
                foreach(var cars in parkedCars)
                {
                    if (cars.ParkedSlots.Contains(garage.Id.ToString()))
                    {
                        toAdd = false;
                    }
                }
                if (toAdd)
                {
                    newGarageList.Add(garage);
                }
            }
            parkingGarages = newGarageList;
        }

        public ParkingModel.ParkingType GetParkingType(int id)
        {
            return garageContext.ParkingGarage.FirstOrDefault(i => i.Id == id).ParkingType;
        }
        
        public bool AddParkedVehicle(ParkingModel.ParkedCars parkedCars)
        {
            try
            {
                garageContext.ParkedCars.Add(parkedCars);
                garageContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveParkedVehicle(ParkingModel.ParkedCars parkedCars)
        {
            try
            {
                garageContext.ParkedCars.Remove(parkedCars);
                garageContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddParkingGarage(ParkingModel.ParkingGarage parkingGarage)
        {
            garageContext.ParkingGarage.Add(parkingGarage);
            garageContext.SaveChanges();
            return true;
        }
    }
}
