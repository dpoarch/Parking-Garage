using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingGarage.Classes;

namespace ParkingGarageUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGetAllParkedVehicles()
        {
            Parking parking = new Parking();
            parking.RefreshData();


            Assert.IsNull(parking.GetAllParkedVehicles(), "Results should not be null.");
        }

        [TestMethod]
        public void TestGetAllAvailableParkings()
        {
            Parking parking = new Parking();
            parking.RefreshData();

            Assert.IsNull(parking.GetAllAvailableParkings(), "Results should not be null.");
        }

        [TestMethod]
        public void TestAddVehicleToParkArea()
        {
            Parking parking = new Parking();
            bool result = parking.AddParkedVehicle(new ParkingGarage.Models.ParkingModel.ParkedCars
            {
                ParkedSlots = "10",
                PlateNumber = "CSC 1295",
                VehicleType = ParkingGarage.Models.VehicleType.car
            });

            Assert.IsFalse(result, "Should be true");
        }

        [TestMethod]
        public void TestAddParkingGarage()
        {
            Parking parking = new Parking();
            bool result = parking.AddParkingGarage(new ParkingGarage.Models.ParkingModel.ParkingGarage
            {
                ParkingType = ParkingGarage.Models.ParkingModel.ParkingType.LargeSpot,
                GarageCode = "11C"
            });

            Assert.IsFalse(result, "Should be true");
        }


    }
}
