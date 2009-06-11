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

namespace AttachedEventDemo {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (e.AddedItems.Count > 0)
                MessageBox.Show("You just selected " + e.AddedItems[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("You just clicked " + e.Source);
        }

        private void GenericHandler(object sender, RoutedEventArgs e) {
            if (e.RoutedEvent == Button.ClickEvent)
                MessageBox.Show("You just clicked " + e.Source);
            else if (e.RoutedEvent == ListBox.SelectionChangedEvent) {
                SelectionChangedEventArgs scvg = (SelectionChangedEventArgs)e;
                if (scvg.AddedItems.Count > 0)
                    MessageBox.Show("You have just selected " + scvg.AddedItems[0]);
            }
            else
                MessageBox.Show("Unknown event.");
        }
    }
}
