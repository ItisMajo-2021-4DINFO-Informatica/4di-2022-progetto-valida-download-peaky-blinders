using fusione;
using System;
using System.Windows;
using System.Windows.Input;
using ValidaDownloadByPeakyBlinders.Classi;


namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        Metodi metodi = new Metodi();
        string ASHCalcolato;
        string percorso;
        string percorsochiave;
        string percorsopgp;

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