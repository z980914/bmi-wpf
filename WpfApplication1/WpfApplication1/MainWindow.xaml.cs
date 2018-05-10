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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double a = Math.Round(HeightSlider.Value, 2);
            HeightNmuber.Text = a.ToString();

            double b = a / 200 * 360;
            Canvas.SetLeft(Length,b);

            double c= Math.Round(WeightSlider.Value, 2);
            WeightNmuber.Text = c.ToString();
            
            double h = double.Parse(HeightNmuber.Text);
           
            double w = double.Parse(WeightNmuber.Text);
            double bmi = w / Math.Pow((h / 100), 2);
            double x = Math.Floor(bmi);
            double y = Math.Round((bmi - x)*100, 0+);
            BMIinfront.Text = x.ToString ();
            BMIbehind.Text = "."+y .ToString();    
        }
    }
}
