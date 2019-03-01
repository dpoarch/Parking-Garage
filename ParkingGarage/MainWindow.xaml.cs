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
using System.Windows.Navigation;
using System.Windows.Shapes;
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
        public delegate void RefreshList();
        public event RefreshList RefreshListEvent;
        public MainWindow()
        {
            InitializeComponent();
            ParkedGrid.ItemsSource = park.GetAllParkedVehicles();


        }

        private void RefreshListView()
        {
            ParkedGrid.ItemsSource = park.GetAllParkedVehicles();
            ParkedGrid.Items.Refresh();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ParkedGrid != null)
            {
                if (selector.SelectedIndex == 1)
                {
                    ParkedGrid.ItemsSource = park.GetAllAvailableParkings();
                    ParkedGrid.Items.Refresh();
                }
                else
                {
                    ParkedGrid.ItemsSource = park.GetAllParkedVehicles();
                    ParkedGrid.Items.Refresh();
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
