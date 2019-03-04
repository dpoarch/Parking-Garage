using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ParkingGarage.Classes;
using ParkingGarage.Models;

namespace ParkingGarage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Parking park = new Parking();

        public ObservableCollection<ParkingModel.ParkedCarsDisplay> parkedCars;
        public ObservableCollection<ParkingModel.ParkingGarage> parkGarages;
        public MainWindow()
        {
            InitializeComponent();
            park.RefreshData();
            parkedCars = park.GetAllParkedVehicles();
            ParkedGrid.ItemsSource = parkedCars;

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Start();


        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            park.RefreshData();
            parkedCars = park.GetAllParkedVehicles();
            ParkedGrid.ItemsSource = parkedCars;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ParkedGrid != null)
            {
                if (selector.SelectedIndex == 1)
                {
                    parkGarages = park.GetAllAvailableParkings();
                    ParkedGrid.ItemsSource = parkGarages;
                }
                else
                {
                    parkedCars = park.GetAllParkedVehicles();
                    ParkedGrid.ItemsSource = parkedCars;
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPage addPage = new AddPage();
            addPage.Show();
        }
        
    }
}
