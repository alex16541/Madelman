using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Madelman
{
    public class Master : Page
    {
        public Master()
        {
            
        }

        public Window appWindow { get; set; }
        public override void OnApplyTemplate()
        {
            InitEvent();
        }

        void InitEvent()
        {
            var btnBack = this.Template.FindName("btnBack", this) as Button;
            if (btnBack != null)
            {
                btnBack.Click += btnBack_Click;
            }
            var btnExit = this.Template.FindName("btnExit", this) as Button;
            if (btnBack != null)
            {
                btnBack.Click += btnExit_Click;
            }
            
        }
        public void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        public void btnExit_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            appWindow.Close();
            
        }
    }
}
