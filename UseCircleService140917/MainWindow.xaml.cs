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

namespace UseCircleService140917
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private CircleService.CircleServiceClient _service = new CircleService.CircleServiceClient();

        private void Diameter_Click(object sender, RoutedEventArgs e)
        {
            double input = Double.Parse(TextBox1.Text);
            double output = _service.CalcDiameter(input);
            Label1.Content = output;
        }

        private void Circumference_Click(object sender, RoutedEventArgs e)
        {
            double input = Double.Parse(TextBox1.Text);
            double output = _service.CalcCircumference(input);
            Label1.Content = output;
        }
    }
}
