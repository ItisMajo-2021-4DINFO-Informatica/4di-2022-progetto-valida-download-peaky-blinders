using fusione;
using System;
using System.Windows;
using System.Windows.Input;
using ValidaDownloadByPeakyBlinders.Classi;

namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        private CalcoloSha calcoloSha = new CalcoloSha();
        private CercaFile cercaFile = new CercaFile();
        private VerificaChiavePgp verificaChiavePgp = new VerificaChiavePgp();
        private string ASHCalcolato;
        private string percorso;
        private string percorsochiave;
        private string percorsopgp;

        public MainWindow(bool doNotMakeInvisible)
        {
            InitializeComponent();
        }

        public MainWindow()
        {
            InitializeComponent();
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERRORE NEL'OPERAZIONE RICHIESTA, SE L'ERRORE PERSISTE CHIUDERE l'APP E RIPROVARE");
            }
        }

        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception)
            {
                MessageBox.Show("ERRORE NEL'OPERAZIONE RICHIESTA, SE L'ERRORE PERSISTE CHIUDERE l'APP E RIPROVARE");
            }
        }

        private void BtnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            percorso = cercaFile.RicercaFile();
            if (percorso == "Errore")
            {
                MessageBox.Show("Errore durante la selezione del file");
            }
            else
            {
                LblPercorso.Content = "Percorso del file: " + percorso;
                ASHCalcolato = calcoloSha.CalcoloAsh(percorso);
                if (ASHCalcolato == "ERRORE")
                {
                    MessageBox.Show("Calcolo dello SHA fallito, riprova");
                }
            }
        }

        private void BtnSha_Click(object sender, RoutedEventArgs e)
        {
            string ASHinUP = string.Empty;
            string ASHinput = TxtSha.Text;
            ASHinUP = ASHinput.ToUpper();
            if (ASHinUP == null || ASHinput == " ")
            {
                MessageBox.Show("Errore inserire uno sha di confronto valido");
            }
            else
            {
                if (ASHCalcolato == ASHinUP)
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
            string impronta = string.Empty;
            impronta = TxtImpronta.Text;
            if (percorsopgp == null || percorsopgp == " " || percorsopgp == "Errore" || percorsochiave == null || percorsochiave == " " || percorsochiave == "Errore")
            {
                MessageBox.Show("Inserire dei valori corretti");
            }
            else
            {
                if (impronta == null || impronta == " ")
                {
                    MessageBox.Show("Errore inserire un impronta valida");
                    return;
                }
                else
                {
                    impronta.ToUpper();
                    verificaChiavePgp.VerificaFirma(percorsochiave, percorsopgp, impronta);
                }
            }
        }

        private void BtnCercaChiave_Click(object sender, RoutedEventArgs e)
        {
            percorsochiave = cercaFile.RicercaFile();
            if (percorsochiave == null || percorsochiave == " " || percorsochiave == "Errore")
            {
                MessageBox.Show("Errore inserire una chiave valida");
                return;
            }
            else
            {
                LblFirma.Content = percorsochiave;
            }
        }

        private void BtnCercaPgp_Click(object sender, RoutedEventArgs e)
        {
            percorsopgp = cercaFile.RicercaFile();
            if (percorsopgp == null || percorsopgp == " " || percorsopgp == "Errore")
            {
                MessageBox.Show("Errore inserire un file valido");
                return;
            }
            else
            {
                LblPgp.Content = percorsopgp;
            }
        }
    }
}