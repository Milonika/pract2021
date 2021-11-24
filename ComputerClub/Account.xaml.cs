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
using ComputerClub.Db;

namespace ComputerClub
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) // email
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) //Password
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) //
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // registration
        {
            Regis regis = new Regis();
            regis.Show();
        }

        public static ComputerClubEntities cc = new ComputerClubEntities();
        public static Authorization authUser;

        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in cc.Authorization)
            {
                if (user.Login == LoginTB.Text.Trim())
                {
                    if (user.Password == PasswordPB.Password.Trim() && user.ID_Rols == 2)
                    {
                        MessageBox.Show($"Привет Пользователь {user.User_Name}");
                        authUser = user;
                        MainWindow.user = user;
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                    if (user.Password == PasswordPB.Password.Trim() && user.ID_Rols == 1)
                    {
                        MessageBox.Show($"Привет админ {user.User_Name}");
                        MainWindow.user = user;
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void GGCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
