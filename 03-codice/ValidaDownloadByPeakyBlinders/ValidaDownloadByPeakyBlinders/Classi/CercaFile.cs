using Microsoft.Win32;
using System;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class CercaFile
    {
        public string RicercaFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return "Errore";
                }
            }
            catch (Exception)
            {
                return "Errore";
            }
        }
    }
}