using System.Windows;
using ValidaDownloadByPeakyBlinders.Classi;

namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        private ListaChiavi listachiavi;
        private Metodi metodi;
        private string ASHCalcolato;
        private string percorso;

        public MainWindow()
        {
            InitializeComponent();
            listachiavi = new ListaChiavi();
            metodi = new Metodi();
            Dg.ItemsSource = listachiavi.ColleChiavi;
        }

        private void BtnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            percorso = metodi.CercaFile();
            LblPercorso.Content = "Percorso del file: " + percorso;
            ASHCalcolato = metodi.CalcoloAsh(percorso);
        }

        private void BtnSha_Click(object sender, RoutedEventArgs e)
        {
            string ASHinput = TxtSha.Text;
            if (ASHinput == null || ASHinput == " ")
            {
                LblSha.Content = "ERRORE INSERIRE UNO SHA DI CONFRONTO";
            }
            else
            {
                if (ASHCalcolato == ASHinput)
                {
                    LblSha.Content = "LO SHA CALCOLATO CORRISPONDE CON QUELLO DEL FILE";
                }
                else
                {
                    LblSha.Content = "ATTENZIONE LO SHA CALCOLATO NON CORRISPONDE";
                }
            }
        }

        private void BtnFirma_Click(object sender, RoutedEventArgs e)
        {
            string firma = TxtFirma.Text;
            bool controllo = metodi.VerificaFirma(firma, percorso);
            if (controllo != true)
            {
                LblFirma.Content = "ATTENZIONE IL FILE NON È ORIGINALE";
            }
            else 
            {
                LblFirma.Content = "IL FILE È ORIGINALE";
            }
        }
    }
}