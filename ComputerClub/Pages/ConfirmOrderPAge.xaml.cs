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
using ComputerClub.Db;

namespace ComputerClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для ConfirmOrderPAge.xaml
    /// </summary>
    public partial class ConfirmOrderPAge : Page
    {
        public Booking ggqqq;
        public ConfirmOrderPAge()
        {
            InitializeComponent();
            UpdateLV();
            
        }

        void UpdateLV()
        {
            OrdersLV.ItemsSource = MainWindow.db.Booking.ToList();

        }
        private void ConfirmOrder_Click(object sender, RoutedEventArgs e)
        {
            var gg = OrdersLV.SelectedItem as Booking;
            this.ggqqq = MainWindow.db.Booking.Attach(gg);

            ggqqq.IsBooked = true;
            DataContext = this.ggqqq;
            MainWindow.db.SaveChanges();
            UpdateLV();
        }
    }
}
