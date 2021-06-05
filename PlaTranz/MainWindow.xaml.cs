using Prism.Services.Dialogs;
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
using PlaTranz.NotificationModel;
using MaterialDesignThemes.Wpf;


namespace PlaTranz
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseAppButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonOpenMenu_click(object sender, RoutedEventArgs e)
        {
            OpenMenuButton.Visibility = Visibility.Collapsed;
            CloseMenuButton.Visibility = Visibility.Visible;
        }

        private void ButtoCloseMenu_click(object sender, RoutedEventArgs e)
        {
            OpenMenuButton.Visibility = Visibility.Visible;
            CloseMenuButton.Visibility = Visibility.Collapsed;
        }

        private async void LogOutButton(object sender, RoutedEventArgs e)
        {
            LogNotificationMessage msg = new LogNotificationMessage();
            msg.Message = "HelloLogOff";
            await DialogHost.Show(msg, "RootDialog");
        }

        private async void CloseButton(object sender, RoutedEventArgs e)
        {
            CloseNotificationMessage msg = new CloseNotificationMessage();
            msg.Message = "Hello Close";
            await DialogHost.Show(msg, "RootDialog");
        }

        private void LogOutAppButton(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
            
            
        }
    }
}
