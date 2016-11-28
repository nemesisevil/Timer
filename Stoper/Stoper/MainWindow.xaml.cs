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
using System.Timers;


namespace Stoper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Czas czas = new Czas();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

            czas.Start();
            Ekran.Content = Convert.ToString("Rozpoczęto Odliczanie");
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            czas.Stop();
            czas.konwertuj();
            Ekran.Content = Convert.ToString(czas.hr + " Godzin, " + czas.mn + " Minut, " + czas.sec + " Sekund," + czas.misec+ " Milisekund");
            //Ekran.Content += czas.timer.ToString();
        }

        private void Reser_Click(object sender, RoutedEventArgs e)
        {
            czas.reset();
            Ekran.Content = Convert.ToString("Wyczyszczono dane");
        }
    }
}
