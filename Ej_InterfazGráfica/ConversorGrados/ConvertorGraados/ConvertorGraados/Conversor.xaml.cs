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

namespace ConvertorGraados
{
    /// <summary>
    /// Lógica de interacción para Conversor.xaml
    /// </summary>
    public partial class Conversor : Page
    {
        public Conversor()
        {
            InitializeComponent();
            ctGradocF.Text = "";
            ctGradocC.Text = "";
        }

        private void btGradosF_Click(object sender, RoutedEventArgs e)
        {
            double C = (Convert.ToDouble(ctGradocC.Text) - 32) * 5 / 9;
            ctGradocF.Text = C.ToString();
        }

        private void btGradosC_Click(object sender, RoutedEventArgs e)
        {
            double F = (Convert.ToDouble(ctGradocF.Text) * 1.8) + 32;
            ctGradocC.Text = F.ToString();
        }
    }
    
}
