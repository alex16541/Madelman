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
    /// Логика взаимодействия для MaterialsAndFurnitureBase.xaml
    /// </summary>
    public partial class MaterialsAndFurnitureBase : Page
    {
        public MaterialsAndFurnitureBase()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void btnMaterials_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new MaterialsPage());
        }

        private void btnFurniture_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
