using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoutedEventDemo {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AboutDialog : Window {
        public AboutDialog() {
            InitializeComponent();
            //AddHandler(Window.MouseRightButtonDownEvent, new MouseButtonEventHandler(Window_MouseRightButtonDown), true);
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e) {
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " + e.OriginalSource.GetType().Name + " @ " + e.Timestamp;
            Control source = e.Source as Control;
            if (source.BorderThickness != new Thickness(5)) {
                source.BorderThickness = new Thickness(5);
                source.BorderBrush = Brushes.Black;
            }
            else
                source.BorderThickness = new Thickness(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("button clicked");
        }
    }
}
