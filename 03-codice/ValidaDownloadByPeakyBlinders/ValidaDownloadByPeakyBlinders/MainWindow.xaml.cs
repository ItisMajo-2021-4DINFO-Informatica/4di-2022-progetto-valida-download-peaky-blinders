﻿using System.Windows;
using ValidaDownloadByPeakyBlinders.Classi;

namespace ValidaDownloadByPeakyBlinders
{
    public partial class MainWindow : Window
    {
        private ListaChiavi listachiavi;
        private Metodi metodi;
        string ASHCalcolato;


        public MainWindow()
        {
            InitializeComponent();
            listachiavi = new ListaChiavi();
            metodi = new Metodi();
            Dg.ItemsSource = listachiavi.ColleChiavi;
        }

        private void BtnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            string percorso = metodi.CercaFile();
            LblPercorso.Content = "Percorso del file: " + percorso;
            ASHCalcolato = metodi.CalcoloAsh(percorso);
        }

        private void BtnSha_Click(object sender, RoutedEventArgs e)
        {
            string ASHinput = TxtSha.Text;
            if (ASHCalcolato == ASHinput)
            {
                LblSha.Content = "L'ASH CALCOLATO CORRISPONDE CON QUELLO DEL FILE";
            }
            else
            {
                LblSha.Content = "ATTENZIONE L'ASH CALCOLATO NON CORRISPONDE";
            }
        }
    }
}