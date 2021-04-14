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
    public partial class FurniturePage : Page
    {
        Entities db;
        public FurniturePage()
        {
            InitializeComponent();
            db = new Entities();
            db.Furniture.Load();
            db.Units.Load();
            db.Products.Load();
            db.MaterialsType.Load();
            dgMaterials.ItemsSource = db.Furniture.Local.ToBindingList();
            if (Properties.Settings.Default.IsEditableTablse)
                dgMaterials.Columns[dgMaterials.Columns.Count - 1].Visibility = Visibility.Visible;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int index = dgMaterials.SelectedIndex + 1;

            var editFP = new EditFurniturePage();

            editFP.furniture = db.Furniture.Find(index);
            editFP.owner = new EditWindow(editFP);
            editFP.db = this.db;
            if (editFP.owner.ShowDialog() == true)
                dgMaterials.Items.Refresh();

        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {
            int index = dgMaterials.SelectedIndex;
            var furniture = db.Furniture.Find(index);
            if (furniture.Count == 0)
                MessageBox.Show($"Вы не можете удалить {furniture.Title} т.к. количество не равно нелю.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            var result = MessageBox.Show($"Вы точно хотите удалиль {furniture.Title}?", "Внимание", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                db.Furniture.Remove(furniture);
                db.SaveChanges();
            }
        }
    }
}
