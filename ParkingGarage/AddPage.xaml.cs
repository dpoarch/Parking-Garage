using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ParkingGarage.Models;
using ParkingGarage.Classes;

namespace ParkingGarage
{
    /// <summary>
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Window
    {
        MainWindow main = new MainWindow();
        public Garage garage = new Garage();

        public AddPage()
        {
            InitializeComponent();
            parkingGarage.ItemsSource = main.park.GetAllAvailableParkings().Select(i => i.Id).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool error = false;
            string slots = parkingGarage.Text;
            int parkID = Convert.ToInt32(parkingGarage.Text);
            if (vehicleType.SelectedIndex == 2)
            {
                
                for (int i = parkID + 1; i < parkID + 5; i++)
                {
                    slots += "," + i;
                }
            }

            var parktype = main.park.GetParkingType(parkID);
            if (vehicleType.SelectedIndex == 1 && parktype == ParkingModel.ParkingType.MotorcycleSpot)
            {
                error = true;
                lblError.Content = "Vehicle can't be parked on that spot.";
                lblError.Visibility = Visibility.Visible;
            }

            if (vehicleType.SelectedIndex == 2 && (parktype == ParkingModel.ParkingType.MotorcycleSpot || parktype == ParkingModel.ParkingType.CompactSpot))
            {
                error = true;
                lblError.Content = "Vehicle can't be parked on that spot.";
                lblError.Visibility = Visibility.Visible;
            }

            if (!error)
            {
                main.park.AddParkedVehicle(new ParkingModel.ParkedCars
                {
                    PlateNumber = plateNumber.Text,
                    VehicleType = vehicleType.SelectedIndex == 0 ? VehicleType.motorcycle : vehicleType.SelectedIndex == 1 ? VehicleType.car : VehicleType.bus,
                    ParkedSlots = slots

                });

                main.park.RefreshData();
                main.parkedCars = main.park.GetAllParkedVehicles();
                Close();
            }
        }
    }
}
