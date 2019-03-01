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
        public Parking park = new Parking();

        public AddPage()
        {
            InitializeComponent();
            parkingGarage.ItemsSource = park.GetAllAvailableParkings().Select(i => i.Id).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            park.AddParkedVehicle(new ParkingModel.ParkedCars
            {
                PlateNumber = plateNumber.Text,
                VehicleType = vehicleType.SelectedIndex == 0 ? VehicleType.motorcycle : vehicleType.SelectedIndex == 1 ? VehicleType.car : VehicleType.bus,
                ParkedSlots = parkingGarage.Text
                
            });
            
            MainWindow main = new MainWindow();
            main.ParkedGrid.ItemsSource = park.GetAllParkedVehicles();
            main.ParkedGrid.Items.Refresh();
            Close();
        }
    }
}
