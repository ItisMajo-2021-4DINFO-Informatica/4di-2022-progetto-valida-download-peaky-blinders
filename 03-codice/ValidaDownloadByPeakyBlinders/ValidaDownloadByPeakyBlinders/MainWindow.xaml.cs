using System.Windows;
using ValidaDownloadByPeakyBlinders.Classi;

namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        private ListaChiavi listachiavi;

        public MainWindow()
        {
            InitializeComponent();
            listachiavi = new ListaChiavi();
            Dg.ItemsSource = listachiavi.ColleChiavi;
        }
    }
}