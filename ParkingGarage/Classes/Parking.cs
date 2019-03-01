using System;
using System.Collections.Generic;
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

        public List<ParkingModel.ParkedCarsDisplay> GetAllParkedVehicles()
        {
            List<ParkingModel.ParkedCarsDisplay> display = new List<ParkingModel.ParkedCarsDisplay>();
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
            return display;
        }

        public List<ParkingModel.ParkingGarage> GetAllAvailableParkings()
        {
            List<ParkingModel.ParkingGarage> newGarageList = new List<ParkingModel.ParkingGarage>();
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
            return newGarageList;
        }

        //public List<ParkingModel.ParkingGarage> GetParkings(ParkingModel.ParkingStatus status, ParkingModel.ParkingType type)
        //{
        //    List<ParkingModel.ParkingGarage> unsuedGarage = new List<ParkingModel.ParkingGarage>();
        //    List<ParkingModel.ParkingGarage> parkingGarage = garageContext.ParkingGarage.ToList();
        //    List<ParkingModel.ParkedCars> parkingCars = garageContext.ParkedCars.ToList();
        //    foreach (ParkingModel.ParkingGarage garage in parkingGarage)
        //    {
        //        int parkedCount = parkingCars.Where(i => i.ParkedSlots.Contains(garage) && i.ParkingType == type).Count();
        //        if (status == ParkingModel.ParkingStatus.Available)
        //        {
        //            if (parkedCount == 0)
        //            {
        //                unsuedGarage.Add(garage);
        //            }
        //        }
        //        else
        //        {
        //            if (parkedCount > 0)
        //            {
        //                unsuedGarage.Add(garage);
        //            }
        //        }

        //    }

        //    return unsuedGarage;
        //}

        public bool AddParkedVehicle(ParkingModel.ParkedCars parkedCars)
        {
            try
            {
                garageContext.ParkedCars.Add(parkedCars);
                garageContext.SaveChanges();
                return true;
            }
            catch(Exception e)
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
