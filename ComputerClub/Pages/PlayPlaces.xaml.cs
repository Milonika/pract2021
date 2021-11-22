using ComputerClub.Pages;
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

namespace ComputerClub
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void sit1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("1", "Standart"));
        }

        private void sit2Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("2", "Standart"));
        }

        private void sit3Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("3", "Standart"));
        }

        private void sit4Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("4", "Standart"));
        }

        private void sit6Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("6", "Standart"));
        }

        private void sit5Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("5", "Standart"));
        }

        private void sit7Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("7", "Standart"));
        }

        private void sit8Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("8", "Standart"));
        }

        private void sit9Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("9", "Standart"));
        }

        private void sit10Stansart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("10", "Standart"));
        }

        private void sit1Vip_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("1", "VIP"));
        }

        private void sit2Vip_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("2", "VIP"));
        }

        private void sit3Vip_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("3", "VIP"));
        }

        private void sit4Vip_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("4", "VIP"));
        }

        private void sit5Vip_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("5", "VIP"));
        }

        private void sit1Ultra_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("1", "Ultra"));
        }

        private void sit2Ultra_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("2", "Ultra"));
        }

        private void sit3Ultra_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Booking("3", "Ultra"));
        }
    }
}
