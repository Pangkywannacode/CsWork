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

namespace HelloGui
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //get data from window
            double income = Convert.ToDouble(InCome.Text);
            double expenditure = Convert.ToDouble(Expenditure.Text);
            double Price = Convert.ToDouble(PriceOfThingWantToBuy.Text);

            //calculate day
            string day = Convert.ToString(Math.Round(Price / (income - expenditure)));

            //show result
            Day.Text = day;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
