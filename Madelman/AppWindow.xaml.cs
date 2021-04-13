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
using System.Windows.Navigation;



namespace Madelman
{
    /// <summary>
    /// Логика взаимодействия для AppWindow.xaml
    /// </summary>
    public partial class AppWindow : NavigationWindow
    {
        public AppWindow(string role)
        {
            InitializeComponent();
            this.Top = (1080 - this.Height) / 2;
            this.Left = (1920 - this.Width) / 2;
            switch (role)
            {
                case "Менеджер":
                    this.Title = "Manager";
                    this.NavigationService.Navigate(new ManagerMenu(this)); 
                    break;
                case "Заместитель директора":
                    this.Title = "Dep. Director";
                    Properties.Settings.Default.IsEditableTablse = true;
                    this.NavigationService.Navigate(new DepDirectorMenu(this));
                    break;
                case "Заказчик":
                    this.Title = "Customer";
                    this.NavigationService.Navigate(new ManagerMenu(this));
                    break;
                case "Директор":
                    this.Title = "Director";
                    Properties.Settings.Default.IsEditableTablse = true;
                    this.NavigationService.Navigate(new DirectorMenu(this));
                    break;
                case "Мастер":
                    this.Title = "Master";
                    this.NavigationService.Navigate(new MasterMenu(this));
                    break;
            }
        }
    }
}
