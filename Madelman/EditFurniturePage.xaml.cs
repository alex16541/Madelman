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
    /// Логика взаимодействия для EditMaterialsPage.xaml
    /// </summary>
    public partial class EditFurniturePage : Page
    {
        public Entities db { get; set; }
        public Furniture furniture { get; set; }
        public Window owner { get; set; }
        public EditFurniturePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tbTitle.Text = furniture.Title;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            owner.DialogResult = false;
            owner.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            furniture.Title = tbTitle.Text;
            db.SaveChanges();
            owner.DialogResult = true;
            owner.Close();
        }
    }
}
