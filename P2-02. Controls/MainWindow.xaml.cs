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

namespace P2_02.Controls
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool imageSwitch = true;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnClick3(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Image image = (System.Windows.Controls.Image)((Button)sender).Content;
            
            if (imageSwitch)
            {
                image.Source = new BitmapImage(new Uri(@"\assets\immage_circle.png", UriKind.Relative));
            }
            else
            {
                image.Source = new BitmapImage(new Uri(@"\assets\immage_cross.png", UriKind.Relative));
            }

            imageSwitch = !imageSwitch;
            ((Button)sender).IsEnabled = false;
        }
    }
}
