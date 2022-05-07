using fusione;
using System;
using System.Windows;
using System.Windows.Input;
using ValidaDownloadByPeakyBlinders.Classi;

namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        private Metodi metodi = new Metodi();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            percorso = metodi.CercaFile();
            if (percorso == "Errore")
            {
                MessageBox.Show("Errore durante la selezione del file");
            }
            else
            {
                LblPercorso.Content = "Percorso del file: " + percorso;
                ASHCalcolato = metodi.CalcoloAsh(percorso);
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
            ASHinUP =  ASHinput.ToUpper();
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
            string controllo = metodi.VerificaFirma(percorsochiave, percorsopgp);
            LblFirmaVerificata.Content = controllo;
        }

        private void BtnCercaChiave_Click(object sender, RoutedEventArgs e)
        {
            percorsochiave = metodi.CercaFile();
            LblFirma.Content = percorsochiave;
        }

        private void BtnCercaPgp_Click(object sender, RoutedEventArgs e)
        {
            percorsopgp = metodi.CercaFile();
            LblPgp.Content = percorsopgp;
        }
    }
}