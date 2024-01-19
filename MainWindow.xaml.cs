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

namespace PR5_Bank
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbox_login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbox_login.Text == "Введите логин")
            {
                tbox_login.Text = string.Empty;
            }
        }

        private void tbox_password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbox_password.Text == "Введите пароль")
            {
                tbox_password.Text = string.Empty;
            }
        }

        private void tbox_login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbox_login.Text == "")
                {
                tbox_login.Text = "Введите логин";
                }
        }

        private void tbox_password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbox_password.Text == "")
            {
                tbox_password.Text = "Введите пароль";
            }
        }
    }
}
