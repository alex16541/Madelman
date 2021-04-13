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
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        Entities db;
        public MaterialsPage()
        {
            InitializeComponent();
            db = new Entities();
            db.Materials.Load();
            db.Units.Load();
            db.Products.Load();
            db.MaterialsType.Load();
            dgMaterials.ItemsSource = db.Materials.Local.ToBindingList();
            if(Properties.Settings.Default.IsEditableTablse)
                dgMaterials.Columns[dgMaterials.Columns.Count-1].Visibility = Visibility.Visible;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
