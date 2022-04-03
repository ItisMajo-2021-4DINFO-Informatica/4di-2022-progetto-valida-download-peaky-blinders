using System.Windows;
using ValidaDownloadByPeakyBlinders.Classi;

namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        private ListaChiavi listachiavi;
        private Metodi metodi;

        public MainWindow()
        {
            InitializeComponent();
            listachiavi = new ListaChiavi();
            metodi = new Metodi();
            Dg.ItemsSource = listachiavi.ColleChiavi;
        }

        private void BtnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            LblPercorso.Content = "Percorso del file: " + metodi.CercaFile();
        }
    }
}