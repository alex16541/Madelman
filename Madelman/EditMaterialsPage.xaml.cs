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

namespace Madelman
{
    /// <summary>
    /// Логика взаимодействия для EditMaterialsPage.xaml
    /// </summary>
    public partial class EditMaterialsPage : Page
    {
        Entities db = new Entities();
        public Materials material { get; set; }
        public Window owner { get; set; }
        public EditMaterialsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tbTitle.Text = material.Title;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            db.Dispose();
            owner.Close();
        }
    }
}
