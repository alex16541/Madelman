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
using System.Data.Entity;

namespace Madelman
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Entities db;
        public Registration()
        {
            InitializeComponent();
            db = new Entities();
            db.Users.Load();
            db.Roles.Load();
            this.Top = (1080 - this.Height) / 2;
            this.Left = (1920 - this.Width) / 2;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text != "")
            {
                if (pbPassword.Password != "")
                {
                    if (pbRepPassword.Password != "")
                    {
                        if (tbFirstName.Text != "")
                        {
                            if (tbSecondName.Text != "")
                            {
                                if (tbLastName.Text != "")
                                {
                                    if (checkPassword(pbPassword.Password))
                                    {
                                        Users user = new Users
                                        {
                                            Login = tbLogin.Text,
                                            Password = pbPassword.Password,
                                            FirstName = tbFirstName.Text,
                                            SecondName = tbSecondName.Text,
                                            LastName = tbLastName.Text,
                                            RoleId = 3,
                                        };
                                        db.Users.Add(user);
                                        db.SaveChanges();
                                    }
                                    else MessageBox.Show("Неправильный пароль.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                                }
                                else MessageBox.Show("Введите отчество.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                            }
                            else MessageBox.Show("Введите фамилию.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        }
                        else MessageBox.Show("Введите имя.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    }
                    else MessageBox.Show("Повторный пароль не совпадает.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                }
                else MessageBox.Show("Введите пароль.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Введите логин.", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

        private bool checkPassword(string pass)
        {
            bool digit = false;
            bool simbol = false;


            if (pass.Length > 6 && pass.Length < 18)
            {
                for (int i = 0, j = 0; i < pass.Length; i++, j = i + 3)
                {
                    if (j <= pass.Length)
                    {
                        if (pass[i] == pass[i + 1] && pass[i] == pass[i + 2])
                        {
                            return false;
                        }
                    }


                    if (char.IsDigit(pass[i]))
                    {
                        digit = true;
                    }

                    if (pass[i] == '*' || pass[i] == '&' || pass[i] == '{' || pass[i] == '}' || pass[i] == '|' || pass[i] == '+')
                    {
                        simbol = true;
                    }
                }
                if (digit && simbol) return true;
            }
            return false;
        }
    }
}
