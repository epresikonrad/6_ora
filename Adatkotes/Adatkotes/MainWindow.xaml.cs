using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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


using System.Windows.Threading;

namespace Adatkotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private int osszekotoSzam = 0;
        public int OsszekotoSzam {
            get { return osszekotoSzam; }
            set {
                if (osszekotoSzam!=value)
                {
                    osszekotoSzam = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer Idozito = new DispatcherTimer();
            Idozito.Interval = TimeSpan.FromSeconds(1);
            Idozito.Tick += IdoLepes;
            Idozito.Start();
        }

        private int ido = 0;
        private void IdoLepes(object sender, EventArgs e)
        {
            ido++;
            IdoText.Content = ido.ToString();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            OsszekotoSzam = 0;
        }
    }
}
