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
using System.Data.Entity;

namespace Madelman
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Entities();
            db.Users.Load();
            db.Roles.Load();
            this.Top = (1080 - this.Height) / 2;
            this.Left = (1920 - this.Width) / 2;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = pbPassword.Password;

            Users user = db.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
            if(user != null)
            {
                new AppWindow(user.Roles.Title).Show();
                db.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введён неправельный логин или пароль", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            db.Dispose();
            this.Close();
        }
    }
}
