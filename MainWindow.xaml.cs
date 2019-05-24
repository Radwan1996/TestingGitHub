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
using TestBinding.Models;
namespace TestBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PropertClass inst;
        public MainWindow()
        {
            InitializeComponent();
            inst = new PropertClass { Name="radwan" , Age=23, IsChanged= false};
            this.DataContext = inst;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                string message = inst.Name + " is " + inst.Age;
                MessageBox.Show(message);
            
        }

        private void ageText_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
