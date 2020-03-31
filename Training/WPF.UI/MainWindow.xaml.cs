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
using Training.Domain.Models;

namespace WPF.UI
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizza = new Pizza();
            pizza.PizzaId = 1;
            pizza.crust.CrustId = 2;
            pizza.crust.Name = "Thin";
            pizza.size.SizeId = 3;
            pizza.size.Name = "Medium";

            lstStuff.Items.Add(pizza);
        }
    }
}
